using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DK24.Klasy.KontrahentClass;
using static DK24.Klasy.ZamowieniaClass.Orders;

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

            public enum StatusEnum
            {
                in_progress,
                completed,
                canceled
            }

            public enum ShippingMethodEnum
            {
                self_pickup,
                dhl,
                inpost
            }
        }



        public Orders WyswietlZamowienia()
        {
            Orders pobraneZamowienia = new Orders();
            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);

            try
            {
                polaczenie.Open();
                string query = "SELECT * FROM serwer197774_drukarnia.orders";
                MySqlCommand PobierzZamowienia = new MySqlCommand(query, polaczenie);
                MySqlDataReader odczytZamowien = PobierzZamowienia.ExecuteReader();

                if (odczytZamowien.Read())
                {
                    if (odczytZamowien.HasRows)
                    {
                        pobraneZamowienia.order_id = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("order_id")) ? odczytZamowien.GetInt32("order_id") : 0;
                        pobraneZamowienia.user_id = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("user_id")) ? odczytZamowien.GetInt32("user_id") : 0;
                        pobraneZamowienia.delivery_address_id = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("delivery_address_id")) ? odczytZamowien.GetInt32("delivery_address_id") : 0;
                        pobraneZamowienia.total_price = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("total_price")) ? odczytZamowien.GetDecimal("total_price") : 0;

                        string statusString = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("status")) ? odczytZamowien.GetString("status") : "in_progress";
                        pobraneZamowienia.status = Enum.TryParse(statusString, true, out Orders.StatusEnum statusEnum) ? statusEnum : Orders.StatusEnum.in_progress;

                        pobraneZamowienia.created_at = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("created_at")) ? odczytZamowien.GetDateTime("created_at") : DateTime.MinValue;
                        pobraneZamowienia.modified_at = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("modified_at")) ? odczytZamowien.GetDateTime("modified_at") : DateTime.MinValue;

                     
                        string shippingMethodString = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("shipping_method")) ? odczytZamowien.GetString("shipping_method") : "self_pickup";
                        pobraneZamowienia.shipping_method = Enum.TryParse(shippingMethodString, true, out Orders.ShippingMethodEnum shippingMethodEnum) ? shippingMethodEnum : Orders.ShippingMethodEnum.self_pickup;

                        pobraneZamowienia.shipping_date = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("shipping_date"))? DateOnly.FromDateTime(odczytZamowien.GetDateTime("shipping_date")): DateOnly.MinValue;

                    }
                }

                odczytZamowien.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Błąd Pobierania Zamówienia!!! " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }

            return pobraneZamowienia;
        }




    }
}
