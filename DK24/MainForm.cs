using DK24.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DK24
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelZalogowania, this.Handle);
            GlobalClass.przesuwanieFormsa(menuStrip, this.Handle);

        }


        private void MainForm_Load(object sender, EventArgs e)
        {


            DataSet ds = new DataSet();

            DataTable dtZamowienia = new DataTable("Zamowienia");

            dtZamowienia.Columns.Add("Nr.Zamówienia", typeof(string));
            dtZamowienia.Columns.Add("Cena", typeof(decimal));
            dtZamowienia.Columns.Add("Czy Faktura", typeof(bool));
            dtZamowienia.Columns.Add("Czy Wysyłka", typeof(bool));
            dtZamowienia.Columns.Add("Pozycje", typeof(string));

            // Dodaj dane do tabeli
            dtZamowienia.Rows.Add("Zam001", 200.00m, true, false, "Produkt A, Produkt B");
            dtZamowienia.Rows.Add("Zam002", 350.50m, false, true, "Produkt C, Produkt D");
            dtZamowienia.Rows.Add("Zam003", 150.75m, true, true, "Produkt E");

            // Dodaj tabelę do DataSet
            ds.Tables.Add(dtZamowienia);

            // Przypisz tabelę do DataGridView jako źródło danych
            dtGridViewZamowienia.DataSource = ds.Tables["Zamowienia"];




            lblZalogowanoJako.Text = "Zalogowano jako: " + GlobalClass.KtoZalogowany.ZalogowanyUzytkownik;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SzczegolyZamowieniaForm szczegolyZamowieniaForm = new SzczegolyZamowieniaForm();
            this.Hide();
            szczegolyZamowieniaForm.ShowDialog();
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

        private void wysyłkiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void towaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaTowary_UslugiForm listaTowary_Uslugi = new ListaTowary_UslugiForm();
            this.Hide();
            listaTowary_Uslugi.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            WyborKlient_KontrahentZamowienieForm wyborKlient_KontrahentZamowienieForm = new WyborKlient_KontrahentZamowienieForm();
            this.Hide();
            wyborKlient_KontrahentZamowienieForm.ShowDialog();
        }
    }
}
