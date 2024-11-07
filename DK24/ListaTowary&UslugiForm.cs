using DK24.Klasy;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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


        private void WyswietlTowaryIUslugi()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
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
                ORDER BY p.product_id, og.option_group_id, o.option_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, polaczenie);
                    adapter.Fill(dt);


                    DataTable dynamicDt = new DataTable();
                    dynamicDt.Columns.Add("Numer Produktu", typeof(string));
                    dynamicDt.Columns.Add("Nazwa Produktu", typeof(string));
                    dynamicDt.Columns.Add("Cena", typeof(decimal));
                    dynamicDt.Columns.Add("Grupa Opcji #1", typeof(string));
                    dynamicDt.Columns.Add("Opcja #1", typeof(string));
                    dynamicDt.Columns.Add("Cena dodatkowa #1", typeof(decimal));
                    dynamicDt.Columns.Add("Grupa Opcji #2", typeof(string));
                    dynamicDt.Columns.Add("Opcja #2", typeof(string));
                    dynamicDt.Columns.Add("Cena dodatkowa #2", typeof(decimal));
                    dynamicDt.Columns.Add("Łączna kwota", typeof(decimal));

                    // Grupowanie danych według produktu
                    var groupedData = dt.AsEnumerable()
                        .GroupBy(row => new
                        {
                            NumerProduktu = row["Numer Produktu"].ToString(),
                            NazwaProduktu = row["Nazwa Produktu"].ToString(),
                            Cena = row.Field<decimal>("Cena")
                        });

                    // Wypełnianie dynamicznej tabeli na podstawie grup opcji
                    foreach (var productGroup in groupedData)
                    {
                        foreach (var optionCombination in PobierzKombinacjeOpcji(productGroup.ToList(), 2))
                        {
                            var newRow = dynamicDt.NewRow();
                            newRow["Numer Produktu"] = productGroup.Key.NumerProduktu;
                            newRow["Nazwa Produktu"] = productGroup.Key.NazwaProduktu;
                            newRow["Cena"] = productGroup.Key.Cena;

                            decimal lacznaKwota = productGroup.Key.Cena;

                            for (int i = 0; i < optionCombination.Count; i++)
                            {
                                newRow[$"Grupa Opcji #{i + 1}"] = optionCombination[i].NazwaGrupy;
                                newRow[$"Opcja #{i + 1}"] = optionCombination[i].NazwaOpcji;
                                newRow[$"Cena dodatkowa #{i + 1}"] = optionCombination[i].CenaDodatkowa;
                                lacznaKwota += optionCombination[i].CenaDodatkowa;
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





        private void radioButtonTowary_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
