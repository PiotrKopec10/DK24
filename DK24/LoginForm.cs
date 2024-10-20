using Microsoft.VisualBasic.ApplicationServices;

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {


            AktualnyUser.worker_login = txtBoxLogin.Text;
            AktualnyUser.password_hash = txtBoxPassword.Text;

            if (DzialaniaNaUserze.PobierzHasloDlaUsera(AktualnyUser) == true)
            {
                this.Hide();
                mainForm.ShowDialog();
            }
            else
            {
                stsBarLogin.Text = "Has³o Nieprawid³owe!!!";
                stsBarLogin.ForeColor = Color.Red;
            }




        }

        private void lblWyjdz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
