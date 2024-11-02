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
    public partial class SzczegolyZamowieniaForm : Form
    {
        public SzczegolyZamowieniaForm()
        {
            InitializeComponent();
        }

        private void SzczegolyZamowieniaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }
    }
}
