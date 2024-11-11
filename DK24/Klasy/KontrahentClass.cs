using MySql.Data.MySqlClient;
using static DK24.Klasy.AddressClass;

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



                using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                {

                    string DodajKontrahenta = @"INSERT INTO `serwer197774_drukarnia`.`company_details`
                         (`user_id`, `address_id`, `name`, `acronym`, `bank_iban_prefix`, `bank_name`, `bank_account_number`, 
                          `nip`, `regon`, `phone_prefix`, `phone_number`, `email`,`url` ,`discount_percentage`, `is_archived`, `created_at`, `modified_at`, 
                          `company_description`)
                         VALUES (@user_id, @address_id, @name, @acronym, @bank_iban_prefix, @bank_name, @bank_account_number, 
                                 @nip, @regon, @phone_prefix, @phone_number, @email, @url ,@discount_percentage, @is_archived, current_timestamp(), 
                                 current_timestamp(), @company_description);";



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
                        sqlDodajKontrahenta.Parameters.AddWithValue("@url",DodawanyKontrahent.url);
                        sqlDodajKontrahenta.Parameters.AddWithValue("@discount_percentage", DodawanyKontrahent.discount_percentage);
                        sqlDodajKontrahenta.Parameters.AddWithValue("@is_archived", DodawanyKontrahent.is_archived);
                        sqlDodajKontrahenta.Parameters.AddWithValue("@company_description", DodawanyKontrahent.company_description);

                        sqlDodajKontrahenta.ExecuteNonQuery();

                    }

                    transakcja.Commit();

                    MessageBox.Show("Pomyślnie dodano Kontrahenta!", "Poprawnie Dodano!", MessageBoxButtons.OK, MessageBoxIcon.Information);


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


        public void EdytujKontrahenta(Kontrahent EdytowanyKontrahent) 
        {

            MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB);


            try
            {
                polaczenie.Open();



                using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                {

                    string EdytujKontrahenta = @"UPDATE `serwer197774_drukarnia`.`company_details`
                             SET `user_id` = @user_id, 
                                 `address_id` = @address_id, 
                                 `name` = @name, 
                                 `acronym` = @acronym, 
                                 `bank_iban_prefix` = @bank_iban_prefix, 
                                 `bank_name` = @bank_name, 
                                 `bank_account_number` = @bank_account_number, 
                                 `nip` = @nip, 
                                 `regon` = @regon, 
                                 `phone_prefix` = @phone_prefix, 
                                 `phone_number` = @phone_number, 
                                 `email` = @email, 
                                 `url` = @url, 
                                 `discount_percentage` = @discount_percentage, 
                                 `is_archived` = @is_archived, 
                                 `modified_at` = current_timestamp(), 
                                 `company_description` = @company_description
                             WHERE `company_details_id` = @company_details_id;";



                    using (MySqlCommand sqlEdytujKontrahenta = new MySqlCommand(EdytujKontrahenta, polaczenie, transakcja))
                    {
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@user_id", EdytowanyKontrahent.user_id);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@name", EdytowanyKontrahent.name);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@acronym", EdytowanyKontrahent.acronym);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@address_id", EdytowanyKontrahent.address_id);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@bank_iban_prefix", EdytowanyKontrahent.bank_iban_prefix);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@bank_name", EdytowanyKontrahent.bank_name);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@bank_account_number", EdytowanyKontrahent.bank_account_number);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@nip", EdytowanyKontrahent.nip);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@regon", EdytowanyKontrahent.regon);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@phone_prefix", EdytowanyKontrahent.phone_prefix);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@phone_number", EdytowanyKontrahent.phone_number);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@email", EdytowanyKontrahent.email);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@url", EdytowanyKontrahent.url);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@discount_percentage", EdytowanyKontrahent.discount_percentage);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@is_archived", EdytowanyKontrahent.is_archived);
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@company_description", EdytowanyKontrahent.company_description);

                      
                        sqlEdytujKontrahenta.Parameters.AddWithValue("@company_details_id", EdytowanyKontrahent.company_details_id);

                        sqlEdytujKontrahenta.ExecuteNonQuery();
                    }


                    transakcja.Commit();


                    MessageBox.Show("Pomyślnie Edytowano Kontrahenta!", "Poprawnie Edytowano!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd Dodawania Kontrahenta: " + ex.Message, "Błąd");

            }

            polaczenie.Close();




        }


        public void UsunKontrahenta(int IdUsuwanegoKontrahenta)
        {
            MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB);


            try
            {
                polaczenie.Open();

                using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                {
                    string UsunKontrahenta = "DELETE FROM `serwer197774_drukarnia`.`company_details` WHERE `company_details_id` = @IdUsuwanegoKontrahenta;";

                    using (MySqlCommand sqlUsunKontrahenta = new MySqlCommand(UsunKontrahenta, polaczenie, transakcja))
                    {
                        sqlUsunKontrahenta.Parameters.AddWithValue("@IdUsuwanegoKontrahenta", IdUsuwanegoKontrahenta);


                        sqlUsunKontrahenta.ExecuteNonQuery();
                    }

                 
                    transakcja.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd Usuwania Kontrahenta: " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }
        }




        public int PobierzIdUseraPoEmail(string email )
        {
            int idUsera = -1;

            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();


                    string PobierzIdUsera = @"SELECT user_id FROM serwer197774_drukarnia.users WHERE LOWER(email) = LOWER(@adresemail)";

                    using (MySqlCommand sqlPobierzIdUsera = new MySqlCommand(PobierzIdUsera, polaczenie))
                    {

                        sqlPobierzIdUsera.Parameters.AddWithValue("@adresemail",email.ToLower());



                        using (MySqlDataReader reader = sqlPobierzIdUsera.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idUsera = reader.GetInt32("user_id");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Błąd Pobierania Użytkownika: " + ex.Message, "Błąd");

                }

                polaczenie.Close();

                return idUsera;

            }
        }



        public bool CzyUserJestPrzypisanyDoKontrahenta(int userId)
        {
            bool czyPrzypisany = false;

            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string zapytanie = @"SELECT COUNT(*) FROM serwer197774_drukarnia.company_details WHERE user_id = @userId";

                    using (MySqlCommand sqlZapytanie = new MySqlCommand(zapytanie, polaczenie))
                    {
                        sqlZapytanie.Parameters.AddWithValue("@userId", userId);

                        int liczbaRekordow = Convert.ToInt32(sqlZapytanie.ExecuteScalar());

                        if (liczbaRekordow > 0)
                        {
                            czyPrzypisany = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas sprawdzania przypisania użytkownika: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }

            return czyPrzypisany;
        }



    }

}
