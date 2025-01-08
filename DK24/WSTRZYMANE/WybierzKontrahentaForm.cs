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
    public partial class WybierzKontrahentaForm : Form
    {

        DataTable dt = new DataTable();

        KontrahentClass.Kontrahent pobieranyKontrahent = new KontrahentClass.Kontrahent();
        KontrahentClass dzialaniaNaKontrahencie = new KontrahentClass();

        public WybierzKontrahentaForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelGorny, this.Handle);
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void WybierzKontrahentaForm_Load(object sender, EventArgs e)
        {
            WyswietlListeKontrahentow();
        }


        public void WyswietlListeKontrahentow()
        {
            MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie);
            MySqlDataAdapter AdapterPolaczenia = new MySqlDataAdapter();

            dt.Clear();



            try
            {
                polaczenie.Open();


                string SelectDanych = "SELECT company_details_id, name AS 'Nazwa Kontrahenta', acronym AS 'Akronim', nip AS 'NIP' "+
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
            

            DialogResult result = MessageBox.Show("Czy na pewno chcesz wybrać tego kontrahenta?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                GlobalClass.StanFormyFaktury.StanFormy = 1;
                this.Hide();

            }
            else
            {
                GlobalClass.StanFormyFaktury.StanFormy = 0;
                this.Hide();
            }


        }
    }
}
