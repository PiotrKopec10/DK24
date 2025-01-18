using DK24.Klasy;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;

namespace DK24
{
    public partial class LoginForm : Form
    {
        MainForm mainForm = new MainForm();
        UserClass DzialaniaNaUserze = new UserClass();
        UserClass.User AktualnyUser = new UserClass.User();

        private string aktualneHaslo;

        public LoginForm()
        {
            InitializeComponent();

            aktualneHaslo = string.Empty;


            txtBoxPassword.TextChanged += TxtBoxHaslo_TextChanged;
            imgOdszyfruj.MouseDown += ImgOdszyfruj_MouseDown;
            imgOdszyfruj.MouseUp += ImgOdszyfruj_MouseUp;
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



            if (DzialaniaNaUserze.PobierzHasloDlaUsera(AktualnyUser) == true)
            {
                GlobalClass.KtoZalogowany.ZalogowanyUzytkownik = txtBoxLogin.Text;
                this.Hide();
                mainForm.ShowDialog();
            }
            else if (txtBoxLogin.Text.Length == 0 || txtBoxPassword.Text.Length == 0)
            {
                lblZleHaslo.Location = new Point(415, 283);
                lblZleHaslo.Text = "Uzupe³nij pola aby siê zalogowaæ";

            }
            else
            {
                lblZleHaslo.Location = new Point(432, 283);
                lblZleHaslo.Text = "NIEPRAWID£OWE DANE!";


            }

           


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

        private void TxtBoxHaslo_TextChanged(object sender, EventArgs e)
        {
            aktualneHaslo = txtBoxPassword.Text;
        }

        private void ImgOdszyfruj_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxPassword.PasswordChar = '\0';
        }

        private void ImgOdszyfruj_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxPassword.PasswordChar = '•';
        }
    }
}
