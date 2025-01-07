using DK24.Klasy;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static DK24.Klasy.AddressClass;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DK24
{
    public partial class SzczegolyZamowieniaForm : Form
    {
        ZamowieniaClass.Orders Zamowienia = new ZamowieniaClass.Orders();
        ZamowieniaClass DzialanieNaZamowieniu = new ZamowieniaClass();

       

        public SzczegolyZamowieniaForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelGorny, this.Handle);
        }

        private void SzczegolyZamowieniaForm_Load(object sender, EventArgs e)
        {
            WypelnijSzczegolyZamowienia();
            DzialanieNaZamowieniu.WyswietlSzczegolyZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, dtGridViewZamowienia);



           if (cmbBoxStatusZamowienia.SelectedIndex == 5) //Anulowano
            {

                btnAnulujZamowienie.Visible = false;
                btnZakonczZamowienie.Visible = false;
                btnZakceptuj.Visible = false;
                btnWygenerujEtykiete.Enabled = false;

            }
            else if (cmbBoxStatusZamowienia.SelectedIndex == 4) //Zakończono
            {
                btnAnulujZamowienie.Visible = false;
                btnZakonczZamowienie.Visible = false;
                btnZakceptuj.Visible = false;
                btnWygenerujEtykiete.Enabled = false;



            }
            else if(cmbBoxStatusZamowienia.SelectedIndex == 3) //Gotowa Etykieta
            {

                dtPickSprzed.Visible = true;
                btnDataSprzed.Visible = true;

                btnWygenerujEtykiete.Enabled = false;
                btnZakonczZamowienie.Enabled = true;
                btnAnulujZamowienie.Enabled = false;

                
                if (chckBoxFaktura.Checked) 
                {
                    btnFaktura.Enabled = false;
                    btnFaktura.Visible = true;
                }
                else 
                {
                    btnFaktura.Visible = false;
                }


            }
            else if (cmbBoxStatusZamowienia.SelectedIndex == 2) // Gotowa Faktura
            {
                dtPickSprzed.Visible = true;
                btnDataSprzed.Visible = true;

                btnWygenerujEtykiete.Enabled = true;
                btnAnulujZamowienie.Enabled = false;
                btnFaktura.Enabled = false;
                btnFaktura.Visible = true;

            }
            else if (cmbBoxStatusZamowienia.SelectedIndex == 1) //W przygotwaniu
            {
                dtPickSprzed.Visible = false;
                btnDataSprzed.Visible = false;
                btnZakonczZamowienie.Enabled = false;
                //btnWygenerujEtykiete.Enabled = false;              
            }
            else if (cmbBoxStatusZamowienia.SelectedIndex == 0) //Nowe
            {
                btnDataSprzed.Visible = false;
                dtPickSprzed.Visible = false;

                btnZakceptuj.Enabled = true;
                btnAnulujZamowienie.Enabled = true;
                btnZakonczZamowienie.Enabled = false;
                btnWygenerujEtykiete.Enabled = false;

            }

            WypelnijSzczegolyZamowienia();

        }

        private void WypelnijSzczegolyZamowienia()
        {
            string query = @"
        SELECT 
            o.order_id,
            o.total_price,
            o.status,
            o.created_at,
            o.modified_at,
            o.shipping_method,
            o.user_id,          
            o.is_invoice,
            o.delivery_address_id,
            COALESCE(cd.name, CONCAT(u.first_name, ' ', u.last_name)) AS customer_name,
            COALESCE(cd.email, u.email) AS email,
            COALESCE(cd.phone_number, u.phone_number) AS phone_number,
            CASE 
                WHEN o.delivery_address_id IS NULL THEN 'Odbiór osobisty'
                ELSE CONCAT(a.street, ' ', a.house_number, 
                            IF(a.apartment_number IS NOT NULL AND a.apartment_number != '', 
                               CONCAT('/', a.apartment_number), ''), 
                            ', ', a.city, ', ', a.country)
            END AS full_address
        FROM 
            orders o
        INNER JOIN 
            users u ON o.user_id = u.user_id
        LEFT JOIN 
            company_details cd ON u.user_id = cd.user_id
        LEFT JOIN 
            addresses a ON o.delivery_address_id = a.address_id
        WHERE 
            o.order_id = @OrderId";

            using (MySqlConnection conn = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderId", GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id);

                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {

                            if (GlobalClass.UserGlobalne.AktualnyUser == null)
                                GlobalClass.UserGlobalne.AktualnyUser = new UserClass.User();



                            if (GlobalClass.AdressGlobalne.AktualnyAddress == null)
                                GlobalClass.AdressGlobalne.AktualnyAddress = new Address();


                            if (!reader.IsDBNull(reader.GetOrdinal("user_id")))
                                GlobalClass.UserGlobalne.AktualnyUser.user_id = reader.GetInt32(reader.GetOrdinal("user_id"));
                            else
                                GlobalClass.UserGlobalne.AktualnyUser.user_id = -1;

                            if (!reader.IsDBNull(reader.GetOrdinal("delivery_address_id")))
                                GlobalClass.AdressGlobalne.AktualnyAddress.address_id = reader.GetInt32(reader.GetOrdinal("delivery_address_id"));
                            else
                                GlobalClass.AdressGlobalne.AktualnyAddress.address_id = -1;



                            //tutaj musimy to podzielic na customer name do paczki ale w name przytrymowac znaki na dole przyklad jak to zrobic w KurierForm
                            //TAK JAK MAMY TUTAJ TYLKO ZE NAME NIE MOZE BYC ZE ZNAKAMI SPECJALNYMI
                            //name = GlobalClass.OdbiorcaPaczki.NazwaKlientaDoWysylki,
                            // company = GlobalClass.OdbiorcaPaczki.NazwaKlientaDoWysylki,  

                            //if (!reader.IsDBNull(reader.GetOrdinal("customer_name")))
                            //    GlobalClass.OdbiorcaPaczki.NazwaKlientaDoWysylki = reader.GetString(reader.GetOrdinal("customer_name"));
                            //else
                            //    GlobalClass.OdbiorcaPaczki.NazwaKlientaDoWysylki = "Nie Znaleziono";

                            if (!reader.IsDBNull(reader.GetOrdinal("customer_name")))
                            {
                                string rawCustomerName = reader.GetString(reader.GetOrdinal("customer_name"));
                                // Usunięcie znaków specjalnych
                                string filteredCustomerName = Regex.Replace(rawCustomerName, @"[^a-zA-Z0-9\s]", "");
                                GlobalClass.OdbiorcaPaczki.NazwaKlientaDoWysylki = filteredCustomerName;
                            }
                            else
                            {
                                GlobalClass.OdbiorcaPaczki.NazwaKlientaDoWysylki = "Nie Znaleziono";
                            }


                            if (!reader.IsDBNull(reader.GetOrdinal("is_invoice")))
                            {
                                int isInvoice = reader.GetInt32(reader.GetOrdinal("is_invoice")); 
                                if (isInvoice == 1)
                                {
                                    chckBoxFaktura.Checked = true; 
                                }
                                else
                                {
                                    chckBoxFaktura.Checked = false; 
                                }
                            }
                            else
                            {
                                chckBoxFaktura.Checked = false; 
                            }


                            lblNrZamowienia.Text = GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id.ToString();



                            lblCenaNetto.Text = reader.IsDBNull(reader.GetOrdinal("total_price"))
                                                ? "0.00"
                                                : reader["total_price"].ToString();



                            txtBoxNazwaKlienta.Text = reader.IsDBNull(reader.GetOrdinal("customer_name"))
                                                      ? "Nieznany klient"
                                                      : reader["customer_name"].ToString();

                            txtBoxAdres.Text = reader.IsDBNull(reader.GetOrdinal("full_address"))
                                               ? "Odbiór osobisty"
                                               : reader["full_address"].ToString();



                            //                            GlobalClass.AdressGlobalne.AktualnyAddress.fullAddres = txtBoxAdres.Text;



                            dtPickDataWystaw.Value = reader.IsDBNull(reader.GetOrdinal("created_at"))
                                                     ? DateTime.Now
                                                     : Convert.ToDateTime(reader["created_at"]);

                            dtPickSprzed.Value = reader.IsDBNull(reader.GetOrdinal("modified_at"))
                                         ? DateTime.Now
                                         : Convert.ToDateTime(reader["modified_at"]);


                            string shippingMethod = reader.IsDBNull(reader.GetOrdinal("shipping_method"))
                                                    ? "self_pickup"
                                                    : reader["shipping_method"].ToString();

                            if (shippingMethod == "self_pickup")
                            {
                                chckBoxOdbior.Checked = true;
                                chckBoxWysylka.Checked = false;
                                chckBoxWysylka.Enabled = false;
                                btnWygenerujEtykiete.Visible = false;
                            }
                            if (shippingMethod == "dhl")
                            {
                                chckBoxOdbior.Checked = false;
                                chckBoxOdbior.Enabled = false;
                                chckBoxWysylka.Checked = true;
                                btnWygenerujEtykiete.Visible = true;
                            }

                            string status = reader.IsDBNull(reader.GetOrdinal("status"))
                                    ? "newOrder"
                                    : reader["status"].ToString();

                            if (status == "created")
                            {
                                cmbBoxStatusZamowienia.SelectedIndex = 0;



                                btnDataSprzed.Visible = false;
                                dtPickSprzed.Visible = false;

                                btnZakceptuj.Enabled = true;
                                btnAnulujZamowienie.Enabled = true;
                                btnZakonczZamowienie.Enabled = false;
                                btnWygenerujEtykiete.Enabled = false;

                             

                            }
                            else if (status == "in_progress")
                            {
                                cmbBoxStatusZamowienia.SelectedIndex = 1;



                                if (DzialanieNaZamowieniu.PobierzCzyFakturaPoIdZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id) == true)
                                {

                                    btnFaktura.Visible = true;
                                    btnWygenerujEtykiete.Enabled = false;
                                    btnZakceptuj.Enabled = false;
                                    btnAnulujZamowienie.Enabled = false;
                                }
                                else
                                {
                                  
                                    if (shippingMethod == "dhl")
                                    {
                                        btnZakonczZamowienie.Enabled = false;

                                        btnFaktura.Visible = false;
                                        btnWygenerujEtykiete.Enabled = true;
                                        btnZakceptuj.Enabled = false;
                                        btnAnulujZamowienie.Enabled = false;

                                    }
                                    else
                                    {
                                        btnZakonczZamowienie.Enabled = true;

                                        btnFaktura.Visible = false;
                                        btnZakceptuj.Enabled = false;
                                        btnAnulujZamowienie.Enabled = false;
                                        btnWygenerujEtykiete.Enabled = false;

                                    }

                                }


                            }
                            else if (status == "invoice_ready")
                            {

                                cmbBoxStatusZamowienia.SelectedIndex = 2;
                                //btnZakceptuj.Enabled = false;
                                //btnZakonczZamowienie.Enabled = true;
                                //btnAnulujZamowienie.Enabled = false;



                                if (shippingMethod == "dhl")
                                {
                                    btnZakonczZamowienie.Enabled = false;

                                    btnFaktura.Visible = false;
                                    btnWygenerujEtykiete.Enabled = true;
                                    btnZakceptuj.Enabled = false;
                                    btnAnulujZamowienie.Enabled = false;

                                }
                                else
                                {
                                    btnZakonczZamowienie.Enabled = true;

                                    btnFaktura.Visible = false;
                                    btnZakceptuj.Enabled = false;
                                    btnAnulujZamowienie.Enabled = false;
                                    btnWygenerujEtykiete.Enabled = false;

                                }


                            }
                            else if(status == "label_ready") 
                            {

                                cmbBoxStatusZamowienia.SelectedIndex = 3;
                                btnWygenerujEtykiete.Enabled = false;

                                btnZakonczZamowienie.Enabled = true;

                                btnAnulujZamowienie.Enabled = false;
                                btnZakceptuj.Enabled = false;
                            }
                            

                            else if (status == "completed")
                            {
                                cmbBoxStatusZamowienia.SelectedIndex = 4;
                                btnZakonczZamowienie.Enabled = false;
                                btnZakceptuj.Enabled = false;
                                btnAnulujZamowienie.Enabled = false;



                            }
                            else if (status == "canceled")
                            {
                                cmbBoxStatusZamowienia.SelectedIndex = 5;
                                btnZakonczZamowienie.Enabled = false;
                                btnZakceptuj.Enabled = false;
                            }

                            if (!string.IsNullOrWhiteSpace(lblCenaNetto.Text))
                            {

                                lblCenaBrutto.Text = ObliczBrutto(Convert.ToDecimal(lblCenaNetto.Text)).ToString("F2");

                            }


                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono zamówienia o podanym ID.",
                                            "Błąd",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania szczegółów zamówienia: " + ex.Message,
                                    "Błąd",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }


        public decimal ObliczBrutto(decimal kwotaNetto)
        {
            decimal stawkaVAT = 0.23m;
            decimal kwotaBrutto = kwotaNetto * (1 + stawkaVAT);
            return kwotaBrutto;
        }






        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }





        private void btnZakceptuj_Click(object sender, EventArgs e)
        {



            DzialanieNaZamowieniu.EdytujStatusZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, "in_progress", "W przygotowaniu", "");



            btnZakonczZamowienie.Enabled = false;

            btnWygenerujEtykiete.Enabled = false;

            WypelnijSzczegolyZamowienia();





        }

        private void btnZakonczZamowienie_Click(object sender, EventArgs e)
        {
            DzialanieNaZamowieniu.EdytujStatusZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, "completed", "Zakończone", "");

            btnWygenerujEtykiete.Enabled = false;

            dtPickSprzed.Visible = true;
            btnDataSprzed.Visible = true;

            WypelnijSzczegolyZamowienia();

        }

        private void btnAnulujZamowienie_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Czy na pewno chcesz anulować zamówienie?", "Potwierdzenie anulowania", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DzialanieNaZamowieniu.EdytujStatusZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, "canceled", "Anulowane", "");

                WypelnijSzczegolyZamowienia();

                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
            }




        }

        private void btnWygenerujEtykiete_Click_1(object sender, EventArgs e)
        {
           

            KurierForm dHLForm = new KurierForm();
            dHLForm.ShowDialog();



        }

        private void btnFaktura_Click(object sender, EventArgs e)
        {
            DokumentForm dokumentForm = new DokumentForm();
            this.Hide();
            dokumentForm.ShowDialog();
           


        }
    }
}
