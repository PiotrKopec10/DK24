using DK24.Klasy;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System.Data;
using static DK24.Klasy.Uslugi_TowarClass;

namespace DK24
{
    public partial class ZamowienieKontrahentaForm : Form
    {
        string PolaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;
        DataTable produktyTabela = new DataTable();
        Uslugi_TowarClass DzialaniaNaTowarze = new Uslugi_TowarClass();


        public ZamowienieKontrahentaForm()
        {
            InitializeComponent();
        }

        private void ZamowienieKontrahentaForm_Load(object sender, EventArgs e)
        {
            PobierzProdukty();
           

        }

       



        public void PobierzProdukty()
        {



            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string PobierzProdukty = @"SELECT product_id ,sku, name, base_price FROM serwer197774_drukarnia.products";

                    using (MySqlCommand sqlPobierzProdukty = new MySqlCommand(PobierzProdukty, polaczenie))
                    {

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlPobierzProdukty))
                        {
                            adapter.Fill(produktyTabela);
                        }


                    }


                    dtGridWybProdukty.DataSource = produktyTabela;

                    dtGridWybProdukty.Columns["product_id"].Visible = false;
                    dtGridWybProdukty.Columns["sku"].HeaderText = "Numer Produktu";
                    dtGridWybProdukty.Columns["name"].HeaderText = "Nazwa Produktu";
                    dtGridWybProdukty.Columns["base_price"].HeaderText = "Cena";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd Pobierania Produktów: " + ex.Message, "Błąd");

                }
                finally
                {
                    polaczenie.Close();
                }


            }
        }

        private void btnWybierzProdukt_Click(object sender, EventArgs e)
        {
            PobierzProdukt();
            int selectedProductId = GlobalClass.ProduktSesja.AktualnyProdukt.product_id;

            WyswietlGrupyIOpcjeProduktu();




        }



        public void PobierzProdukt()
        {

            if (dtGridWybProdukty.RowCount != 0)
            {
                if (dtGridWybProdukty.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtGridWybProdukty.SelectedRows[0];


                    if (GlobalClass.ProduktSesja.AktualnyProdukt == null)
                    {
                        GlobalClass.ProduktSesja.AktualnyProdukt = new Uslugi_TowarClass.Produkt();
                    }

                    GlobalClass.ProduktSesja.AktualnyProdukt.product_id = Convert.ToInt32(selectedRow.Cells["product_id"].Value);


                }
                else
                {
                    MessageBox.Show("Proszę zaznaczyć Produkt.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }




        }








        public void WyswietlGrupyIOpcjeProduktu()
        {
            int productId = GlobalClass.ProduktSesja.AktualnyProdukt.product_id;

            // Pobierz grupy opcji dla produktu
            List<Option_groups> grupyOpcji = DzialaniaNaTowarze.PobierzGrupyOpcji(productId);

            // Utwórz DataTable do powiązania z DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("option_group_id", typeof(int));
            dt.Columns.Add("GrupaOpcji", typeof(string));
            dt.Columns.Add("WybranaOpcja", typeof(int));

            foreach (var grupa in grupyOpcji)
            {
                DataRow row = dt.NewRow();
                row["option_group_id"] = grupa.option_group_id;
                row["GrupaOpcji"] = grupa.title;
                row["WybranaOpcja"] = DBNull.Value; // Na razie brak wybranej opcji
                dt.Rows.Add(row);
            }

            dtGridWybParam.DataSource = dt;

            // Ukryj kolumnę option_group_id
            dtGridWybParam.Columns["option_group_id"].Visible = false;

            // Usuń kolumnę WybranaOpcja i zastąp ją ComboBoxem
            dtGridWybParam.Columns.Remove("WybranaOpcja");

            DataGridViewComboBoxColumn comboCol = new DataGridViewComboBoxColumn();
            comboCol.Name = "WybranaOpcja";
            comboCol.HeaderText = "Opcja";
            comboCol.DataPropertyName = "WybranaOpcja"; // Powiązanie z DataTable

            dtGridWybParam.Columns.Add(comboCol);

            // Dla każdego wiersza ustaw źródło danych ComboBoxa
            foreach (DataGridViewRow dgvRow in dtGridWybParam.Rows)
            {
                int optionGroupId = Convert.ToInt32(dgvRow.Cells["option_group_id"].Value);

                List<Options> opcje = DzialaniaNaTowarze.PobierzOpcje(optionGroupId);

                // Sprawdź, czy lista opcji nie jest pusta
                if (opcje != null && opcje.Count > 0)
                {
                    // Konwertuj listę opcji na DataTable
                    DataTable optionsTable = new DataTable();
                    optionsTable.Columns.Add("option_id", typeof(int));
                    optionsTable.Columns.Add("name", typeof(string));

                    foreach (Options opt in opcje)
                    {
                        DataRow optRow = optionsTable.NewRow();
                        optRow["option_id"] = opt.option_id;
                        optRow["name"] = opt.name;
                        optionsTable.Rows.Add(optRow);
                    }

                    DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dgvRow.Cells["WybranaOpcja"];
                    comboCell.DataSource = optionsTable;
                    comboCell.DisplayMember = "name";
                    comboCell.ValueMember = "option_id";
                }
                else
                {
                    // Jeśli brak opcji, możesz ustawić pusty DataTable lub obsłużyć to inaczej
                    DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dgvRow.Cells["WybranaOpcja"];
                    comboCell.DataSource = null;
                }
            }
        }













    }
}
