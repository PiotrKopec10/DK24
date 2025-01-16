using MySql.Data.MySqlClient;

namespace DK24.Klasy
{
    internal class FakturaClass
    {
        string PolaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;

        public int invoice_id = 0;
        public int order_order_id = 0;
        public int company_details_id = 0;
        public int billing_address_id = 0;
        public string invoice_number = "";
        public DateOnly issue_date;
        public decimal total_amount = 0;
        public DateTime created_at;













        public string PobierzNumerFaktury()
        {
            string nrFaktury = "";

            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string PobierzNumerFaktury = @"
                SELECT CONCAT('FV-', YEAR(NOW()), '-', LPAD(COALESCE(MAX(CAST(SUBSTRING_INDEX(invoice_number, '-', -1) AS UNSIGNED)) + 1, 1), 5, '0')) AS next_invoice_number
                FROM serwer197774_drukarnia.invoices
                WHERE invoice_number LIKE CONCAT('FV-', YEAR(NOW()), '-%');";

                    using (MySqlCommand sqlPobierzNumerFaktury = new MySqlCommand(PobierzNumerFaktury, polaczenie))
                    {
                        using (MySqlDataReader reader = sqlPobierzNumerFaktury.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(0))
                            {
                                nrFaktury = reader.GetString("next_invoice_number");
                            }
                            else
                            {
                                nrFaktury = "";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd Pobierania nr Faktury: " + ex.Message, "Błąd");
                    nrFaktury = "";
                }
                finally
                {
                    polaczenie.Close();
                }
            }

            return nrFaktury;
        }


        public void DodajFaktureDoBazy(FakturaClass dodawanaFaktura)
        {
            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                    {
                        string DodajFakture = @"
                    INSERT INTO invoices
                        (order_order_id, company_details_id, billing_address_id, invoice_number, issue_date, total_amount, created_at)
                    VALUES
                        (@order_order_id, @company_details_id, @billing_address_id, @invoice_number, @issue_date, @total_amount, @created_at);";

                        using (MySqlCommand sqlDodajKontrahenta = new MySqlCommand(DodajFakture, polaczenie, transakcja))
                        {

                            sqlDodajKontrahenta.Parameters.AddWithValue("@order_order_id", dodawanaFaktura.order_order_id);
                            sqlDodajKontrahenta.Parameters.AddWithValue("@company_details_id", dodawanaFaktura.company_details_id);
                            sqlDodajKontrahenta.Parameters.AddWithValue("@billing_address_id", dodawanaFaktura.billing_address_id);
                            sqlDodajKontrahenta.Parameters.AddWithValue("@invoice_number", dodawanaFaktura.invoice_number);

                            sqlDodajKontrahenta.Parameters.AddWithValue("@issue_date", dodawanaFaktura.issue_date.ToString("yyyy-MM-dd"));

                            sqlDodajKontrahenta.Parameters.AddWithValue("@total_amount", dodawanaFaktura.total_amount);

                            sqlDodajKontrahenta.Parameters.AddWithValue("@created_at", DateTime.Now);

                            sqlDodajKontrahenta.ExecuteNonQuery();
                        }
                        transakcja.Commit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd Dodawania Faktury: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }
        }



        public FakturaClass PobierzPotrzebneDaneWedlugOrderIdDoInsertaBazy(int order_id)
        {
            FakturaClass pobieraneDane = new FakturaClass();
            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();
                    string sql = @"
                SELECT 
                    o.order_id,
                    o.total_price,
                    o.created_at, 
                    cd.company_details_id,
                    cd.address_id AS cd_billing_address_id 
                FROM orders o
                LEFT JOIN company_details cd ON o.user_id = cd.user_id
                WHERE o.order_id = @OrderId
                LIMIT 1;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, polaczenie))
                    {
                        cmd.Parameters.AddWithValue("@OrderId",order_id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                pobieraneDane.order_order_id = reader["order_id"] != DBNull.Value ? Convert.ToInt32(reader["order_id"]) : 0;
                                pobieraneDane.company_details_id = reader["company_details_id"] != DBNull.Value ? Convert.ToInt32(reader["company_details_id"]) : 0;
                                pobieraneDane.billing_address_id = reader["cd_billing_address_id"] != DBNull.Value ? Convert.ToInt32(reader["cd_billing_address_id"]) : 0;
                                pobieraneDane.total_amount = reader["total_price"] != DBNull.Value ? Convert.ToDecimal(reader["total_price"]) : 0m;
                                pobieraneDane.invoice_number = pobieraneDane.PobierzNumerFaktury();
                                pobieraneDane.issue_date = DateOnly.FromDateTime(DateTime.Now);
                                pobieraneDane.created_at = DateTime.Now;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania danych dla faktury: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }
            return pobieraneDane;
        }




        public bool CzyNipZOrdersJestWBazieCompanyDetails(int orderId)
        {
            bool istnieje = false;
            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                polaczenie.Open();

                string sqlPobierzNip = @"
            SELECT number_nip
            FROM orders
            WHERE order_id = @OrderId
            LIMIT 1;
        ";
                using (MySqlCommand cmd1 = new MySqlCommand(sqlPobierzNip, polaczenie))
                {
                    cmd1.Parameters.AddWithValue("@OrderId", orderId);
                    object nipObj = cmd1.ExecuteScalar();

                    if (nipObj != null && nipObj != DBNull.Value)
                    {
                        string nipZamowienia = nipObj.ToString();

                       
                        string sqlSprawdzNip = @"
                    SELECT COUNT(*)
                    FROM company_details
                    WHERE nip = @NipZamowienia;
                ";
                        using (MySqlCommand cmd2 = new MySqlCommand(sqlSprawdzNip, polaczenie))
                        {
                            cmd2.Parameters.AddWithValue("@NipZamowienia", nipZamowienia);
                            int ile = Convert.ToInt32(cmd2.ExecuteScalar());
                            if (ile > 0)
                                istnieje = true;
                        }
                    }
                }
            }
            return istnieje;
        }






    }


}

