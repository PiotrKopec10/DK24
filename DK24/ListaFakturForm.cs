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

            GlobalClass.SetFormLocation(this);
        }

        private void OpenDialog(Form dialogForm)
        {
            GlobalClass.SaveFormLocation(this);
            this.Hide();
            GlobalClass.SetFormLocation(dialogForm);
            dialogForm.ShowDialog();
            this.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OpenDialog(new DokumentForm());
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void zamówieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDialog(new MainForm());
        }

        private void dodajKontrahentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDialog(new KontrahentForm());
        }

        private void zobaczKontrahentówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDialog(new ListaKontrahentowForm());
        }

        private void ListaFakturForm_Load(object sender, EventArgs e)
        {
            lblZalogowanoJako.Text = "Zalogowano jako: " + GlobalClass.KtoZalogowany.ZalogowanyUzytkownik;
        }
    }
}
