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
    public partial class ListaFakturForm : Form
    {
        public ListaFakturForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelZalogowania, this.Handle);
            GlobalClass.przesuwanieFormsa(menuStrip, this.Handle);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DokumentForm dodajDokument = new DokumentForm();
            this.Hide();
            dodajDokument.ShowDialog();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void zamówieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void dodajKontrahentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KontrahentForm kontrahentForm = new KontrahentForm();
            this.Hide();
            kontrahentForm.ShowDialog();
        }

        private void zobaczKontrahentówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaKontrahentowForm listaKontrahentowForm = new ListaKontrahentowForm();
            this.Hide();
            listaKontrahentowForm.ShowDialog();
        }

        private void ListaFakturForm_Load(object sender, EventArgs e)
        {
            lblZalogowanoJako.Text = "Zalogowano jako: " + GlobalClass.KtoZalogowany.ZalogowanyUzytkownik;
        }
    }
}
