using MySql.Data.MySqlClient;

namespace DK24.Klasy
{
    internal class FakturaClass
    {
        string PolaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;

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


    }


}

