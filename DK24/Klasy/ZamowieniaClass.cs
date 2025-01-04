using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using static DK24.Klasy.KontrahentClass;

namespace DK24.Klasy
{
    internal class ZamowieniaClass
    {
        string PolaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;

        public class Orders
        {
            public int order_id = 0;
            public int user_id = 0;
            public int delivery_address_id = 0;
            public decimal total_price = 0;
            public StatusEnum status { get; set; }
            public DateTime created_at;
            public DateTime modified_at;
            public ShippingMethodEnum shipping_method { get; set; }
            public DateOnly shipping_date;

            public bool is_invoice = false;
            public enum StatusEnum
            {
                created,
                in_progress,
                completed,
                invoice_ready,
                canceled
            }

            public enum ShippingMethodEnum
            {
                self_pickup,
                dhl,
                inpost
            }
        }

        //NARAZIE NIE UZYWANE


        //public Orders WyswietlZamowienia()
        //{
        //    Orders pobraneZamowienia = new Orders();
        //    MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);

        //    try
        //    {
        //        polaczenie.Open();
        //        string query = "SELECT * FROM serwer197774_drukarnia.orders";
        //        MySqlCommand PobierzZamowienia = new MySqlCommand(query, polaczenie);
        //        MySqlDataReader odczytZamowien = PobierzZamowienia.ExecuteReader();

        //        if (odczytZamowien.Read())
        //        {
        //            if (odczytZamowien.HasRows)
        //            {
        //                pobraneZamowienia.order_id = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("order_id")) ? odczytZamowien.GetInt32("order_id") : 0;
        //                pobraneZamowienia.user_id = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("user_id")) ? odczytZamowien.GetInt32("user_id") : 0;
        //                pobraneZamowienia.delivery_address_id = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("delivery_address_id")) ? odczytZamowien.GetInt32("delivery_address_id") : 0;
        //                pobraneZamowienia.total_price = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("total_price")) ? odczytZamowien.GetDecimal("total_price") : 0;

        //                string statusString = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("status")) ? odczytZamowien.GetString("status") : "in_progress";
        //                pobraneZamowienia.status = Enum.TryParse(statusString, true, out Orders.StatusEnum statusEnum) ? statusEnum : Orders.StatusEnum.in_progress;

        //                pobraneZamowienia.created_at = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("created_at")) ? odczytZamowien.GetDateTime("created_at") : DateTime.MinValue;
        //                pobraneZamowienia.modified_at = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("modified_at")) ? odczytZamowien.GetDateTime("modified_at") : DateTime.MinValue;


        //                string shippingMethodString = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("shipping_method")) ? odczytZamowien.GetString("shipping_method") : "self_pickup";
        //                pobraneZamowienia.shipping_method = Enum.TryParse(shippingMethodString, true, out Orders.ShippingMethodEnum shippingMethodEnum) ? shippingMethodEnum : Orders.ShippingMethodEnum.self_pickup;

        //                pobraneZamowienia.shipping_date = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("shipping_date")) ? DateOnly.FromDateTime(odczytZamowien.GetDateTime("shipping_date")) : DateOnly.MinValue;

        //            }
        //        }

        //        odczytZamowien.Close();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Błąd Pobierania Zamówienia!!! " + ex.Message, "Błąd");
        //    }
        //    finally
        //    {
        //        polaczenie.Close();
        //    }

        //    return pobraneZamowienia;
        //}



        public void WyswietlSzczegolyZamowienia(int orderId, DataGridView dataGridView)
        {
            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string zapytanie = @"
                SELECT 
                    i.name AS Produkt,
                    GROUP_CONCAT(CONCAT(og.title, ': ', op.name) ORDER BY og.option_group_id SEPARATOR ' | ') AS Opcje,
                    i.quantity AS Ilość
                FROM 
                    serwer197774_drukarnia.items AS i
                LEFT JOIN 
                    serwer197774_drukarnia.item_options AS io ON i.item_id = io.item_id
                LEFT JOIN 
                    serwer197774_drukarnia.options AS op ON io.option_id = op.option_id
                LEFT JOIN 
                    serwer197774_drukarnia.option_groups AS og ON op.option_group_id = og.option_group_id
                WHERE 
                    i.order_id = @orderId
                GROUP BY 
                    i.item_id
                ORDER BY 
                    i.item_id;
            ";

                    using (MySqlCommand sqlCommand = new MySqlCommand(zapytanie, polaczenie))
                    {
                        sqlCommand.Parameters.AddWithValue("@orderId", orderId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);


                            dataGridView.DataSource = dataTable;
                        }
                        dataGridView.Columns["Produkt"].DisplayIndex = 0;
                        dataGridView.Columns["Opcje"].DisplayIndex = 1;
                        dataGridView.Columns["Ilość"].DisplayIndex = 2;


                        dataGridView.Columns["Produkt"].Width = 200;
                        dataGridView.Columns["Opcje"].Width = 300;
                        dataGridView.Columns["Ilość"].Width = 100;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas wyświetlania zamówienia: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }
        }





        public void EdytujStatusZamowienia(int orderId, string statusZamowieniaDoBazy, string statusZamowieniaDoWyswietlenia, string SciezkaZapisaniaEtykiety)
        {

            MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB);


            try
            {
                polaczenie.Open();



                using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                {

                    string ZmienStatusZamowienia = @"
                    UPDATE orders 
                    SET status = @Status, modified_at = NOW() 
                    WHERE order_id = @OrderId";

                    using (MySqlCommand sqlZmienStatusZamowienia = new MySqlCommand(ZmienStatusZamowienia, polaczenie, transakcja))
                    {
                        sqlZmienStatusZamowienia.Parameters.AddWithValue("@Status", statusZamowieniaDoBazy);
                        sqlZmienStatusZamowienia.Parameters.AddWithValue("@OrderId", orderId);

                        sqlZmienStatusZamowienia.ExecuteNonQuery();
                    }


                    transakcja.Commit();

                    if(SciezkaZapisaniaEtykiety == "")
                    {
                        MessageBox.Show("Pomyślnie Zmieniono Status Zamówienia na: \n " + "[ " + statusZamowieniaDoWyswietlenia + " ]", "Poprawnie Zmieniono!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }else
                    {
                        MessageBox.Show("Zmieniono Status Zamówienia na: \n " + "[ " + statusZamowieniaDoWyswietlenia + " ]\n\n\n Ścieżka w której została zapisana etykieta:\n "+SciezkaZapisaniaEtykiety, "Poprawnie Zmieniono!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd zmiany statusu zamówienia " + ex.Message, "Błąd");

            }

            polaczenie.Close();




        }



        public bool PobierzCzyFakturaPoIdZamowienia(int idZamowienia)
        {
            bool CzyFaktura = false;

            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                  
                    string zapytanie = @"
                SELECT is_invoice
                FROM orders
                WHERE order_id = @orderId
                LIMIT 1
            ";

                    using (MySqlCommand sqlCommand = new MySqlCommand(zapytanie, polaczenie))
                    {
                        sqlCommand.Parameters.AddWithValue("@orderId", idZamowienia);
                        object wynik = sqlCommand.ExecuteScalar();
                        if (wynik != null && wynik != DBNull.Value)
                        {
                            int invoiceValue = Convert.ToInt32(wynik);
                            CzyFaktura = (invoiceValue == 1);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych o fakturze dla zamówienia: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }

            return CzyFaktura;
        }




    }
}
