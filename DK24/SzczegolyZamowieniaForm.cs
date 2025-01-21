using DK24.Klasy;
using MySql.Data.MySqlClient;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System.Text.RegularExpressions;
using static DK24.Klasy.AddressClass;

namespace DK24
{
    public partial class SzczegolyZamowieniaForm : Form
    {
        ZamowieniaClass.Orders Zamowienia = new ZamowieniaClass.Orders();
        ZamowieniaClass DzialanieNaZamowieniu = new ZamowieniaClass();
        string PolaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;

        FakturaClass DzialaniaNaFakturze = new FakturaClass();


        public SzczegolyZamowieniaForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelGorny, this.Handle);

            QuestPDF.Settings.License = LicenseType.Community;

            btnCopy.Click += BtnCopy_Click;
        }

        private void SzczegolyZamowieniaForm_Load(object sender, EventArgs e)
        {
            WypelnijSzczegolyZamowienia();
            DzialanieNaZamowieniu.WyswietlSzczegolyZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, dtGridViewZamowienia);

            //OPCJONALNIE
            // Dodać moduł do blokowania guzików przed Pobraniem plików jeśli są
            // Dodać textboxa o informacji dlaczego anulowano zamówienie

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
            else if (cmbBoxStatusZamowienia.SelectedIndex == 3) //Gotowa Etykieta
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
                //btnFaktura.Enabled = false;
                // btnFaktura.Visible = true;
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
            else if (cmbBoxStatusZamowienia.SelectedIndex == 1) //W przygotwaniu
            {
                dtPickSprzed.Visible = false;
                btnDataSprzed.Visible = false;
                btnZakonczZamowienie.Enabled = false;
                //btnWygenerujEtykiete.Enabled = false;
                btnFaktura.Enabled = true;
                if (chckBoxFaktura.Checked)
                {
                    btnFaktura.Visible = true;
                }
                else
                {
                    btnFaktura.Visible = false;
                }
            }
            else if (cmbBoxStatusZamowienia.SelectedIndex == 0) //Nowe
            {
                btnDataSprzed.Visible = false;
                dtPickSprzed.Visible = false;

                btnZakceptuj.Enabled = true;
                btnAnulujZamowienie.Enabled = true;
                btnZakonczZamowienie.Enabled = false;
                btnWygenerujEtykiete.Enabled = false;
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
            o.number_nip,
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



                            lblCenaBrutto.Text = reader.IsDBNull(reader.GetOrdinal("total_price"))
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

                            txtBoxNrNip.Text = reader.IsDBNull(reader.GetOrdinal("number_nip"))
                                     ? ""
                                     : reader["number_nip"].ToString();


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

                                    btnFaktura.Enabled = true;
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

                                    btnFaktura.Enabled = false;
                                    btnWygenerujEtykiete.Enabled = true;
                                    btnZakceptuj.Enabled = false;
                                    btnAnulujZamowienie.Enabled = false;

                                }
                                else
                                {
                                    btnZakonczZamowienie.Enabled = true;

                                    btnFaktura.Enabled = false;
                                    btnZakceptuj.Enabled = false;
                                    btnAnulujZamowienie.Enabled = false;
                                    btnWygenerujEtykiete.Enabled = false;

                                }


                            }
                            else if (status == "label_ready")
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

                            if (!string.IsNullOrWhiteSpace(lblCenaBrutto.Text))
                            {

                                lblCenaNetto.Text = ObliczNetto(Convert.ToDecimal(lblCenaBrutto.Text)).ToString("F2");

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


        public decimal ObliczNetto(decimal kwotaNetto)
        {
            decimal stawkaVAT = 0.23m;
            decimal kwotaBrutto = kwotaNetto * (1 - stawkaVAT);
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


            try 
            {

            }
            catch 
            { 
            
            }

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
            this.Hide();
            dHLForm.ShowDialog();
        }






        private List<(string Item, int Quantity, decimal PriceBrutto, decimal PriceNetto)> PobierzPozycjeZamowienia(int orderId)
        {
            var lista = new List<(string Item, int Quantity, decimal PriceBrutto, decimal PriceNetto)>();

            string zapytanie = @"
                   SELECT
                i.item_id,
                i.name AS Produkt,
                GROUP_CONCAT(
                    CONCAT(og.title, ': ', op.name)
                    ORDER BY og.option_group_id SEPARATOR ' | '
                ) AS Opcje,
                i.quantity AS 'Ilość',
                i.price AS 'Cena'
            FROM serwer197774_drukarnia.items AS i
            LEFT JOIN serwer197774_drukarnia.item_options AS io
                   ON i.item_id = io.item_id
            LEFT JOIN serwer197774_drukarnia.options AS op
                   ON io.option_id = op.option_id
            LEFT JOIN serwer197774_drukarnia.option_groups AS og
                   ON op.option_group_id = og.option_group_id
            WHERE i.order_id = @orderId
            GROUP BY
                i.item_id,     
                i.name,
                i.quantity,
                i.price
            ORDER BY i.name;
            ";

            using (MySqlConnection con = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(zapytanie, con))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nazwa = reader["Produkt"] != DBNull.Value ? reader["Produkt"].ToString() : "";
                            string opcje = reader["Opcje"] != DBNull.Value ? reader["Opcje"].ToString() : "";
                            int ilosc = Convert.ToInt32(reader["Ilość"]);
                            decimal cena = Convert.ToDecimal(reader["Cena"]);
                            string nazwaZOpcjami = string.IsNullOrWhiteSpace(opcje)
                                ? nazwa
                                : $"{nazwa} ({opcje})";
                            lista.Add((nazwaZOpcjami, ilosc, cena , cena * 1.23m));
                        }
                    }
                }
            }

            return lista;
        }




        public string PobierzEmailUseraPoOrderId(int orderId)
        {
            string emailUzytkownika = "";
            using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string sql = @"
                SELECT u.email 
                FROM orders o
                INNER JOIN users u ON o.user_id = u.user_id
                WHERE o.order_id = @OrderId
                LIMIT 1;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, polaczenie))
                    {
                        cmd.Parameters.AddWithValue("@OrderId", orderId);
                        object wynik = cmd.ExecuteScalar();

                        if (wynik != null && wynik != DBNull.Value)
                        {
                            emailUzytkownika = wynik.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania e-maila użytkownika: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }
            return emailUzytkownika;
        }






        private void btnFaktura_Click(object sender, EventArgs e)
        {
            if (!DzialaniaNaFakturze.CzyNipZOrdersJestWBazieCompanyDetails(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id))
            {

                if (GlobalClass.EmailSesja.AktualnyEmail == null)
                {
                    GlobalClass.EmailSesja.AktualnyEmail = new UserClass.User();
                }

                if (GlobalClass.KontrahentNIP.AktualnyNIP == null)
                {
                    GlobalClass.KontrahentNIP.AktualnyNIP = new KontrahentClass.Kontrahent();
                }


                GlobalClass.EmailSesja.AktualnyEmail.email = PobierzEmailUseraPoOrderId(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id); 

                if(txtBoxNrNip.Text.Length != 0) 
                {
                    GlobalClass.KontrahentNIP.AktualnyNIP.nip = txtBoxNrNip.Text;

                }

                

                MessageBox.Show($"Brak kontrahenta w bazie, dodaj go!\nDodaj go używając numeru NIP: {txtBoxNrNip.Text} i maila: {GlobalClass.EmailSesja.AktualnyEmail.email}", "Dodaj Kontrahenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtBoxNrNip.Text.Length != 0)
                {
                    KontrahentForm kontrahentForm = new KontrahentForm();

                    GlobalClass.StanFormyKontrahenta.StanFormy = 4;

                    this.Hide();
                    kontrahentForm.ShowDialog();
                    return;
                }
                else
                {
                    KontrahentForm kontrahentForm = new KontrahentForm();
                    this.Hide();
                    kontrahentForm.ShowDialog();
                    return;
                }
            }
            bool bazaOK = false;
            try
            {
                FakturaClass DaneDoFaktury = DzialaniaNaFakturze.PobierzPotrzebneDaneWedlugOrderIdDoInsertaBazy(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id);
                DzialaniaNaFakturze.DodajFaktureDoBazy(DaneDoFaktury);
                DzialanieNaZamowieniu.EdytujStatusZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, "invoice_ready", "Faktura Gotowa", "");

                if (GlobalClass.FakturaSesja.AktualnaFaktura == null)
                {
                    GlobalClass.FakturaSesja.AktualnaFaktura = new FakturaClass();
                }

                GlobalClass.FakturaSesja.AktualnaFaktura.invoice_number = DaneDoFaktury.invoice_number;


                bazaOK = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd zapisu faktury w bazie: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (bazaOK)
            {
                try
                {
                    var items = PobierzPozycjeZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id);
                    var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    var logoPath = Path.Combine(baseDirectory, "Resources", "logo.png");
                    if (!File.Exists(logoPath)) throw new FileNotFoundException($"Logo nie zostało znalezione pod ścieżką: {logoPath}");
                    var invoice = new DokumentFakturaClass("D&K Centrum Kopiowania", items, logoPath);

                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string ordersFolderPath = Path.Combine(desktopPath, "D&K_Zamówienia");
                    if (!Directory.Exists(ordersFolderPath)) Directory.CreateDirectory(ordersFolderPath);

                    string orderFolderName = $"Zamowienie_{GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id}";
                    string orderFolderPath = Path.Combine(ordersFolderPath, orderFolderName);
                    if (!Directory.Exists(orderFolderPath)) Directory.CreateDirectory(orderFolderPath);

                    string nrFaktury = lblNrZamowienia.Text;
                    string nazwaKlienta = txtBoxNazwaKlienta.Text.Trim();
                    if (string.IsNullOrEmpty(nazwaKlienta)) throw new ArgumentException("Nazwa klienta nie może być pusta.");
                    string skroconaNazwaKlienta = nazwaKlienta.Length > 30 ? nazwaKlienta.Substring(0, 30) : nazwaKlienta;
                    string fileName = $"Faktura_Nr{nrFaktury}_{skroconaNazwaKlienta.Replace(" ", "_").Replace("/", "_").Replace("X", "")}.pdf";

                    string filePath = Path.Combine(orderFolderPath, fileName);

                    invoice.GeneratePdf(filePath);

                    ZapiszPdfDoBazy(filePath);

                    var result = MessageBox.Show($"PDF został zapisany w lokalizacji: {filePath}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK) WypelnijSzczegolyZamowienia();


                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"Błąd pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd generowania PDF: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void ZapiszPdfDoBazy(string pdfFilePath)
        {
            try
            {
                byte[] pdfBytes = File.ReadAllBytes(pdfFilePath);
                int invoiceId = PobierzInvoiceIdPoOrderId(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id);

                using (MySqlConnection conn = new MySqlConnection(PolaczenieDB))
                {
                    conn.Open();
                    string sql = @"
                UPDATE invoices
                SET pdf_data = @PdfData
                WHERE invoice_id = @InvoiceId
                LIMIT 1;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PdfData", pdfBytes);
                        cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd zapisu PDF do bazy: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int PobierzInvoiceIdPoOrderId(int orderId)
        {
            int invoiceId = -1;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(PolaczenieDB))
                {
                    conn.Open();
                    string sql = @"
                SELECT invoice_id
                FROM invoices
                WHERE order_order_id = @OrderId
                LIMIT 1;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderId", orderId);
                        object wynik = cmd.ExecuteScalar();
                        if (wynik != null && wynik != DBNull.Value)
                        {
                            invoiceId = Convert.ToInt32(wynik);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd pobierania invoice_id: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return invoiceId;
        }







        private void dtGridViewZamowienia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtGridViewZamowienia.Columns["PobierzPlik"].Index)
            {
                object fileIdObj = dtGridViewZamowienia.Rows[e.RowIndex].Cells["file_id"].Value;
                if (fileIdObj != null && int.TryParse(fileIdObj.ToString(), out int fileId))
                {
                    if (fileId > 0)
                    {

                        PobierzPlikZBazy(fileId, GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id);
                    }
                    else
                    {
                        MessageBox.Show("Brak pliku do pobrania (file_id = 0 lub null).");
                    }
                }
            }
        }


        private void PobierzPlikZBazy(int fileId, int orderId)
        {
            try
            {
                using (MySqlConnection polaczenie = new MySqlConnection(PolaczenieDB))
                {
                    polaczenie.Open();
                    string query = "SELECT filename, file_data FROM files WHERE file_id = @fileId";

                    using (MySqlCommand cmd = new MySqlCommand(query, polaczenie))
                    {
                        cmd.Parameters.AddWithValue("@fileId", fileId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fileName = reader["filename"].ToString();
                                byte[] fileData = (byte[])reader["file_data"];


                                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                                string ordersFolderPath = Path.Combine(desktopPath, "D&K_Zamówienia");
                                if (!Directory.Exists(ordersFolderPath)) Directory.CreateDirectory(ordersFolderPath);

                                string orderFolderName = $"Zamowienie_{orderId}";
                                string orderFolderPath = Path.Combine(ordersFolderPath, orderFolderName);

                                if (!Directory.Exists(orderFolderPath)) Directory.CreateDirectory(orderFolderPath);

                                string filePath = Path.Combine(orderFolderPath, fileName);
                                File.WriteAllBytes(filePath, fileData);

                                MessageBox.Show($"Plik został pobrany i zapisany w folderze:\n{filePath}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Nie znaleziono pliku o podanym ID.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNrNip.Text))
            {
                Clipboard.SetText(txtBoxNrNip.Text);
                MessageBox.Show("Numer NIP został skopiowany do schowka.", "Kopiowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pole NIP jest puste. Nie można skopiować.", "Błąd kopiowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
