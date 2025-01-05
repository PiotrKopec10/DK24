using DK24.Klasy;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace DK24
{
    public partial class ResetujHasloForm : Form
    {

        private UserClass.User _user;
        private UserClass _userClass;

        private Timer timerStworzHaslo;
        private Timer timerPowtorzHaslo;
        private Dictionary<int, char> stworzHasloChars = new Dictionary<int, char>();
        private Dictionary<int, char> powtorzHasloChars = new Dictionary<int, char>();


        public string NoweHaslo { get; private set; }

        public ResetujHasloForm(UserClass.User user)
        {
            InitializeComponent();

            timerStworzHaslo = new Timer();
            timerStworzHaslo.Interval = 300; 
            timerStworzHaslo.Tick += TimerStworzHaslo_Tick;

            timerPowtorzHaslo = new Timer();
            timerPowtorzHaslo.Interval = 300; 
            timerPowtorzHaslo.Tick += TimerPowtorzHaslo_Tick;

     
            txtBoxStworzHaslo.TextChanged += TxtBoxStworzHaslo_TextChanged;
            txtBoxPowtorzHaslo.TextChanged += TxtBoxPowtorzHaslo_TextChanged;


            _user = user;
            _userClass = new UserClass();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtBoxStworzHaslo.Text;
                string confirmPassword = txtBoxPowtorzHaslo.Text;

                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Pole nie może być puste. Spróbuj ponownie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Hasła się nie zgadzają. Spróbuj ponownie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password.Length < 5)
                {
                    MessageBox.Show("Hasło musi mieć co najmniej 5 znaków. Spróbuj ponownie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[0-9]") ||
                    !System.Text.RegularExpressions.Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>]"))
                {
                    MessageBox.Show("Hasło musi zawierać co najmniej jedną cyfrę i jeden znak specjalny. Spróbuj ponownie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashedPassword = _userClass.ZahashujHaslo(password);
                    NoweHaslo = hashedPassword;

                    using (MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie))
                    {
                        polaczenie.Open();
                        string query = "UPDATE users SET password_hash = @password WHERE user_id = @user_id";

                        using (MySqlCommand cmd = new MySqlCommand(query, polaczenie))
                        {
                            cmd.Parameters.AddWithValue("@password", hashedPassword);
                            cmd.Parameters.AddWithValue("@user_id", _user.user_id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Hasło zostało pomyślnie zresetowane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas resetowania hasła: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void btnCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TxtBoxStworzHaslo_TextChanged(object sender, EventArgs e)
        {
            StartPasswordProcessing(txtBoxStworzHaslo, stworzHasloChars, timerStworzHaslo);
        }

        private void TxtBoxPowtorzHaslo_TextChanged(object sender, EventArgs e)
        {
            StartPasswordProcessing(txtBoxPowtorzHaslo, powtorzHasloChars, timerPowtorzHaslo);
        }

        private void StartPasswordProcessing(TextBox textBox, Dictionary<int, char> charDictionary, Timer timer)
        {
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (!charDictionary.ContainsKey(i))
                {
                    charDictionary[i] = textBox.Text[i];
                }
            }

            if (!timer.Enabled)
            {
                timer.Start();
            }
        }

        private void TimerStworzHaslo_Tick(object sender, EventArgs e)
        {
            ReplaceCharactersWithBullet(txtBoxStworzHaslo, stworzHasloChars, timerStworzHaslo);
        }

        private void TimerPowtorzHaslo_Tick(object sender, EventArgs e)
        {
            ReplaceCharactersWithBullet(txtBoxPowtorzHaslo, powtorzHasloChars, timerPowtorzHaslo);
        }

        private void ReplaceCharactersWithBullet(TextBox textBox, Dictionary<int, char> charDictionary, Timer timer)
        {
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (charDictionary.ContainsKey(i) && charDictionary[i] != '•')
                {
                    charDictionary[i] = '•';
                }
            }

            string updatedText = new string(textBox.Text.Select((c, i) => charDictionary.ContainsKey(i) ? charDictionary[i] : c).ToArray());
            int selectionStart = textBox.SelectionStart;
            textBox.Text = updatedText;
            textBox.SelectionStart = selectionStart;

            if (!charDictionary.Values.Any(c => c != '•'))
            {
                timer.Stop();
            }
        }
    }
}
