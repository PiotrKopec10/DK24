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

namespace DK24
{
    public partial class ZarzadzajPracownikamiForm : Form
    {

        DataTable dt = new DataTable();
        UserClass DzialaniaNaUserze = new UserClass();
        UserClass.User AktualnyUser = new UserClass.User();

        public ZarzadzajPracownikamiForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelZalogowania, this.Handle);
            GlobalClass.przesuwanieFormsa(menuStrip, this.Handle);
        }

        private UserClass.User.role GetRoleFromComboBox()
        {
            return cmbBoxRola.SelectedItem.ToString() == "Pracownik"
                ? UserClass.User.role.worker
                : UserClass.User.role.admin;
        }

        public void WyswietlListePracownikow()
        {
            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);
            MySqlDataAdapter AdapterPolaczenia = new MySqlDataAdapter();

            dt.Clear();


            try
            {
                polaczenie.Open();

                string SelectDanych = "SELECT user_id, worker_login AS 'Login Pracownika', role AS 'Rola', CONCAT(first_name, ' ', last_name) " +
                                       "AS 'Imię i Nazwisko', phone_number AS 'Numer Telefonu', email AS 'Email', created_at AS 'Data utworzenia', " +
                                        "modified_at AS 'Data Modyfikacji' FROM serwer197774_drukarnia.users " +
                                           "WHERE role = 'admin' OR role = 'worker'";


                using (MySqlCommand wyswietlDane = new MySqlCommand(SelectDanych, polaczenie))
                {
                    AdapterPolaczenia = new MySqlDataAdapter(wyswietlDane);
                    AdapterPolaczenia.SelectCommand.ExecuteNonQuery();
                    AdapterPolaczenia.Fill(dt);
                    dtGridLstPracownikow.DataSource = dt.DefaultView;

                    dtGridLstPracownikow.Columns["user_id"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobrania danych!!! " + ex.Message, "Błąd");
            }
            polaczenie.Close();
        }

        private void ZarzadzajPracownikami_Load(object sender, EventArgs e)
        {
            WyswietlListePracownikow();
            lblZalogowanoJako.Text = "Zalogowano jako: " + GlobalClass.KtoZalogowany.ZalogowanyUzytkownik;

            dataScrollBar.Width = dtGridLstPracownikow.Width;
            dataScrollBar.Left = dtGridLstPracownikow.Left;
            dataScrollBar.Top = dtGridLstPracownikow.Bottom + 15;

            dataScrollBar.Minimum = 0;
            int totalWidth = dtGridLstPracownikow.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            dataScrollBar.Maximum = Math.Max(0, totalWidth - dtGridLstPracownikow.ClientSize.Width) + dataScrollBar.LargeChange;

            dataScrollBar.Scroll += new ScrollEventHandler(dataScrollBar_Scroll);

            dtGridLstPracownikow.SizeChanged += dtGridLstPracownikow_SizeChanged;
        }

        private void dataScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            dtGridLstPracownikow.HorizontalScrollingOffset = e.NewValue;
        }

        private void dtGridLstPracownikow_SizeChanged(object sender, EventArgs e)
        {
            int totalWidth = dtGridLstPracownikow.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            dataScrollBar.Maximum = Math.Max(0, totalWidth - dtGridLstPracownikow.ClientSize.Width) + dataScrollBar.LargeChange;
        }

        public void PobierzPracownika()
        {

            if (dtGridLstPracownikow.RowCount != 0)
            {
                if (dtGridLstPracownikow.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtGridLstPracownikow.SelectedRows[0];


                    if (GlobalClass.PracownikSesja.AktualnyUser == null)
                    {
                        GlobalClass.PracownikSesja.AktualnyUser = new UserClass.User();
                    }

                    GlobalClass.PracownikSesja.AktualnyUser.user_id = Convert.ToInt32(selectedRow.Cells["users_id"].Value);

                }
                else
                {
                    MessageBox.Show("Proszę zaznaczyć Pracownika.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PobierzPracownika();

            GlobalClass.StanFormyPracownika.StanFormy = 1;
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            PobierzPracownika();

            GlobalClass.StanFormyPracownika.StanFormy = 2;
        }


        private void UstawPanelPracownika()
        {
            if (GlobalClass.StanFormyPracownika.StanFormy == 1)
            {
                pnlZarzadzaniaPracownikami.Enabled = true;
                txtBoxImie.Text = "";
                txtBoxNazwisko.Text = "";
                txtBoxEmail.Text = "";
                txtBoxNrTel.Text = "";
                cmbBoxRola.SelectedIndex = -1;
                txtBoxLogin.Text = "";
                txtBoxHaslo.Text = "";
                dtPickerUtworzono.Value = DateTime.Today;
            }
            else if (GlobalClass.StanFormyPracownika.StanFormy == 2)
            {
                pnlZarzadzaniaPracownikami.Enabled = true;
                txtBoxImie.Text = AktualnyUser.first_name;
                txtBoxNazwisko.Text = AktualnyUser.last_name;
                txtBoxEmail.Text = AktualnyUser.email;
                txtBoxNrTel.Text = AktualnyUser.phone_number;
               // cmbBoxRola.Text = AktualnyUser.role == UserClass.User.role.worker ? "Pracownik" : "Admin";
                txtBoxLogin.Text = AktualnyUser.worker_login;
                txtBoxHaslo.Text = AktualnyUser.password_hash;
                dtPickerUtworzono.Value = AktualnyUser.created_at;
                dtPickerUtworzono.Value = DateTime.Today;
            }
            else
            {
                pnlZarzadzaniaPracownikami.Enabled = false;
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (GlobalClass.StanFormyPracownika.StanFormy == 1)
            {
                DodajPracownika();
            }
            else if (GlobalClass.StanFormyPracownika.StanFormy == 2)
            {
                EdytujPracownika();
            }
        }

        private void DodajPracownika()
        {
            UserClass.User nowyPracownik = new UserClass.User
            {
                first_name = txtBoxImie.Text,
                last_name = txtBoxNazwisko.Text,
                email = txtBoxEmail.Text,
                phone_number = txtBoxNrTel.Text,
                worker_login = txtBoxLogin.Text,
                password_hash = DzialaniaNaUserze.ZahashujHaslo(txtBoxHaslo.Text),
         //       role = (UserClass.User.role)Enum.Parse(typeof(UserClass.User.role), cmbBoxRola.SelectedItem.ToString()),
                created_at = DateTime.Now,
                modified_at = DateTime.Now
            };

            using (MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie))
            {
                try
                {
                    polaczenie.Open();
                    string query = @"INSERT INTO users (worker_login, first_name, last_name, phone_number, email, password_hash, role, created_at, modified_at)
                                     VALUES (@worker_login, @first_name, @last_name, @phone_number, @email, @password_hash, @role, @created_at, @modified_at)";
                    using (MySqlCommand cmd = new MySqlCommand(query, polaczenie))
                    {
                        cmd.Parameters.AddWithValue("@worker_login", nowyPracownik.worker_login);
                        cmd.Parameters.AddWithValue("@first_name", nowyPracownik.first_name);
                        cmd.Parameters.AddWithValue("@last_name", nowyPracownik.last_name);
                        cmd.Parameters.AddWithValue("@phone_number", nowyPracownik.phone_number);
                        cmd.Parameters.AddWithValue("@email", nowyPracownik.email);
                        cmd.Parameters.AddWithValue("@password_hash", nowyPracownik.password_hash);
                  //      cmd.Parameters.AddWithValue("@role", nowyPracownik.role.ToString());
                        cmd.Parameters.AddWithValue("@created_at", nowyPracownik.created_at);
                        cmd.Parameters.AddWithValue("@modified_at", nowyPracownik.modified_at);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie dodano pracownika!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas dodawania pracownika: " + ex.Message, "Błąd");
                }
            }
        }


        private void EdytujPracownika()
        {
            AktualnyUser.first_name = txtBoxImie.Text;
            AktualnyUser.last_name = txtBoxNazwisko.Text;
            AktualnyUser.email = txtBoxEmail.Text;
            AktualnyUser.phone_number = txtBoxNrTel.Text;
        //    AktualnyUser.role = (UserClass.User.Role)Enum.Parse(typeof(UserClass.User.Role), cmbBoxRola.SelectedItem.ToString());
            AktualnyUser.modified_at = DateTime.Now;

            using (MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie))
            {
                try
                {
                    polaczenie.Open();
                    string query = @"UPDATE users SET first_name = @first_name, last_name = @last_name, phone_number = @phone_number, 
                                     email = @email, role = @role, modified_at = @modified_at WHERE user_id = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, polaczenie))
                    {
                        cmd.Parameters.AddWithValue("@first_name", AktualnyUser.first_name);
                        cmd.Parameters.AddWithValue("@last_name", AktualnyUser.last_name);
                        cmd.Parameters.AddWithValue("@phone_number", AktualnyUser.phone_number);
                        cmd.Parameters.AddWithValue("@email", AktualnyUser.email);
                   //     cmd.Parameters.AddWithValue("@role", AktualnyUser.role.ToString());
                        cmd.Parameters.AddWithValue("@modified_at", AktualnyUser.modified_at);
                        cmd.Parameters.AddWithValue("@user_id", AktualnyUser.user_id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie edytowano dane pracownika!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas edytowania pracownika: " + ex.Message, "Błąd");
                }
            }
        }

    }
}
