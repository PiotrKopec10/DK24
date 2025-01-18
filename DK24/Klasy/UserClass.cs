using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using static DK24.Klasy.AddressClass;

namespace DK24.Klasy
{
    public class UserClass
    {


        string Polaczenie = GlobalClass.GlobalnaZmienna.DBPolaczenie;




        public class User
        {

            public int user_id = 0;
            public int adress_id = 0;
            public string email = "";
            public string worker_login = "";
            public string password_hash = "";
            public string first_name = "";
            public string last_name = "";
            public string phone_number = "";
            public RoleEnum role;
            public DateTime created_at;
            public DateTime modified_at;


            public enum RoleEnum
            {
                user,
                admin,
                worker
            }
        }

        public bool PobierzHasloDlaUsera(User AktualnyUser)
        {
            bool CzyHasloPrawidlowe = false;




            MySqlConnection polaczenie = new MySqlConnection(Polaczenie);

            try
            {
                polaczenie.Open();

                string pobierzHaslo = "SELECT password_hash FROM users WHERE worker_login = @workerLogin";

                using (MySqlCommand sqlPobierzHaslo = new MySqlCommand(pobierzHaslo, polaczenie))
                {

                    sqlPobierzHaslo.Parameters.AddWithValue("@workerLogin", AktualnyUser.worker_login);

                    object rezultat = sqlPobierzHaslo.ExecuteScalar();


                    if (rezultat != null)
                    {
                        string pobraneHaslo = rezultat.ToString();



                        if (AktualnyUser.password_hash == pobraneHaslo)
                        {
                            CzyHasloPrawidlowe = true;
                        }


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd Połączenia do bazy danych!!!", "Błąd");
            }

            polaczenie.Close();




            return CzyHasloPrawidlowe;

        }

        public string ZahashujHaslo(string haslo)
        {
            SHA256 sha = SHA256.Create();

            // Convert inputa na tablicę bajtów i obliczanie hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(haslo));


            //Utwórz nowy StringBuilder aby zebrać bajty
            // utworzenie stringa
            StringBuilder sBuilder = new StringBuilder();


            // Iteracja każdego bajta z danych hashowanych
            // i format każdego z nich jako ciąg szesnastkowy

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public User PobierzUseraPoIdUsera(int userId)
        {
            User pobranyUser = new User();
            using (MySqlConnection polaczenie = new MySqlConnection(Polaczenie))
            {
                try
                {
                    polaczenie.Open();
                    string query = "SELECT * FROM users WHERE user_id = @userId";
                    using (MySqlCommand PobierzUsera = new MySqlCommand(query, polaczenie))
                    {
                        PobierzUsera.Parameters.AddWithValue("@userId", userId);
                        using (MySqlDataReader reader = PobierzUsera.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                pobranyUser.user_id = reader.GetInt32("user_id");
                                pobranyUser.worker_login = reader.GetString("worker_login");
                                pobranyUser.first_name = reader.GetString("first_name");
                                pobranyUser.last_name = reader.GetString("last_name");
                                pobranyUser.email = reader.GetString("email");
                                pobranyUser.phone_number = reader.GetString("phone_number");
                                pobranyUser.role = (User.RoleEnum)Enum.Parse(typeof(User.RoleEnum), reader.GetString("role"), true);
                                pobranyUser.password_hash = reader.GetString("password_hash");
                                pobranyUser.created_at = reader.GetDateTime("created_at");
                                pobranyUser.modified_at = reader.GetDateTime("modified_at");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania użytkownika: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }
            return pobranyUser;
        }


        public void DodajPracownika(UserClass.User nowyPracownik)
        {
            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);

            try
            {
                polaczenie.Open();

                using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                {
                    string query = @"INSERT INTO `serwer197774_drukarnia`.`users` 
                             (`address_id`,`worker_login`, `first_name`, `last_name`, `phone_number`, `email`, `password_hash`, `role`, `created_at`, `modified_at`) 
                             VALUES 
                             (@address_id,@worker_login, @first_name, @last_name, @phone_number, @email, @password_hash, @role, NOW(), NOW())";

                    using (MySqlCommand sqlDodajPracownika = new MySqlCommand(query, polaczenie, transakcja))
                    {
                        sqlDodajPracownika.Parameters.AddWithValue("@address_id", DBNull.Value);
                      
                        sqlDodajPracownika.Parameters.AddWithValue("@worker_login", nowyPracownik.worker_login);
                        sqlDodajPracownika.Parameters.AddWithValue("@first_name", nowyPracownik.first_name);
                        sqlDodajPracownika.Parameters.AddWithValue("@last_name", nowyPracownik.last_name);
                        sqlDodajPracownika.Parameters.AddWithValue("@phone_number", nowyPracownik.phone_number);
                        sqlDodajPracownika.Parameters.AddWithValue("@email", nowyPracownik.email);
                        sqlDodajPracownika.Parameters.AddWithValue("@password_hash", nowyPracownik.password_hash);
                        sqlDodajPracownika.Parameters.AddWithValue("@role", nowyPracownik.role.ToString());

                        sqlDodajPracownika.ExecuteNonQuery();
                    }

                    transakcja.Commit();
                    MessageBox.Show("Pomyślnie dodano pracownika!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania pracownika: " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }
        }



        public void EdytujPracownika(User EdytowanyPracownik)
        {
            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);

            try
            {
                polaczenie.Open();

                using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                {
                    string EdytujPracownikaQuery = @"UPDATE `serwer197774_drukarnia`.`users`
                                             SET `first_name` = @first_name, 
                                                 `last_name` = @last_name, 
                                                 `phone_number` = @phone_number, 
                                                 `email` = @email, 
                                                 `role` = @role,
                                                 `worker_login` = @worker_login,                     
                                                 `modified_at` = @modified_at
                                             WHERE `user_id` = @user_id;";

                    using (MySqlCommand sqlEdytujPracownika = new MySqlCommand(EdytujPracownikaQuery, polaczenie, transakcja))
                    {
                        sqlEdytujPracownika.Parameters.AddWithValue("@user_id", EdytowanyPracownik.user_id);
                        sqlEdytujPracownika.Parameters.AddWithValue("@first_name", EdytowanyPracownik.first_name);
                        sqlEdytujPracownika.Parameters.AddWithValue("@last_name", EdytowanyPracownik.last_name);
                        sqlEdytujPracownika.Parameters.AddWithValue("@phone_number", EdytowanyPracownik.phone_number);
                        sqlEdytujPracownika.Parameters.AddWithValue("@email", EdytowanyPracownik.email);
                        sqlEdytujPracownika.Parameters.AddWithValue("@role", EdytowanyPracownik.role.ToString());
                        sqlEdytujPracownika.Parameters.AddWithValue("@worker_login", EdytowanyPracownik.worker_login);
                        sqlEdytujPracownika.Parameters.AddWithValue("@modified_at", EdytowanyPracownik.modified_at);

                        sqlEdytujPracownika.ExecuteNonQuery();
                    }

                    transakcja.Commit();
                    MessageBox.Show("Pomyślnie edytowano dane pracownika!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas edytowania pracownika: " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }
        }


        public void UsunUzytkownika(int IdUsuwanegoUzytkownika)
        {
            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);


            try
            {
                polaczenie.Open();

                using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                {
                    string UsunUzytkownika = "DELETE FROM `serwer197774_drukarnia`.`users` WHERE `user_id` = @IdUsuwanegoUzytkownika;";

                    using (MySqlCommand sqlUsunUzytkownika = new MySqlCommand(UsunUzytkownika, polaczenie, transakcja))
                    {
                        sqlUsunUzytkownika.Parameters.AddWithValue("@IdUsuwanegoUzytkownika", IdUsuwanegoUzytkownika);


                        sqlUsunUzytkownika.ExecuteNonQuery();
                    }


                    transakcja.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd Usuwania Uzytkownika: " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }
        }





        public bool SprawdzCzyAdmin(string LoginUsera)
        {
            bool CzyAdmin = false;
            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);

            try
            {
                polaczenie.Open();

                string pobierzInformacje = "SELECT COUNT(*) FROM users WHERE worker_login = @login AND role = 'admin'";

                using (MySqlCommand sqlPobierzInfo = new MySqlCommand(pobierzInformacje, polaczenie))
                {
                    sqlPobierzInfo.Parameters.AddWithValue("@login", LoginUsera);

                    int liczbaRekordow = Convert.ToInt32(sqlPobierzInfo.ExecuteScalar());

                    CzyAdmin = liczbaRekordow > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia do bazy danych: " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }

            return CzyAdmin;
        }





    }
}