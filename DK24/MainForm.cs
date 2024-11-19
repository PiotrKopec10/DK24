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
    public partial class MainForm : Form
    {
        string PolaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;
        ZamowieniaClass.Orders PobieraneZamowienie = new ZamowieniaClass.Orders();
        ZamowieniaClass DzialaniaNaZamowieniach = new ZamowieniaClass();
        AddressClass.Address PobieranyAdres = new AddressClass.Address();
        AddressClass DzialanieNaAdresie = new AddressClass();


        public MainForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelZalogowania, this.Handle);
            GlobalClass.przesuwanieFormsa(menuStrip, this.Handle);

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            


            DataTable zamowieniaZDetalami = PobierzZamowieniaZDetalami();


            dtGridViewZamowienia.DataSource = zamowieniaZDetalami;




            lblZalogowanoJako.Text = "Zalogowano jako: " + GlobalClass.KtoZalogowany.ZalogowanyUzytkownik;


        }


        public DataTable PobierzZamowieniaZDetalami()
        {
            string query = @"SELECT 
        o.order_id,
        o.total_price,
        o.status,
        o.created_at,
        COALESCE(cd.name, CONCAT(u.first_name, ' ', u.last_name)) AS customer_name,
        COALESCE(cd.email, u.email) AS email,
        COALESCE(cd.phone_number, u.phone_number) AS phone_number,
        COALESCE(
            CONCAT(a.street, ' ', a.house_number, 
                   IF(a.apartment_number IS NOT NULL AND a.apartment_number != '', CONCAT('/', a.apartment_number), ''), 
                   ', ', a.city, ', ', a.country), 
            'Odbiór osobisty'
        ) AS full_address
    FROM 
        orders o
    INNER JOIN 
        users u ON o.user_id = u.user_id
    LEFT JOIN 
        company_details cd ON u.user_id = cd.user_id
    LEFT JOIN 
        addresses a ON o.delivery_address_id = a.address_id;";

            using (MySqlConnection conn = new MySqlConnection(PolaczenieDB))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }





        public void PobierzZamowienie()
        {

            if (dtGridViewZamowienia.RowCount != 0)
            {
                if (dtGridViewZamowienia.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtGridViewZamowienia.SelectedRows[0];


                    if (GlobalClass.ZamowienieSesja.AktualneZamowienie == null)
                    {
                        GlobalClass.ZamowienieSesja.AktualneZamowienie = new ZamowieniaClass.Orders();
                    }

                    GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id = Convert.ToInt32(selectedRow.Cells["order_id"].Value);


                }
                else
                {
                    MessageBox.Show("Proszę zaznaczyć Zamowienie.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }


        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PobierzZamowienie();
            SzczegolyZamowieniaForm szczegolyZamowieniaForm = new SzczegolyZamowieniaForm();
            this.Hide();
            szczegolyZamowieniaForm.ShowDialog();
        }


        private void fakturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaFakturForm listaFakturForm = new ListaFakturForm();
            this.Hide();
            listaFakturForm.ShowDialog();
        }

        private void kontrahenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaKontrahentowForm listaKontrahentowForm = new ListaKontrahentowForm();
            this.Hide();
            listaKontrahentowForm.ShowDialog();
        }

        private void wysyłkiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void towaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaTowary_UslugiForm listaTowary_Uslugi = new ListaTowary_UslugiForm();
            this.Hide();
            listaTowary_Uslugi.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //WyborKlient_KontrahentZamowienieForm wyborKlient_KontrahentZamowienieForm = new WyborKlient_KontrahentZamowienieForm();
            //this.Hide();
            //wyborKlient_KontrahentZamowienieForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable zamowieniaZDetalami = PobierzZamowieniaZDetalami();


            dtGridViewZamowienia.DataSource = zamowieniaZDetalami;

        }

        private void ądzajPracownikamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZarzadzajPracownikamiForm zarzadzajPracownikami = new ZarzadzajPracownikamiForm();
            this.Hide();
            zarzadzajPracownikami.ShowDialog();
        }
    }
}
