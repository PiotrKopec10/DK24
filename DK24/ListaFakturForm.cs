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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }


        private void ListaFakturForm_Load(object sender, EventArgs e)
        {
            lblZalogowanoJako.Text = "Zalogowano jako: " + GlobalClass.KtoZalogowany.ZalogowanyUzytkownik;
        }

        private void zamówieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
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
            DokumentForm dokumentForm = new DokumentForm();
            this.Hide();
            dokumentForm.ShowDialog();
        }
    }
}
