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
    public partial class DokumentForm : Form
    {
        public DokumentForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelGorny, this.Handle);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            ListaFakturForm mainForm = new ListaFakturForm();
            this.Hide();
            mainForm.ShowDialog();
        }
    }
}
