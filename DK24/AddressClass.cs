using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DK24
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

                string DodajAdres = @"INSERT INTO `serwer197774_drukarnia`.`addresses`
                                  (`address_id`, `country`, `voivodeship`, `powiat`, `gmina`, `city`, `postal_code`, `street`, `house_number`, `apartment_number`)
                                  VALUES (@address_id, @country, @voivodeship, @powiat, @gmina, @city, @postal_code, @street, @house_number, @apartment_number);";

                using (MySqlCommand sqlDodajAdres = new MySqlCommand(DodajAdres,polaczenie)) 
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

            }
            catch (Exception ex) 
            {

                MessageBox.Show("Błąd Dodawania Adresu: " + ex.Message, "Błąd");

            }

            polaczenie.Close();

            

        }



        public int PobierzAdresId(Address PobieranyAdres)
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


    }
}
