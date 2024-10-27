using MySql.Data.MySqlClient;

namespace DK24.Klasy
{
    internal class AddressClass
    {
        string PolaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;
        public class Address
        {
            public int address_id = 0;
            public string country = "";
            public string voivodeship = "";
            public string powiat = "";
            public string gmina = "";
            public string city = "";
            public string postal_code = "";
            public string street = "";
            public string house_number = "";
            public string apartment_number = "";


        }

        public void DodajAdres(Address DodawanyAdres)
        {

            MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB);


            try
            {
                polaczenie.Open();


                using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                {


                    string DodajAdres = @"INSERT INTO `serwer197774_drukarnia`.`addresses`
                                  (`address_id`, `country`, `voivodeship`, `powiat`, `gmina`, `city`, `postal_code`, `street`, `house_number`, `apartment_number`)
                                  VALUES (@address_id, @country, @voivodeship, @powiat, @gmina, @city, @postal_code, @street, @house_number, @apartment_number);";

                    using (MySqlCommand sqlDodajAdres = new MySqlCommand(DodajAdres, polaczenie))
                    {

                        sqlDodajAdres.Parameters.AddWithValue("@address_id", DodawanyAdres.address_id);
                        sqlDodajAdres.Parameters.AddWithValue("@country", DodawanyAdres.country);
                        sqlDodajAdres.Parameters.AddWithValue("@voivodeship", DodawanyAdres.voivodeship);
                        sqlDodajAdres.Parameters.AddWithValue("@powiat", DodawanyAdres.powiat);
                        sqlDodajAdres.Parameters.AddWithValue("@gmina", DodawanyAdres.gmina);
                        sqlDodajAdres.Parameters.AddWithValue("@city", DodawanyAdres.city);
                        sqlDodajAdres.Parameters.AddWithValue("@postal_code", DodawanyAdres.postal_code);
                        sqlDodajAdres.Parameters.AddWithValue("@street", DodawanyAdres.street);
                        sqlDodajAdres.Parameters.AddWithValue("@house_number", DodawanyAdres.house_number);
                        sqlDodajAdres.Parameters.AddWithValue("@apartment_number", DodawanyAdres.apartment_number);


                        sqlDodajAdres.ExecuteNonQuery();


                    }

                    transakcja.Commit();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd Dodawania Adresu: " + ex.Message, "Błąd");

            }

            polaczenie.Close();



        }



        public int PobierzIdAdresu(Address PobieranyAdres)
        {
            int idAdresu = -1;

            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();


                    string PobierzAdresId = @"SELECT `address_id` 
                                      FROM `serwer197774_drukarnia`.`addresses`
                                      WHERE `country` = @country
                                      AND `voivodeship` = @voivodeship
                                      AND `powiat` = @powiat
                                      AND `gmina` = @gmina
                                      AND `city` = @city
                                      AND `postal_code` = @postal_code
                                      AND `street` = @street
                                      AND `house_number` = @house_number
                                      AND `apartment_number` = @apartment_number;";

                    using (MySqlCommand sqlPobierzAdresId = new MySqlCommand(PobierzAdresId, polaczenie))
                    {

                        sqlPobierzAdresId.Parameters.AddWithValue("@country", PobieranyAdres.country);
                        sqlPobierzAdresId.Parameters.AddWithValue("@voivodeship", PobieranyAdres.voivodeship);
                        sqlPobierzAdresId.Parameters.AddWithValue("@powiat", PobieranyAdres.powiat);
                        sqlPobierzAdresId.Parameters.AddWithValue("@gmina", PobieranyAdres.gmina);
                        sqlPobierzAdresId.Parameters.AddWithValue("@city", PobieranyAdres.city);
                        sqlPobierzAdresId.Parameters.AddWithValue("@postal_code", PobieranyAdres.postal_code);
                        sqlPobierzAdresId.Parameters.AddWithValue("@street", PobieranyAdres.street);
                        sqlPobierzAdresId.Parameters.AddWithValue("@house_number", PobieranyAdres.house_number);
                        sqlPobierzAdresId.Parameters.AddWithValue("@apartment_number", PobieranyAdres.apartment_number);


                        using (MySqlDataReader reader = sqlPobierzAdresId.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idAdresu = reader.GetInt32("address_id");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Błąd Pobierania Adresu: " + ex.Message, "Błąd");

                }

                polaczenie.Close();

                return idAdresu;

            }
        }



        public Address PobierzAdresWgId(int idPobranegoAdresu)
        {
            Address pobranyAdres = new Address();

            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);

            try
            {
                polaczenie.Open();



                string query = "SELECT * FROM serwer197774_drukarnia.addresses WHERE address_id = @idPobranegoAdresu;";
                MySqlCommand PobierzAdres = new MySqlCommand(query, polaczenie);
                PobierzAdres.Parameters.AddWithValue("@idPobranegoAdresu", idPobranegoAdresu);

                MySqlDataReader odczytAdresuWgId = PobierzAdres.ExecuteReader();

                if (odczytAdresuWgId.Read())
                {
                    if (odczytAdresuWgId.HasRows)
                    {
                        pobranyAdres.address_id = !odczytAdresuWgId.IsDBNull(odczytAdresuWgId.GetOrdinal("address_id")) ? odczytAdresuWgId.GetInt32("address_id") : 0;
                        pobranyAdres.street = !odczytAdresuWgId.IsDBNull(odczytAdresuWgId.GetOrdinal("street")) ? odczytAdresuWgId.GetString("street") : string.Empty;
                        pobranyAdres.house_number = !odczytAdresuWgId.IsDBNull(odczytAdresuWgId.GetOrdinal("house_number")) ? odczytAdresuWgId.GetString("house_number") : string.Empty;
                        pobranyAdres.apartment_number = !odczytAdresuWgId.IsDBNull(odczytAdresuWgId.GetOrdinal("apartment_number")) ? odczytAdresuWgId.GetString("apartment_number") : string.Empty;
                        pobranyAdres.postal_code = !odczytAdresuWgId.IsDBNull(odczytAdresuWgId.GetOrdinal("postal_code")) ? odczytAdresuWgId.GetString("postal_code") : string.Empty;
                        pobranyAdres.city = !odczytAdresuWgId.IsDBNull(odczytAdresuWgId.GetOrdinal("city")) ? odczytAdresuWgId.GetString("city") : string.Empty;
                        pobranyAdres.voivodeship = !odczytAdresuWgId.IsDBNull(odczytAdresuWgId.GetOrdinal("voivodeship")) ? odczytAdresuWgId.GetString("voivodeship") : string.Empty;
                        pobranyAdres.powiat = !odczytAdresuWgId.IsDBNull(odczytAdresuWgId.GetOrdinal("powiat")) ? odczytAdresuWgId.GetString("powiat") : string.Empty;
                        pobranyAdres.gmina = !odczytAdresuWgId.IsDBNull(odczytAdresuWgId.GetOrdinal("gmina")) ? odczytAdresuWgId.GetString("gmina") : string.Empty;
                        pobranyAdres.country = !odczytAdresuWgId.IsDBNull(odczytAdresuWgId.GetOrdinal("country")) ? odczytAdresuWgId.GetString("country") : string.Empty;
                    }
                }

                odczytAdresuWgId.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Błąd Pobierania Adresu!!! " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }

            return pobranyAdres;
        }






        public void EdytujAdres(Address EdytowanyAdres)
        {
            MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB);

            try
            {
                polaczenie.Open();

                using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                {
                    string EdytujAdres = @"UPDATE `serwer197774_drukarnia`.`addresses`
                                   SET `country` = @country, 
                                       `voivodeship` = @voivodeship, 
                                       `powiat` = @powiat, 
                                       `gmina` = @gmina, 
                                       `city` = @city, 
                                       `postal_code` = @postal_code, 
                                       `street` = @street, 
                                       `house_number` = @house_number, 
                                       `apartment_number` = @apartment_number
                                   WHERE `address_id` = @address_id;";

                    using (MySqlCommand sqlEdytujAdres = new MySqlCommand(EdytujAdres, polaczenie, transakcja))
                    {
                        sqlEdytujAdres.Parameters.AddWithValue("@address_id", EdytowanyAdres.address_id);
                        sqlEdytujAdres.Parameters.AddWithValue("@country", EdytowanyAdres.country);
                        sqlEdytujAdres.Parameters.AddWithValue("@voivodeship", EdytowanyAdres.voivodeship);
                        sqlEdytujAdres.Parameters.AddWithValue("@powiat", EdytowanyAdres.powiat);
                        sqlEdytujAdres.Parameters.AddWithValue("@gmina", EdytowanyAdres.gmina);
                        sqlEdytujAdres.Parameters.AddWithValue("@city", EdytowanyAdres.city);
                        sqlEdytujAdres.Parameters.AddWithValue("@postal_code", EdytowanyAdres.postal_code);
                        sqlEdytujAdres.Parameters.AddWithValue("@street", EdytowanyAdres.street);
                        sqlEdytujAdres.Parameters.AddWithValue("@house_number", EdytowanyAdres.house_number);
                        sqlEdytujAdres.Parameters.AddWithValue("@apartment_number", EdytowanyAdres.apartment_number);

                        sqlEdytujAdres.ExecuteNonQuery();
                    }

                    transakcja.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd Edytowania Adresu: " + ex.Message, "Błąd");
            }
            


                polaczenie.Close();
            
        }




    }
}
