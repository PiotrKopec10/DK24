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
            PobierzPracownika();

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
                txtBoxHaslo.Enabled = true;
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

            if (!string.IsNullOrEmpty(txtBoxImie.Text) &&
        !string.IsNullOrEmpty(txtBoxNazwisko.Text) &&
        !string.IsNullOrEmpty(txtBoxEmail.Text) &&
        !string.IsNullOrEmpty(txtBoxNrTel.Text) && txtBoxNrTel.Text.Length > 8 &&
        !string.IsNullOrEmpty(txtBoxLogin.Text) &&
        !string.IsNullOrEmpty(txtBoxHaslo.Text) &&
        !string.IsNullOrEmpty(cmbBoxRola.Text) &&
        !string.IsNullOrEmpty(cmbBoxNrTelPrefix.Text))
            {

                if (GlobalClass.StanFormyPracownika.StanFormy == 1)
                {
                    DodajPracownika();
                }
                else if (GlobalClass.StanFormyPracownika.StanFormy == 2)
                {
                    EdytujPracownika();
                    GlobalClass.StanFormyPracownika.StanFormy = 1;
                }

            }
            else
            {

                MessageBox.Show("Upewnij się, że wszystkie pola są wypełnione!!!.");
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
            btnResetujHaslo.Visible = false;
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
    }
}
