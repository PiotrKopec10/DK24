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
    public partial class ListaKontrahentowForm : Form
    {
        public ListaKontrahentowForm()
        {
            InitializeComponent();
        }

        private void zamówieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm zamowieniaForm = new MainForm();
            this.Hide();
            zamowieniaForm.ShowDialog();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DokumentForm fakturaForm = new DokumentForm();
            this.Hide();
            fakturaForm.ShowDialog();
        }

        private void zobaczFakturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaFakturForm listaFakturForm = new ListaFakturForm();
            this.Hide();
            listaFakturForm.ShowDialog();
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrahentForm kontrahentForm = new KontrahentForm();
            this.Hide();
            kontrahentForm.ShowDialog();
        }
    }
}
