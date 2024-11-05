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
    public partial class ListaTowary_UslugiForm : Form
    {
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

        private void wysyłkiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListaTowary_UslugiForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonTowary_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
