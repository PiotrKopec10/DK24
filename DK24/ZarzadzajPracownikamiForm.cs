using DK24.Klasy;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DK24
{
    public partial class ZarzadzajPracownikamiForm : Form
    {
        DataTable dt = new DataTable();
        GlobalClass GlobalneDzialania = new GlobalClass();
        UserClass DzialaniaNaUserze = new UserClass();
        UserClass.User AktualnyUser = new UserClass.User();

        private string aktualneHaslo;

        public ZarzadzajPracownikamiForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelZalogowania, this.Handle);
            GlobalClass.przesuwanieFormsa(menuStrip, this.Handle);

            cmbBoxRola.Items.Add("Pracownik");
            cmbBoxRola.Items.Add("Admin");
            cmbBoxRola.SelectedIndexChanged += cmbBoxRola_SelectedIndexChanged;

            radioButtonWszyscy.CheckedChanged += radioButtonWszystko_CheckedChanged;
            radioButtonPracownicy.CheckedChanged += radioButtonPracownicy_CheckedChanged;
            radioButtonAdmin.CheckedChanged += radioButtonAdmin_CheckedChanged;

            aktualneHaslo = string.Empty;


            txtBoxHaslo.TextChanged += TxtBoxHaslo_TextChanged;
            imgOdszyfruj.MouseDown += ImgOdszyfruj_MouseDown;
            imgOdszyfruj.MouseUp += ImgOdszyfruj_MouseUp;

        }

        private void cmbBoxRola_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxRola.SelectedItem != null)
            {
                AktualnyUser.role = cmbBoxRola.SelectedItem.ToString() == "Pracownik"
                    ? UserClass.User.RoleEnum.worker
                    : UserClass.User.RoleEnum.admin;
            }
        }


        public void WyswietlListePracownikow(string filtrRoli = "")
        {
            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);
            MySqlDataAdapter AdapterPolaczenia = new MySqlDataAdapter();
            dt.Clear();

            try
            {
                polaczenie.Open();

                string query = "SELECT user_id, worker_login AS 'Login Pracownika', role AS 'Rola', CONCAT(first_name, ' ', last_name) " +
                               "AS 'Imię i Nazwisko', phone_number AS 'Numer Telefonu', email AS 'Email', created_at AS 'Data utworzenia', " +
                               "modified_at AS 'Data Modyfikacji' FROM serwer197774_drukarnia.users " +
                               "WHERE (role = 'admin' OR role = 'worker') ";

                if (!string.IsNullOrEmpty(filtrRoli))
                {
                    query += "AND role = @filtrRoli ";
                }

                query += "ORDER BY user_id";

                using (MySqlCommand wyswietlDane = new MySqlCommand(query, polaczenie))
                {

                    if (!string.IsNullOrEmpty(filtrRoli))
                    {
                        wyswietlDane.Parameters.AddWithValue("@filtrRoli", filtrRoli);
                    }

                    AdapterPolaczenia = new MySqlDataAdapter(wyswietlDane);
                    AdapterPolaczenia.Fill(dt);
                    dtGridLstPracownikow.DataSource = dt.DefaultView;
                    dtGridLstPracownikow.Columns["user_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobrania danych!!! " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }
        }




        private void ZarzadzajPracownikami_Load(object sender, EventArgs e)
        {
            WyswietlListePracownikow();
            lblZalogowanoJako.Text = "Zalogowano jako: " + GlobalClass.KtoZalogowany.ZalogowanyUzytkownik;

            GlobalClass.StanFormyPracownika.StanFormy = 1;
            UstawPanelPracownika();
        }

        private void dataScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            dtGridLstPracownikow.HorizontalScrollingOffset = e.NewValue;
        }


        public void PobierzPracownika()
        {
            if (dtGridLstPracownikow.RowCount != 0 && dtGridLstPracownikow.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtGridLstPracownikow.SelectedRows[0];
                AktualnyUser.user_id = Convert.ToInt32(selectedRow.Cells["user_id"].Value);
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć Pracownika.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            EnableFields();
            btnZapisz.Visible = true;
            PobierzPracownika();
            lblNaglowek.Visible = true;
            lblNaglowek.Text = "EDYTUJ PRACOWNIKA";
            cmbBoxNrTelPrefix.SelectedItem = "+48";
            lblWymaganiaHasla.Visible = false;

            if (AktualnyUser.user_id >= 0)
            {
                GlobalClass.StanFormyPracownika.StanFormy = 2;
                AktualnyUser = DzialaniaNaUserze.PobierzUseraPoIdUsera(AktualnyUser.user_id);
                UstawPanelPracownika();
                dtPickerUtworzono.Value = AktualnyUser.created_at;
            }
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
                cmbBoxNrTelPrefix.SelectedIndex = -1;
                txtBoxLogin.Text = "";
                txtBoxHaslo.Text = "";
                btnResetujHaslo.Visible = false;
            }
            else if (GlobalClass.StanFormyPracownika.StanFormy == 2)
            {
                pnlZarzadzaniaPracownikami.Enabled = true;
                txtBoxImie.Text = AktualnyUser.first_name;
                txtBoxNazwisko.Text = AktualnyUser.last_name;
                txtBoxEmail.Text = AktualnyUser.email;
                txtBoxNrTel.Text = AktualnyUser.phone_number;
                cmbBoxRola.Text = AktualnyUser.role == UserClass.User.RoleEnum.worker ? "Pracownik" : "Admin";
                txtBoxLogin.Text = AktualnyUser.worker_login;
                txtBoxHaslo.Text = AktualnyUser.password_hash;
                txtBoxHaslo.Enabled = false;
                btnResetujHaslo.Visible = true;
            }
            else
            {
                pnlZarzadzaniaPracownikami.Enabled = false;
            }
        }


        private void btnZapisz_Click(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip
            {
                IsBalloon = true,
                InitialDelay = 0,
                ShowAlways = true
            };

            bool isValid = true;


            if (string.IsNullOrWhiteSpace(txtBoxImie.Text) || txtBoxImie.TextLength < 3)
            {
                txtBoxImie.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxImie, "Pole Imię nie może być puste!");
                isValid = false;
            }
            else
            {
                txtBoxImie.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxNazwisko.Text) || txtBoxNazwisko.TextLength < 5)
            {
                txtBoxNazwisko.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxNazwisko, "Pole Nazwisko nie może być puste!");
                isValid = false;
            }
            else
            {
                txtBoxNazwisko.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text) || !txtBoxEmail.Text.Contains("@"))
            {
                txtBoxEmail.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxEmail, "Pole Email nie może być puste i musi zawierać '@'!");
                isValid = false;
            }
            else
            {
                txtBoxEmail.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxNrTel.Text) || txtBoxNrTel.Text.Length < 9)
            {
                txtBoxNrTel.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxNrTel, "Pole Numer Telefonu musi mieć równo 9 znaków!");
                isValid = false;
            }
            else
            {
                txtBoxNrTel.BackColor = SystemColors.Window;
            }

            if (GlobalClass.StanFormyPracownika.StanFormy == 1 &&
            (string.IsNullOrWhiteSpace(txtBoxHaslo.Text) ||
            txtBoxHaslo.Text.Length < 5 ||
            !txtBoxHaslo.Text.Any(char.IsDigit) ||
            !txtBoxHaslo.Text.Any(ch => !char.IsLetterOrDigit(ch))))
            {
                txtBoxHaslo.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxHaslo, "Hasło musi mieć co najmniej 5 znaków, zawierać co najmniej jedną cyfrę i jeden znak specjalny!");
                isValid = false;
            }
            else
            {
                txtBoxHaslo.BackColor = SystemColors.Window;
            }

            if (!isValid)
            {
                MessageBox.Show("Upewnij się, że wszystkie wymagane pola są poprawnie wypełnione!", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (GlobalClass.StanFormyPracownika.StanFormy == 1)
            {
                DodajPracownika();
                WyczyscPola();
                txtBoxImie.Enabled = false;
                txtBoxNazwisko.Enabled = false;
                txtBoxEmail.Enabled = false;
                txtBoxNrTel.Enabled = false;
                txtBoxLogin.Enabled = false;
                cmbBoxRola.Enabled = false;
                txtBoxHaslo.Enabled = false;
                cmbBoxNrTelPrefix.Enabled = false;
                btnResetujHaslo.Visible = false;
                btnZapisz.Visible = false;
                lblWymaganiaHasla.Visible = false;
            }
            else if (GlobalClass.StanFormyPracownika.StanFormy == 2)
            {
                EdytujPracownika();
                GlobalClass.StanFormyPracownika.StanFormy = 1;
                WyczyscPola();
                txtBoxImie.Enabled = false;
                txtBoxNazwisko.Enabled = false;
                txtBoxEmail.Enabled = false;
                txtBoxNrTel.Enabled = false;
                txtBoxLogin.Enabled = false;
                cmbBoxRola.Enabled = false;
                txtBoxHaslo.Enabled = false;
                cmbBoxNrTelPrefix.Enabled = false;
                btnResetujHaslo.Visible = false;
                btnZapisz.Visible = false;
                lblWymaganiaHasla.Visible = false;
            }
        }


        private void DodajPracownika()
        {
            AktualnyUser = new UserClass.User
            {
                first_name = txtBoxImie.Text,
                last_name = txtBoxNazwisko.Text,
                email = txtBoxEmail.Text,
                phone_number = txtBoxNrTel.Text,
                worker_login = txtBoxLogin.Text,
                password_hash = DzialaniaNaUserze.ZahashujHaslo(txtBoxHaslo.Text),
                role = cmbBoxRola.SelectedItem.ToString() == "Pracownik" ? UserClass.User.RoleEnum.worker : UserClass.User.RoleEnum.admin,
                created_at = DateTime.Now,
                modified_at = DateTime.Now,

            };

            DialogResult result = MessageBox.Show("Czy na pewno chcesz dodać użytkownika?", "Potwierdzenie dodawania", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DzialaniaNaUserze.DodajPracownika(AktualnyUser);
                WyswietlListePracownikow();
                WyczyscPola();
            }
            else
            {
                MessageBox.Show("Operacja anulowana.");
            }



        }

        private void EdytujPracownika()
        {
            AktualnyUser.first_name = GlobalneDzialania.WyczyscTekst(txtBoxImie.Text);
            AktualnyUser.last_name = GlobalneDzialania.WyczyscTekst(txtBoxNazwisko.Text);
            AktualnyUser.email = GlobalneDzialania.WyczyscTekst(txtBoxEmail.Text);
            AktualnyUser.phone_number = GlobalneDzialania.WyczyscTekst(txtBoxNrTel.Text);
            AktualnyUser.role = cmbBoxRola.SelectedItem.ToString() == "Pracownik" ? UserClass.User.RoleEnum.worker : UserClass.User.RoleEnum.admin;
            AktualnyUser.worker_login = txtBoxLogin.Text;
            AktualnyUser.password_hash = txtBoxHaslo.Text;
            AktualnyUser.modified_at = DateTime.Now;


            DialogResult result = MessageBox.Show("Czy na pewno chcesz edytować użytkownika?", "Potwierdzenie edycji", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DzialaniaNaUserze.EdytujPracownika(AktualnyUser);
                WyswietlListePracownikow();
                WyczyscPola();
            }
            else
            {
                MessageBox.Show("Operacja anulowana.");
            }


        }



        private void WyczyscPola()
        {
            txtBoxImie.Text = "";
            txtBoxNazwisko.Text = "";
            txtBoxEmail.Text = "";
            txtBoxNrTel.Text = "";
            cmbBoxRola.SelectedIndex = -1;
            cmbBoxNrTelPrefix.SelectedIndex = -1;
            txtBoxLogin.Text = "";
            txtBoxHaslo.Text = "";
            txtBoxHaslo.Enabled = true;
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            WyczyscPola();
            txtBoxImie.Enabled = false;
            txtBoxNazwisko.Enabled = false;
            txtBoxEmail.Enabled = false;
            txtBoxNrTel.Enabled = false;
            txtBoxLogin.Enabled = false;
            cmbBoxRola.Enabled = false;
            txtBoxHaslo.Enabled = false;
            cmbBoxNrTelPrefix.Enabled = false;
            btnResetujHaslo.Visible = false;
            btnZapisz.Visible = false;
            lblNaglowek.Visible = false;

            lblWymaganiaHasla.Visible = false;

            txtBoxImie.BackColor = SystemColors.Window;
            txtBoxNazwisko.BackColor = SystemColors.Window;
            txtBoxEmail.BackColor = SystemColors.Window;
            txtBoxNrTel.BackColor = SystemColors.Window;
            txtBoxHaslo.BackColor = SystemColors.Window;
        }

        private void btnResetujHaslo_Click(object sender, EventArgs e)
        {
            PobierzPracownika();
            if (AktualnyUser.user_id >= 0)
            {
                using (ResetujHasloForm resetForm = new ResetujHasloForm(AktualnyUser))
                {
                    if (resetForm.ShowDialog() == DialogResult.OK)
                    {
                        txtBoxHaslo.Text = resetForm.NoweHaslo;
                    }
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć Pracownika przed resetowaniem hasła.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonWszystko_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWszyscy.Checked)
            {
                WyswietlListePracownikow();
            }
        }

        private void radioButtonPracownicy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPracownicy.Checked)
            {
                WyswietlListePracownikow("worker");
            }
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdmin.Checked)
            {
                WyswietlListePracownikow("admin");
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            PobierzPracownika();
            lblNaglowek.Visible = false;


            DataGridViewRow selectedRow = dtGridLstPracownikow.SelectedRows[0];
            string selectedUserLogin = selectedRow.Cells["Login Pracownika"].Value.ToString();


            if (selectedUserLogin == GlobalClass.KtoZalogowany.ZalogowanyUzytkownik)
            {
                MessageBox.Show("Nie można usunąć aktualnie zalogowanego użytkownika!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DzialaniaNaUserze.UsunUzytkownika(AktualnyUser.user_id);
                WyswietlListePracownikow();
            }
            else
            {
                MessageBox.Show("Operacja anulowana.");
            }


        }

        private void txtBoxNrTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void zamówieniaToolStripMenuItem_Click(object sender, EventArgs e)
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
            ListaKontrahentowForm listaKontrahentow = new ListaKontrahentowForm();
            this.Hide();
            listaKontrahentow.ShowDialog();
        }

        private void towaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaTowary_UslugiForm listaTowary_Uslugi = new ListaTowary_UslugiForm();
            this.Hide();
            listaTowary_Uslugi.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            WyczyscPola();
            EnableFields();
            btnResetujHaslo.Visible = false;
            btnZapisz.Visible = true;
            lblNaglowek.Visible = true;
            lblNaglowek.Text = "DODAJ PRACOWNIKA";
            cmbBoxNrTelPrefix.SelectedItem = "+48";
            lblWymaganiaHasla.Visible = true;

        }

        private void EnableFields()
        {
            txtBoxImie.Enabled = true;
            txtBoxNazwisko.Enabled = true;
            txtBoxEmail.Enabled = true;
            txtBoxNrTel.Enabled = true;
            txtBoxLogin.Enabled = true;
            cmbBoxRola.Enabled = true;
            txtBoxHaslo.Enabled = true;
            cmbBoxNrTelPrefix.Enabled = true;

            txtBoxImie.BackColor = SystemColors.Window;
            txtBoxNazwisko.BackColor = SystemColors.Window;
            txtBoxEmail.BackColor = SystemColors.Window;
            txtBoxNrTel.BackColor = SystemColors.Window;
            txtBoxHaslo.BackColor = SystemColors.Window;
        }

        private void TxtBoxHaslo_TextChanged(object sender, EventArgs e)
        {
            aktualneHaslo = txtBoxHaslo.Text;
        }

        private void ImgOdszyfruj_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxHaslo.PasswordChar = '\0';
        }

        private void ImgOdszyfruj_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxHaslo.PasswordChar = '•';
        }


        private void dtGridLstPracownikow_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dtGridLstPracownikow.Columns[e.ColumnIndex].Name == "Rola")
            {
                string rola = e.Value?.ToString();

                if (rola == "admin")
                {
                    e.Value = "Administrator";
                }
                else if (rola == "worker")
                {
                    e.Value = "Pracownik";
                }
            }
        }

        private void imgMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
