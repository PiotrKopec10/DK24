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
    public partial class ListaKontrahentowForm : Form
    {

        DataTable dt = new DataTable();

        KontrahentClass.Kontrahent pobieranyKontrahent = new KontrahentClass.Kontrahent();
        KontrahentClass dzialaniaNaKontrahencie = new KontrahentClass();


        public ListaKontrahentowForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelZalogowania, this.Handle);
            GlobalClass.przesuwanieFormsa(menuStrip, this.Handle);

            GlobalClass.zapamietajPozycjeFormsa(this);
        }


        private void OpenDialog(Form dialogForm)
        {
            GlobalClass.zapiszNowaPozycjeFormsa(this);
            this.Hide();
            GlobalClass.zapamietajPozycjeFormsa(this);
            dialogForm.ShowDialog();
            this.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            GlobalClass.StanFormyKontrahenta.StanFormy = 3;
            OpenDialog(new KontrahentForm());
        }

        private void ListaKontrahentowForm_Load(object sender, EventArgs e)
        {
            WyswietlListeKontrahentow();
            lblZalogowanoJako.Text = "Zalogowano jako: " + GlobalClass.KtoZalogowany.ZalogowanyUzytkownik;
        }


        public void WyswietlListeKontrahentow()
        {
            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);
            MySqlDataAdapter AdapterPolaczenia = new MySqlDataAdapter();

            dt.Clear();



            try
            {
                polaczenie.Open();


                string SelectDanych = "SELECT company_details_id, name AS 'Nazwa Kontrahenta', acronym AS 'Akronim', nip AS 'NIP', regon AS 'Regon', " +
                                      "CONCAT(phone_prefix, ' ', phone_number) AS 'Numer telefonu', is_archived AS 'Archiwalny' " +
                                      "FROM serwer197774_drukarnia.company_details";

                using (MySqlCommand wyswietlDane = new MySqlCommand(SelectDanych, polaczenie))
                {
                    AdapterPolaczenia = new MySqlDataAdapter(wyswietlDane);
                    AdapterPolaczenia.SelectCommand.ExecuteNonQuery();
                    AdapterPolaczenia.Fill(dt);
                    dtGridLstKnt.DataSource = dt.DefaultView;

                    dtGridLstKnt.Columns["company_details_id"].Visible = false;




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobrania danych!!! " + ex.Message, "Błąd");
            }


            polaczenie.Close();

        }



        public void PobierzKontrahenta()
        {

            if (dtGridLstKnt.RowCount != 0)
            {
                if (dtGridLstKnt.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtGridLstKnt.SelectedRows[0];


                    if (GlobalClass.KontrahentSesja.AktualnyKontrahent == null)
                    {
                        GlobalClass.KontrahentSesja.AktualnyKontrahent = new KontrahentClass.Kontrahent();
                    }

                    GlobalClass.KontrahentSesja.AktualnyKontrahent.company_details_id = Convert.ToInt32(selectedRow.Cells["company_details_id"].Value);


                }
                else
                {
                    MessageBox.Show("Proszę zaznaczyć Kontrahenta.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }


        }



        private void btnZaznacz_Click(object sender, EventArgs e)
        {
            PobierzKontrahenta();

            GlobalClass.StanFormyKontrahenta.StanFormy = 1;

            KontrahentForm kontrahentForm = new KontrahentForm();
            this.Hide();
            kontrahentForm.ShowDialog();



        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {

            PobierzKontrahenta();

            GlobalClass.StanFormyKontrahenta.StanFormy = 2;
            this.Hide();
            KontrahentForm kontrahentForm = new KontrahentForm();
            kontrahentForm.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void zamówieniaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenDialog(new MainForm());
        }

        private void dodajToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenDialog(new DokumentForm());
        }

        private void zobaczFakturyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenDialog(new ListaFakturForm());
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            PobierzKontrahenta();

            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć kontrahenta?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dzialaniaNaKontrahencie.UsunKontrahenta(GlobalClass.KontrahentSesja.AktualnyKontrahent.company_details_id);
                WyswietlListeKontrahentow();
            }
            else
            {            
                MessageBox.Show("Operacja anulowana.");
            }

        }
    }
}
