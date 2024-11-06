using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DK24.Klasy.AddressClass;
using static DK24.Klasy.Uslugi_TowarClass;

namespace DK24.Klasy
{
    internal class Uslugi_TowarClass
    {
        string PolaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;
      





        public class Produkt 
        {
            public int product_id = 0;
            public string sku = "";
            public string name = "";
            public string image_url = "";
            public string description = "";
            public decimal base_price = 0;
            public decimal weight = 0;
            public bool is_archived;
            public DateTime created_at;
            public DateTime modified_at;
        
        
        
        }


        public class Option_groups
        {
            public int option_group_id = 0;
            public int product_id = 0;
            public string name = "";
            public string title = "";
            public enum type { select, number };
            public bool is_mandatory;


        }

        public class Options
        {
            public int option_id = 0;
            public int option_group_id = 0;
            public string name = "";
            public decimal price_increment = 0;
        }


        public List<Option_groups> PobierzGrupyOpcji(int productId)
        {
            List<Option_groups> grupyOpcji = new List<Option_groups>();

            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string query = @"SELECT option_group_id, product_id, name, title, type, is_mandatory
                             FROM option_groups
                             WHERE product_id = @productId";

                    using (MySqlCommand sqlPobierzGrupyOpcji = new MySqlCommand(query, polaczenie))
                    {
                        sqlPobierzGrupyOpcji.Parameters.AddWithValue("@productId", productId);

                        using (MySqlDataReader reader = sqlPobierzGrupyOpcji.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Option_groups grupaOpcji = new Option_groups
                                {
                                    option_group_id = reader.GetInt32("option_group_id"),
                                    product_id = reader.GetInt32("product_id"),
                                    name = reader.GetString("name"),
                                    title = reader.GetString("title"),
                                    //type = reader.GetString("type"),
                                    is_mandatory = reader.GetBoolean("is_mandatory")
                                };

                                grupyOpcji.Add(grupaOpcji);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania grup opcji: " + ex.Message);
                }
            }

            return grupyOpcji;
        }


        public List<Options> PobierzOpcje(int optionGroupId)
        {
            List<Options> opcje = new List<Options>();

            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string query = @"SELECT option_id, option_group_id, name, price_increment
                             FROM options
                             WHERE option_group_id = @optionGroupId";

                    using (MySqlCommand sqlPobierzOpcje = new MySqlCommand(query, polaczenie))
                    {
                        sqlPobierzOpcje.Parameters.AddWithValue("@optionGroupId", optionGroupId);

                        using (MySqlDataReader reader = sqlPobierzOpcje.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Options opcja = new Options
                                {
                                    option_id = reader.GetInt32("option_id"),
                                    option_group_id = reader.GetInt32("option_group_id"),
                                    name = reader.GetString("name"),
                                    price_increment = reader.GetDecimal("price_increment")
                                };

                                opcje.Add(opcja);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania opcji: " + ex.Message);
                }
            }

            return opcje;
        }


    }
}
