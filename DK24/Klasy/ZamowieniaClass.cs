using MySql.Data.MySqlClient;
using System.Data;
using static DK24.Klasy.KontrahentClass;

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
                created,
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

        //NARAZIE NIE UZYWANE


        //public Orders WyswietlZamowienia()
        //{
        //    Orders pobraneZamowienia = new Orders();
        //    MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);

        //    try
        //    {
        //        polaczenie.Open();
        //        string query = "SELECT * FROM serwer197774_drukarnia.orders";
        //        MySqlCommand PobierzZamowienia = new MySqlCommand(query, polaczenie);
        //        MySqlDataReader odczytZamowien = PobierzZamowienia.ExecuteReader();

        //        if (odczytZamowien.Read())
        //        {
        //            if (odczytZamowien.HasRows)
        //            {
        //                pobraneZamowienia.order_id = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("order_id")) ? odczytZamowien.GetInt32("order_id") : 0;
        //                pobraneZamowienia.user_id = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("user_id")) ? odczytZamowien.GetInt32("user_id") : 0;
        //                pobraneZamowienia.delivery_address_id = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("delivery_address_id")) ? odczytZamowien.GetInt32("delivery_address_id") : 0;
        //                pobraneZamowienia.total_price = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("total_price")) ? odczytZamowien.GetDecimal("total_price") : 0;

        //                string statusString = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("status")) ? odczytZamowien.GetString("status") : "in_progress";
        //                pobraneZamowienia.status = Enum.TryParse(statusString, true, out Orders.StatusEnum statusEnum) ? statusEnum : Orders.StatusEnum.in_progress;

        //                pobraneZamowienia.created_at = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("created_at")) ? odczytZamowien.GetDateTime("created_at") : DateTime.MinValue;
        //                pobraneZamowienia.modified_at = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("modified_at")) ? odczytZamowien.GetDateTime("modified_at") : DateTime.MinValue;


        //                string shippingMethodString = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("shipping_method")) ? odczytZamowien.GetString("shipping_method") : "self_pickup";
        //                pobraneZamowienia.shipping_method = Enum.TryParse(shippingMethodString, true, out Orders.ShippingMethodEnum shippingMethodEnum) ? shippingMethodEnum : Orders.ShippingMethodEnum.self_pickup;

        //                pobraneZamowienia.shipping_date = !odczytZamowien.IsDBNull(odczytZamowien.GetOrdinal("shipping_date")) ? DateOnly.FromDateTime(odczytZamowien.GetDateTime("shipping_date")) : DateOnly.MinValue;

        //            }
        //        }

        //        odczytZamowien.Close();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Błąd Pobierania Zamówienia!!! " + ex.Message, "Błąd");
        //    }
        //    finally
        //    {
        //        polaczenie.Close();
        //    }

        //    return pobraneZamowienia;
        //}



        public void WyswietlSzczegolyZamowienia(int orderId, DataGridView dataGridView)
        {
            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string zapytanie = @"
                SELECT 
                    i.name AS item_name,
                    i.quantity,
                    i.price,
                    GROUP_CONCAT(CONCAT(og.title, ': ', op.name) ORDER BY og.option_group_id SEPARATOR ' | ') AS options,
                    o.total_price,
                    o.status,
                    o.created_at
                FROM 
                    serwer197774_drukarnia.items AS i
                JOIN 
                    serwer197774_drukarnia.orders AS o ON i.order_id = o.order_id
                LEFT JOIN 
                    serwer197774_drukarnia.item_options AS io ON i.item_id = io.item_id
                LEFT JOIN 
                    serwer197774_drukarnia.options AS op ON io.option_id = op.option_id
                LEFT JOIN 
                    serwer197774_drukarnia.option_groups AS og ON op.option_group_id = og.option_group_id
                WHERE 
                    o.order_id = @orderId
                GROUP BY 
                    i.item_id
                ORDER BY 
                    i.item_id;
            ";

                    using (MySqlCommand sqlCommand = new MySqlCommand(zapytanie, polaczenie))
                    {
                        sqlCommand.Parameters.AddWithValue("@orderId", orderId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;


                            dataGridView.Columns["item_name"].DisplayIndex = 0;
                            dataGridView.Columns["quantity"].DisplayIndex = 1;
                            dataGridView.Columns["price"].DisplayIndex = 2;
                            dataGridView.Columns["options"].DisplayIndex = 3;
                            dataGridView.Columns["total_price"].DisplayIndex = 4;
                            dataGridView.Columns["status"].DisplayIndex = 5;
                            dataGridView.Columns["created_at"].DisplayIndex = 6;

                            dataGridView.Columns["item_name"].HeaderText = "Produkt";
                            dataGridView.Columns["quantity"].HeaderText = "Ilość";
                            dataGridView.Columns["price"].HeaderText = "Cena jednostkowa";
                            dataGridView.Columns["options"].HeaderText = "Opcje";
                            dataGridView.Columns["total_price"].HeaderText = "Łączna cena";
                            dataGridView.Columns["status"].HeaderText = "Status";
                            dataGridView.Columns["created_at"].HeaderText = "Data utworzenia";

                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas wyświetlania szczegółów zamówienia: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }
        }




        public void EdytujStatusZamowienia(int orderId,string statusZamowieniaDoBazy, string statusZamowieniaDoWyswietlenia)
        {

            MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB);


            try
            {
                polaczenie.Open();



                using (MySqlTransaction transakcja = polaczenie.BeginTransaction())
                {

                    string ZmienStatusZamowienia = @"
                    UPDATE orders 
                    SET status = @Status, modified_at = NOW() 
                    WHERE order_id = @OrderId";

                    using (MySqlCommand sqlZmienStatusZamowienia = new MySqlCommand(ZmienStatusZamowienia, polaczenie, transakcja))
                    {
                        sqlZmienStatusZamowienia.Parameters.AddWithValue("@Status", statusZamowieniaDoBazy);
                        sqlZmienStatusZamowienia.Parameters.AddWithValue("@OrderId", orderId);

                        sqlZmienStatusZamowienia.ExecuteNonQuery();
                    }


                    transakcja.Commit();


                    MessageBox.Show("Pomyślnie Zmieniono Status Zamówienia na: \n " + "[ " + statusZamowieniaDoWyswietlenia +" ]", "Poprawnie Zmieniono!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd zmiany statusu zamówienia " + ex.Message, "Błąd");

            }

            polaczenie.Close();




        }




    }
}
