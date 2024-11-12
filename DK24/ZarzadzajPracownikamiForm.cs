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
    }
}
