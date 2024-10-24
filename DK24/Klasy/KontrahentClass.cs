using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DK24.Klasy
{
    internal class KontrahentClass
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
            public decimal discount_percentage = 0;
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




    }
}
