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

        private void ListaTowary_UslugiForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonTowary_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }
    }
}
