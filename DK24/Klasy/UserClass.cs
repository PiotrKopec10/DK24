using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace DK24.Klasy
{
    internal class UserClass
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
            public enum role { user, admin, worker };
            public DateTime created_at;
            public DateTime modified_at;


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



    }
}
