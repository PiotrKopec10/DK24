using DK24.Klasy;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DK24
{
    public partial class ListaFakturForm : Form
    {
        UserClass DzialaniaNaUserze = new UserClass();
        public ListaFakturForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelZalogowania, this.Handle);
            GlobalClass.przesuwanieFormsa(menuStrip, this.Handle);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }


        private void WypelnijListeFaktur()
        {
            string query = @"SELECT 
                            i.invoice_id,
                            i.invoice_number AS 'Numer Faktury',
                            i.issue_date AS 'Data Wystawienia',
                            i.total_amount AS 'Cena Końcowa',
                            i.created_at,
                            cd.name AS 'Nazwa Kontrahenta',
                            CASE 
                               WHEN ad.address_id IS NOT NULL THEN 
                                   CONCAT(ad.street, ' ', ad.house_number, 
                                          IF(ad.apartment_number IS NOT NULL AND ad.apartment_number != '', 
                                             CONCAT('/', ad.apartment_number), ''), 
                                          ', ', ad.postal_code, ' ', ad.city)
                               ELSE 'Brak adresu'
                            END AS 'Adres'
                        FROM invoices AS i
                        LEFT JOIN orders AS o ON i.order_order_id = o.order_id
                        LEFT JOIN company_details AS cd ON o.number_nip = cd.nip
                        LEFT JOIN addresses AS ad ON i.billing_address_id = ad.address_id
                        ORDER BY i.created_at DESC;
                            ";

            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            dtGridLstFakt.DataSource = dt;

            if (dtGridLstFakt.Columns["invoice_id"] != null)
            {
                dtGridLstFakt.Columns["invoice_id"].Visible = false;
            }

            if (dtGridLstFakt.Columns["created_at"] != null)
            {
                dtGridLstFakt.Columns["created_at"].Visible = false;
            }

            dtGridLstFakt.Columns["Numer Faktury"].DisplayIndex = 0;
            dtGridLstFakt.Columns["Nazwa Kontrahenta"].DisplayIndex = 1;
            dtGridLstFakt.Columns["Adres"].DisplayIndex = 2;
            dtGridLstFakt.Columns["Data Wystawienia"].DisplayIndex = 3;
            dtGridLstFakt.Columns["Cena Końcowa"].DisplayIndex = 4;



            dtGridLstFakt.Columns["Numer Faktury"].Width = 150;
            dtGridLstFakt.Columns["Data Wystawienia"].Width = 100;
            dtGridLstFakt.Columns["Cena Końcowa"].Width = 100;
            dtGridLstFakt.Columns["Nazwa Kontrahenta"].Width = 200;
            dtGridLstFakt.Columns["Adres"].Width = 300;
        }



        private void ListaFakturForm_Load(object sender, EventArgs e)
        {
            lblZalogowanoJako.Text = "Zalogowano jako: " + GlobalClass.KtoZalogowany.ZalogowanyUzytkownik;
            WypelnijListeFaktur();

            if (DzialaniaNaUserze.SprawdzCzyAdmin(GlobalClass.KtoZalogowany.ZalogowanyUzytkownik) == false)
            {

                ZarzadzajPracownikamiToolStripMenuItem.Visible = false;


            }
            else ZarzadzajPracownikamiToolStripMenuItem.Visible = true;
        }

        private void zamówieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
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
            DokumentForm dokumentForm = new DokumentForm();
            this.Hide();
            dokumentForm.ShowDialog();
        }

        private void btnZaznacz_Click(object sender, EventArgs e)
        {
            PobierzNumerFaktury();
            PobierzIZapiszPdfNaPulpit(GlobalClass.ListaFakturSesja.ZaznaczonaFaktura.invoice_id, GlobalClass.ListaFakturSesja.ZaznaczonaFaktura.invoice_number);
        }



        public void PobierzNumerFaktury()
        {

            if (dtGridLstFakt.RowCount != 0)
            {
                if (dtGridLstFakt.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtGridLstFakt.SelectedRows[0];


                    if (GlobalClass.ListaFakturSesja.ZaznaczonaFaktura == null)
                    {
                        GlobalClass.ListaFakturSesja.ZaznaczonaFaktura = new FakturaClass();
                    }

                    GlobalClass.ListaFakturSesja.ZaznaczonaFaktura.invoice_id = Convert.ToInt32(selectedRow.Cells["invoice_id"].Value);
                    GlobalClass.ListaFakturSesja.ZaznaczonaFaktura.invoice_number = Convert.ToString(selectedRow.Cells["Numer Faktury"].Value);


                }
                else
                {
                    MessageBox.Show("Proszę zaznaczyć Fakture.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }



        }



        public void PobierzIZapiszPdfNaPulpit(int invoiceId, string invoiceNumber)
        {
            using (MySqlConnection conn = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie))
            {
                conn.Open();
                string sql = @"
            SELECT pdf_data
            FROM invoices
            WHERE invoice_id = @InvoiceId
            LIMIT 1;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        byte[] pdfBytes = (byte[])result;

                        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string folderPath = Path.Combine(desktopPath, "Wystawione_faktury");

                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        string fileName = $"Wystawiona_faktura_NR{invoiceNumber}.pdf";
                        string finalPath = Path.Combine(folderPath, fileName);

                        File.WriteAllBytes(finalPath, pdfBytes);

                        MessageBox.Show($"PDF został zapisany w lokalizacji: {desktopPath}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Brak pliku PDF w bazie dla tej faktury.", "Informacja");
                    }
                }
            }
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void imgMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ZarzadzajPracownikamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZarzadzajPracownikamiForm zarzadzajPracownikami = new ZarzadzajPracownikamiForm();
            this.Hide();
            zarzadzajPracownikami.ShowDialog();
        }
    }
}
