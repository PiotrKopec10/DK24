using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
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

            public bool is_invoice = false;
            public enum StatusEnum
            {
                created,
                in_progress,
                completed,
                invoice_ready,
                canceled
            }

            public enum ShippingMethodEnum
            {
                self_pickup,
                dhl,
                inpost
            }
        }

        


        public void WyswietlSzczegolyZamowienia(int orderId, DataGridView dataGridView)
        {
            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string zapytanie = @"
                SELECT 
                    i.name AS Produkt,
                    GROUP_CONCAT(
                        CONCAT(og.title, ': ', op.name)
                        ORDER BY og.option_group_id SEPARATOR ' | '
                    ) AS Opcje,
                    i.quantity AS 'Ilość',
                    f.filename AS 'Plik',

                    f.file_id
                FROM serwer197774_drukarnia.items AS i
                    LEFT JOIN serwer197774_drukarnia.item_options AS io 
                        ON i.item_id = io.item_id
                    LEFT JOIN serwer197774_drukarnia.options AS op 
                        ON io.option_id = op.option_id
                    LEFT JOIN serwer197774_drukarnia.option_groups AS og 
                        ON op.option_group_id = og.option_group_id
                    LEFT JOIN serwer197774_drukarnia.files AS f
                        ON i.item_id = f.item_id
                WHERE 
                    i.order_id = @orderId
                GROUP BY 
                    i.name, 
                    i.quantity,
                    f.filename,
                    f.file_id
                ORDER BY 
                    i.name;
            ";

                    using (MySqlCommand sqlCommand = new MySqlCommand(zapytanie, polaczenie))
                    {
                        sqlCommand.Parameters.AddWithValue("@orderId", orderId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView.DataSource = dataTable;
                        }

                        dataGridView.Columns["Produkt"].DisplayIndex = 0;
                        dataGridView.Columns["Opcje"].DisplayIndex = 1;
                        dataGridView.Columns["Ilość"].DisplayIndex = 2;
                        dataGridView.Columns["Plik"].DisplayIndex = 3;

                        dataGridView.Columns["Produkt"].Width = 200;
                        dataGridView.Columns["Opcje"].Width = 300;
                        dataGridView.Columns["Ilość"].Width = 100;
                        dataGridView.Columns["Plik"].Width = 150;

                        if (dataGridView.Columns.Contains("file_id"))
                        {
                            dataGridView.Columns["file_id"].Visible = false;
                        }

                        DodajKolumnePobierz(dataGridView);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas wyświetlania zamówienia: " + ex.Message, "Błąd");
                }
            }
        }



        private void DodajKolumnePobierz(DataGridView dataGridView)
        {         
            if (!dataGridView.Columns.Contains("PobierzPlik"))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = "PobierzPlik",
                    HeaderText = "Pobierz plik",
                    Text = "Pobierz",
                    UseColumnTextForButtonValue = true
                };
                dataGridView.Columns.Add(btnCol);
            }
        }






        public void EdytujStatusZamowienia(int orderId, string statusZamowieniaDoBazy, string statusZamowieniaDoWyswietlenia, string SciezkaZapisaniaEtykiety)
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

                    if(SciezkaZapisaniaEtykiety == "")
                    {
                        MessageBox.Show("Pomyślnie Zmieniono Status Zamówienia na: \n " + "[ " + statusZamowieniaDoWyswietlenia + " ]", "Poprawnie Zmieniono!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }else
                    {
                        MessageBox.Show("Zmieniono Status Zamówienia na: \n " + "[ " + statusZamowieniaDoWyswietlenia + " ]\n\n\n Ścieżka w której została zapisana etykieta:\n "+SciezkaZapisaniaEtykiety, "Poprawnie Zmieniono!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd zmiany statusu zamówienia " + ex.Message, "Błąd");

            }

            polaczenie.Close();




        }



        public bool PobierzCzyFakturaPoIdZamowienia(int idZamowienia)
        {
            bool CzyFaktura = false;

            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                  
                    string zapytanie = @"
                SELECT is_invoice
                FROM orders
                WHERE order_id = @orderId
                LIMIT 1
            ";

                    using (MySqlCommand sqlCommand = new MySqlCommand(zapytanie, polaczenie))
                    {
                        sqlCommand.Parameters.AddWithValue("@orderId", idZamowienia);
                        object wynik = sqlCommand.ExecuteScalar();
                        if (wynik != null && wynik != DBNull.Value)
                        {
                            int invoiceValue = Convert.ToInt32(wynik);
                            CzyFaktura = (invoiceValue == 1);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych o fakturze dla zamówienia: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }

            return CzyFaktura;
        }




    }
}
