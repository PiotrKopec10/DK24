using MySql.Data.MySqlClient;

namespace DK24.Klasy
{
    public class KontrahentClass
    {

        string PolaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;


        public class Kontrahent
        {
            public int company_details_id = 0;
            public int user_id = 0;
            public int address_id = 0;
            public string name = "";
            public string acronym = "";
            public string bank_iban_prefix = "";
            public string bank_name = "";
            public string bank_account_number = "";
            public string nip = "";
            public string regon = "";
            public string phone_prefix = "";
            public string phone_number = "";
            public string email = "";
            public string url = "";
            public int discount_percentage = 0;
            public int is_archived = 0;
            public DateTime created_at;
            public DateTime modified_at;
            public string company_description = "";



        }


        public void DodajKontrahenta(Kontrahent DodawanyKontrahent)
        {

            MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB);


            try
            {
                polaczenie.Open();

                string DodajKontrahenta = @"INSERT INTO `serwer197774_drukarnia`.`company_details`
                         (`user_id`, `address_id`, `name`, `acronym`, `bank_iban_prefix`, `bank_name`, `bank_account_number`, 
                          `nip`, `regon`, `phone_prefix`, `phone_number`, `email`, `discount_percentage`, `is_archived`, `created_at`, `modified_at`, 
                          `company_description`)
                         VALUES (@user_id, @address_id, @name, @acronym, @bank_iban_prefix, @bank_name, @bank_account_number, 
                                 @nip, @regon, @phone_prefix, @phone_number, @email, @discount_percentage, @is_archived, current_timestamp(), 
                                 '0000-00-00 00:00:00', @company_description);";



                using (MySqlCommand sqlDodajKontrahenta = new MySqlCommand(DodajKontrahenta, polaczenie))
                {


                    sqlDodajKontrahenta.Parameters.AddWithValue("@user_id", DodawanyKontrahent.user_id);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@name", DodawanyKontrahent.name);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@acronym", DodawanyKontrahent.acronym);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@address_id", DodawanyKontrahent.address_id);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@bank_iban_prefix", DodawanyKontrahent.bank_iban_prefix);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@bank_name", DodawanyKontrahent.bank_name);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@bank_account_number", DodawanyKontrahent.bank_account_number);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@nip", DodawanyKontrahent.nip);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@regon", DodawanyKontrahent.regon);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@phone_prefix", DodawanyKontrahent.phone_prefix);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@phone_number", DodawanyKontrahent.phone_number);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@email", DodawanyKontrahent.email);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@discount_percentage", DodawanyKontrahent.discount_percentage);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@is_archived", DodawanyKontrahent.is_archived);
                    sqlDodajKontrahenta.Parameters.AddWithValue("@company_description", DodawanyKontrahent.company_description);







                    sqlDodajKontrahenta.ExecuteNonQuery();




                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd Dodawania Kontrahenta: " + ex.Message, "Błąd");

            }

            polaczenie.Close();

        }



        public Kontrahent PobierzKontrahentaWgId(int idPobranegoKontrahenta)
        {

            Kontrahent pobranyKontrahent = new Kontrahent();
            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);

            try
            {
                polaczenie.Open();

                string query = "SELECT * FROM serwer197774_drukarnia.company_details WHERE company_details_id = @idPobranegoKontrahenta;";
                MySqlCommand PobierzKontrahenta = new MySqlCommand(query, polaczenie);
                PobierzKontrahenta.Parameters.AddWithValue("@idPobranegoKontrahenta", idPobranegoKontrahenta);

                MySqlDataReader odczytKontrahentaWgId = PobierzKontrahenta.ExecuteReader();
                if (odczytKontrahentaWgId.Read())
                {
                    if (odczytKontrahentaWgId.HasRows)
                    {
                        pobranyKontrahent.company_details_id = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("company_details_id")) ? odczytKontrahentaWgId.GetInt32("company_details_id") : 0;
                        pobranyKontrahent.user_id = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("user_id")) ? odczytKontrahentaWgId.GetInt32("user_id") : 0;
                        pobranyKontrahent.address_id = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("address_id")) ? odczytKontrahentaWgId.GetInt32("address_id") : 0;
                        pobranyKontrahent.name = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("name")) ? odczytKontrahentaWgId.GetString("name") : string.Empty;
                        pobranyKontrahent.acronym = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("acronym")) ? odczytKontrahentaWgId.GetString("acronym") : string.Empty;
                        pobranyKontrahent.bank_iban_prefix = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("bank_iban_prefix")) ? odczytKontrahentaWgId.GetString("bank_iban_prefix") : string.Empty;
                        pobranyKontrahent.bank_name = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("bank_name")) ? odczytKontrahentaWgId.GetString("bank_name") : string.Empty;
                        pobranyKontrahent.bank_account_number = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("bank_account_number")) ? odczytKontrahentaWgId.GetString("bank_account_number") : string.Empty;
                        pobranyKontrahent.nip = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("nip")) ? odczytKontrahentaWgId.GetString("nip") : string.Empty;
                        pobranyKontrahent.regon = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("regon")) ? odczytKontrahentaWgId.GetString("regon") : string.Empty;
                        pobranyKontrahent.phone_prefix = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("phone_prefix")) ? odczytKontrahentaWgId.GetString("phone_prefix") : string.Empty;
                        pobranyKontrahent.phone_number = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("phone_number")) ? odczytKontrahentaWgId.GetString("phone_number") : string.Empty;
                        pobranyKontrahent.email = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("email")) ? odczytKontrahentaWgId.GetString("email") : string.Empty;
                        pobranyKontrahent.url = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("url")) ? odczytKontrahentaWgId.GetString("url") : string.Empty;
                        pobranyKontrahent.discount_percentage = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("discount_percentage")) ? odczytKontrahentaWgId.GetInt32("discount_percentage") : 0;
                        pobranyKontrahent.is_archived = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("is_archived")) ? odczytKontrahentaWgId.GetInt32("is_archived") : 0;
                        pobranyKontrahent.created_at = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("created_at")) ? odczytKontrahentaWgId.GetDateTime("created_at") : DateTime.MinValue;
                        pobranyKontrahent.modified_at = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("modified_at")) ? odczytKontrahentaWgId.GetDateTime("modified_at") : DateTime.MinValue;
                        pobranyKontrahent.company_description = !odczytKontrahentaWgId.IsDBNull(odczytKontrahentaWgId.GetOrdinal("company_description")) ? odczytKontrahentaWgId.GetString("company_description") : string.Empty;
                    }
                }

                odczytKontrahentaWgId.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Błąd Pobierania Kontrahenta!!! " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }

            return pobranyKontrahent;
        }


    }

}
