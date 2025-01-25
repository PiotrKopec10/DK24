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
        UserClass DzialaniaNaUserze = new UserClass();


        private System.Windows.Forms.Timer refreshTimer;
        private int odliczanie = 31;



        public MainForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelZalogowania, this.Handle);
            GlobalClass.przesuwanieFormsa(menuStrip, this.Handle);

            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 1000;
            refreshTimer.Tick += RefreshTimer_Tick;

            cbxNowe.CheckedChanged += CheckBox_CheckedChanged;
            cbxWrealizacji.CheckedChanged += CheckBox_CheckedChanged;
            cbxZakonczone.CheckedChanged += CheckBox_CheckedChanged;

            dtGridViewZamowienia.RowPrePaint += DtGridViewZamowienia_WierszAnulowano;

        }



        private void MainForm_Load(object sender, EventArgs e)
        {

            DataTable zamowieniaZDetalami = PobierzZamowieniaZDetalami();

            dtGridViewZamowienia.DataSource = zamowieniaZDetalami;
            lblZalogowanoJako.Text = "Zalogowano jako: " + GlobalClass.KtoZalogowany.ZalogowanyUzytkownik;


            if(DzialaniaNaUserze.SprawdzCzyAdmin(GlobalClass.KtoZalogowany.ZalogowanyUzytkownik)==false)
            {
                
                ZarzadzajPracownikamiToolStripMenuItem.Visible = false;


            }else ZarzadzajPracownikamiToolStripMenuItem.Visible = true;







            odliczanie = 30;
            lblRefreshTimeLeft.Text = $"({odliczanie} s)";
            refreshTimer.Start();

        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            odliczanie--;
            lblRefreshTimeLeft.Text = $"({odliczanie} s)";

            if (odliczanie == 0)
            {
                DataTable zamowieniaZDetalami = PobierzZamowieniaZDetalami();
                dtGridViewZamowienia.DataSource = zamowieniaZDetalami;

                odliczanie = 31;
            }
        }


        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cbxNowe.CheckedChanged -= CheckBox_CheckedChanged;
            cbxWrealizacji.CheckedChanged -= CheckBox_CheckedChanged;
            cbxZakonczone.CheckedChanged -= CheckBox_CheckedChanged;

            if (sender == cbxNowe)
            {
                cbxWrealizacji.Checked = false;
                cbxZakonczone.Checked = false;
            }
            else if (sender == cbxWrealizacji)
            {
                cbxNowe.Checked = false;
                cbxZakonczone.Checked = false;
            }
            else if (sender == cbxZakonczone)
            {
                cbxNowe.Checked = false;
                cbxWrealizacji.Checked = false;
            }

            cbxNowe.CheckedChanged += CheckBox_CheckedChanged;
            cbxWrealizacji.CheckedChanged += CheckBox_CheckedChanged;
            cbxZakonczone.CheckedChanged += CheckBox_CheckedChanged;

            string[] filtrStatus = null;

            if (cbxNowe.Checked)
            {
                filtrStatus = new[] { "created" };
            }
            else if (cbxWrealizacji.Checked)
            {
                filtrStatus = new[] { "in_progress", "invoice_ready", "label_ready" };
            }
            else if (cbxZakonczone.Checked)
            {
                filtrStatus = new[] { "completed", "canceled" };
            }

            DataTable zamowieniaZDetalami = PobierzZamowieniaZDetalami(filtrStatus);
            dtGridViewZamowienia.DataSource = zamowieniaZDetalami;

            odliczanie = 30;
            lblRefreshTimeLeft.Text = $"({odliczanie} s)";
            refreshTimer.Start();
        }



        public DataTable PobierzZamowieniaZDetalami(string[] statuses = null)
        {
            string query = @"SELECT 
             o.order_id AS 'Numer Zamówienia', 
             CONCAT(u.first_name, ' ', u.last_name) AS 'Klient', 
             u.phone_number AS 'Numer Telefonu', 
             u.email AS 'Email', 
             cd.name AS 'Firma', 
             o.number_nip AS 'NIP', 
             o.status AS 'Status',
             o.created_at AS 'Data Utworzenia',
             o.total_price AS 'Cena',
             COALESCE(
                 CONCAT(a.street, ' ', a.house_number, 
                        IF(a.apartment_number IS NOT NULL AND a.apartment_number != '', CONCAT('/', a.apartment_number), ''), 
                        ', ', a.city, ', ', a.country), 
                 'Odbiór osobisty'
             ) AS 'Sposób odbioru'
         FROM 
             orders o
         INNER JOIN 
             users u ON o.user_id = u.user_id
         LEFT JOIN 
             company_details cd ON o.number_nip = cd.nip 
         LEFT JOIN 
             addresses a ON o.delivery_address_id = a.address_id";

            if (statuses != null && statuses.Length > 0)
            {
                query += " WHERE o.status IN (" + string.Join(", ", statuses.Select((s, i) => $"@status{i}")) + ")";
            }

            query += " ORDER BY o.created_at DESC;";

            using (MySqlConnection conn = new MySqlConnection(PolaczenieDB))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (statuses != null && statuses.Length > 0)
                {
                    for (int i = 0; i < statuses.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@status{i}", statuses[i]);
                    }
                }

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

                    GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id = Convert.ToInt32(selectedRow.Cells["Numer Zamówienia"].Value);


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
            cbxNowe.Checked = false;
            cbxWrealizacji.Checked = false;
            cbxZakonczone.Checked = false;

            DataTable zamowieniaZDetalami = PobierzZamowieniaZDetalami();
            dtGridViewZamowienia.DataSource = zamowieniaZDetalami;

            odliczanie = 30;
            lblRefreshTimeLeft.Text = $"({odliczanie} s)";
            refreshTimer.Start();

        }

        private void ądzajPracownikamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZarzadzajPracownikamiForm zarzadzajPracownikami = new ZarzadzajPracownikamiForm();
            this.Hide();
            zarzadzajPracownikami.ShowDialog();
        }

        private void DtGridViewZamowienia_WierszAnulowano(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (cbxZakonczone.Checked)
            {
                if (dtGridViewZamowienia.Rows[e.RowIndex].DataBoundItem is DataRowView rowView)
                {
                    string status = rowView["status"].ToString();

                    if (status == "canceled")
                    {
                        dtGridViewZamowienia.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KurierForm dHLForm = new KurierForm();
            this.Hide();
            dHLForm.ShowDialog();
        }

      
        private void dtGridViewZamowienia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dtGridViewZamowienia.Columns[e.ColumnIndex].Name == "Status")
            {
                string status = e.Value?.ToString();

                if (status == "created")
                {
                    e.Value = "Nowe";
                }
                else if (status == "in_progress")
                {
                    e.Value = "W realizacji";
                }
                else if (status == "invoice_ready")
                {
                    e.Value = "Gotowa faktura";
                }
                else if (status == "label_ready")
                {
                    e.Value = "Gotowa etykieta";
                }
                else if (status == "canceled")
                {
                    e.Value = "Anulowano";
                }
                else if (status == "completed")
                {
                    e.Value = "Ukończone";
                }
             
                if (status == "canceled")
                {
                    dtGridViewZamowienia.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else if (status == "label_ready")
                {
                    dtGridViewZamowienia.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                }
                else if (status == "invoice_ready")
                {
                    dtGridViewZamowienia.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                }
            }
        }


    }
}
