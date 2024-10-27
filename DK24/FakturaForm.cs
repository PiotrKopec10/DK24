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

            GlobalClass.zapamietajPozycjeFormsa(this);
        }

        private void OpenDialog(Form dialogForm)
        {
            GlobalClass.zapiszNowaPozycjeFormsa(this);
            this.Hide();
            GlobalClass.zapamietajPozycjeFormsa(dialogForm);
            dialogForm.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            OpenDialog(new ListaFakturForm());
        }
    }
}
