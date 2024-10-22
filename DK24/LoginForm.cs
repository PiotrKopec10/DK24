using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;

namespace DK24
{
    public partial class LoginForm : Form
    {
        MainForm mainForm = new MainForm();
        UserClass DzialaniaNaUserze = new UserClass();
        UserClass.User AktualnyUser = new UserClass.User();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {

            SHA256 sha256 = SHA256.Create();

            AktualnyUser.worker_login = txtBoxLogin.Text.Trim();

            var haslo = txtBoxPassword.Text.Trim();

            AktualnyUser.password_hash = DzialaniaNaUserze.ZahashujHaslo(haslo);



            //DZIALA ZAKOMENTOWANE, BY NIE MUSIEC LOGOWAC SIE PONOWNIE


            //if (DzialaniaNaUserze.PobierzHasloDlaUsera(AktualnyUser) == true)
            //{
            //    this.Hide();
            //    mainForm.ShowDialog();
            //}
            //else if(txtBoxLogin.Text.Length==0 || txtBoxPassword.Text.Length == 0)
            //{
            //    lblZleHaslo.Location = new Point(415, 283);
            //    lblZleHaslo.Text = "Uzupe³nij pola aby siê zalogowaæ";

            //}
            //else
            //{
            //    lblZleHaslo.Location = new Point(432, 283);
            //    lblZleHaslo.Text = "NIEPRAWID£OWE DANE!";


            //}

            this.Hide();
            mainForm.ShowDialog();


        }

        private void lblWyjdz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void txtBoxLogin_Enter(object sender, EventArgs e)
        {
           
            lblZleHaslo.Text = "";

        }


        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            
            lblZleHaslo.Text = "";

        }


    }
}
