using DK24.Klasy;
using MySql.Data.MySqlClient;
using System.Data;

namespace DK24
{
    public partial class ListaTowary_UslugiForm : Form
    {
        string PolaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;
        public ListaTowary_UslugiForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelZalogowania, this.Handle);
            GlobalClass.przesuwanieFormsa(menuStrip, this.Handle);
        }

        private void zamówieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void fakturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaFakturForm listaFakturForm = new ListaFakturForm();
            this.Hide();
            listaFakturForm.ShowDialog();
        }

        private void kontrahenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaKontrahentowForm listaKontrahentowForm = new ListaKontrahentowForm();
            this.Hide();
            listaKontrahentowForm.ShowDialog();
        }

        private void ListaTowary_UslugiForm_Load(object sender, EventArgs e)
        {
            WyswietlTowaryIUslugi();
        }


        private void WyswietlTowaryIUslugi(string filtrSKU = "")
        {
            DataTable dt = new DataTable();
            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string query = @"
                    SELECT 
                    p.sku AS 'Numer Produktu',
                    p.name AS 'Nazwa Produktu',
                    p.base_price AS 'Cena',
                    og.title AS 'GrupaOpcji',
                    o.name AS 'Opcja',
                    COALESCE(o.price_increment, 0) AS 'CenaDodatkowa'
                    FROM products p
                    LEFT JOIN option_groups og ON p.product_id = og.product_id
                    LEFT JOIN options o ON og.option_group_id = o.option_group_id
                    ";

                    if (!string.IsNullOrEmpty(filtrSKU))
                    {
                        query += " WHERE p.sku LIKE @filtrSKU";
                    }

                    query += " ORDER BY p.product_id, og.option_group_id, o.option_id";

                    MySqlCommand command = new MySqlCommand(query, polaczenie);

                    if (!string.IsNullOrEmpty(filtrSKU))
                    {
                        command.Parameters.AddWithValue("@filtrSKU", filtrSKU + "%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);

                    DataTable dynamicDt = new DataTable();
                    dynamicDt.Columns.Add("Numer Produktu", typeof(string));
                    dynamicDt.Columns.Add("Nazwa Produktu", typeof(string));
                    dynamicDt.Columns.Add("Typ", typeof(string));
                    dynamicDt.Columns.Add("Rodzaj", typeof(string));
                    dynamicDt.Columns.Add("Łączna kwota", typeof(decimal));

                    var groupedData = dt.AsEnumerable()
                        .GroupBy(row => new
                        {
                            NumerProduktu = row["Numer Produktu"].ToString(),
                            NazwaProduktu = row["Nazwa Produktu"].ToString(),
                            Cena = row.Field<decimal>("Cena")
                        });

                    foreach (var productGroup in groupedData)
                    {
                        var opcjeProduktow = PobierzKombinacjeOpcji(productGroup.ToList(), 2);

                 
                        if (!opcjeProduktow.Any())
                        {
                            opcjeProduktow.Add(new List<SzczegolyOpcji>());
                        }

                        foreach (var optionCombination in opcjeProduktow)
                        {
                            var newRow = dynamicDt.NewRow();
                            newRow["Numer Produktu"] = productGroup.Key.NumerProduktu;
                            newRow["Nazwa Produktu"] = productGroup.Key.NazwaProduktu;

                            decimal lacznaKwota = productGroup.Key.Cena;

                         
                            for (int i = 0; i < 2; i++)
                            {
                                string kolumna = i == 0 ? "Typ" : "Rodzaj";
                                if (optionCombination.Count > i)
                                {
                                    var opcja = optionCombination[i];
                                    string grupaOpcji = opcja.NazwaGrupy;
                                    string nazwaOpcji = opcja.NazwaOpcji;

                                    if (string.IsNullOrEmpty(grupaOpcji) && string.IsNullOrEmpty(nazwaOpcji))
                                    {
                                        newRow[kolumna] = "Usługa";
                                    }
                                    else
                                    {
                                        newRow[kolumna] = $"{grupaOpcji} | {nazwaOpcji}";
                                    }

                                    lacznaKwota += opcja.CenaDodatkowa;
                                }
                                else
                                {
                                  
                                    newRow[kolumna] = "Usługa";
                                }
                            }

                            newRow["Łączna kwota"] = lacznaKwota;
                            dynamicDt.Rows.Add(newRow);
                        }
                    }

                    dtGridLsTowary.DataSource = dynamicDt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas ładowania danych: " + ex.Message, "Błąd");
                }
            }
        }





        private List<List<SzczegolyOpcji>> PobierzKombinacjeOpcji(List<DataRow> opcje, int liczbaGrup)
        {
            var grupowaneOpcje = opcje
                .GroupBy(row => row["GrupaOpcji"].ToString())
                .Select(g => g.Select(row => new SzczegolyOpcji
                {
                    NazwaGrupy = row["GrupaOpcji"].ToString(),
                    NazwaOpcji = row["Opcja"].ToString(),
                    CenaDodatkowa = row.Field<decimal?>("CenaDodatkowa") ?? 0
                }).ToList())
                .ToList();

            return GenerujKombinacje(grupowaneOpcje, liczbaGrup);
        }


        private List<List<SzczegolyOpcji>> GenerujKombinacje(List<List<SzczegolyOpcji>> grupyOpcji, int liczbaGrup)
        {
            var wyniki = new List<List<SzczegolyOpcji>>();
            GenerujKombinacjeRekurencyjnie(grupyOpcji.Take(liczbaGrup).ToList(), 0, new List<SzczegolyOpcji>(), wyniki);
            return wyniki;
        }

        private void GenerujKombinacjeRekurencyjnie(List<List<SzczegolyOpcji>> grupyOpcji, int glebokosc, List<SzczegolyOpcji> obecnaKombinacja, List<List<SzczegolyOpcji>> wyniki)
        {
            if (glebokosc == grupyOpcji.Count)
            {
                wyniki.Add(new List<SzczegolyOpcji>(obecnaKombinacja));
                return;
            }

            foreach (var opcja in grupyOpcji[glebokosc])
            {
                obecnaKombinacja.Add(opcja);
                GenerujKombinacjeRekurencyjnie(grupyOpcji, glebokosc + 1, obecnaKombinacja, wyniki);
                obecnaKombinacja.RemoveAt(obecnaKombinacja.Count - 1);
            }
        }

        public class SzczegolyOpcji
        {
            public string NazwaGrupy { get; set; }
            public string NazwaOpcji { get; set; }
            public decimal CenaDodatkowa { get; set; }
        }





        private void radioButtonTowary_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonTowary.Checked)
            {
                WyswietlTowaryIUslugi("P");
            }

        }

        private void radioButtonUslugi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUslugi.Checked)
            {
                WyswietlTowaryIUslugi("U");
            }

        }

        private void radioButtonWszystko_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWszystko.Checked)
            {
                WyswietlTowaryIUslugi();
            }
        }
    }
}
