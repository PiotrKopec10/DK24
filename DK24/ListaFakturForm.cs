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
        }

        private void zamówieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm zamowieniaForm = new MainForm();
            this.Hide();
            zamowieniaForm.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DokumentForm dodajDokument = new DokumentForm();
            this.Hide();
            dodajDokument.ShowDialog();
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
    }
}
