using DK24.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;



namespace DK24
{
    public partial class DokumentForm : Form
    {
        KontrahentClass DzialanieNaKontrahencie = new KontrahentClass();
        KontrahentClass.Kontrahent AktualnyKontrahent = new KontrahentClass.Kontrahent();
        AddressClass.Address AktualnyAdres = new AddressClass.Address();
        AddressClass DzialanieNaAdresie = new AddressClass();
        FakturaClass DzialanieNaFakturze = new FakturaClass();
        GlobalClass GlobalneDzialania = new GlobalClass();
        ZamowieniaClass DzialanieNaZamowieniu = new ZamowieniaClass();

        public DokumentForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelGorny, this.Handle);


            // Obsługa NIP
            txtBoxNipKnt.MaxLength = 10;
            txtBoxNipKnt.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoCyfry);

            // Obsługa Akronimu
            txtBoxAkronimKnt.MaxLength = 10;

            // Obsługa Kod Pocztowy
            txtBoxKodPoczKnt.KeyPress += new KeyPressEventHandler(txtBoxKodPoczKnt_KeyPress);
            txtBoxKodPoczKnt.TextChanged += new EventHandler(txtBoxKodPoczKnt_TextChanged);

            // Obsługa Nazwy Kontrahenta
            txtBoxNazwaKnt.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

            // Obsługa Adresu
            txtBoxAdresKnt.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

            // Obsługa Miasta
            txtBoxMiastoKnt.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

        }


        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            ListaFakturForm mainForm = new ListaFakturForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void btnKontrahent_Click(object sender, EventArgs e)
        {
            WybierzKontrahentaForm wybierzKontrahentaForm = new WybierzKontrahentaForm();
            wybierzKontrahentaForm.ShowDialog();

            if (GlobalClass.StanFormyFaktury.StanFormy == 1)
            {
                AktualnyKontrahent = DzialanieNaKontrahencie.PobierzKontrahentaWgId(GlobalClass.KontrahentSesja.AktualnyKontrahent.company_details_id);

                AktualnyAdres = DzialanieNaAdresie.PobierzAdresWgId(AktualnyKontrahent.address_id);

                txtBoxNipKnt.Text = AktualnyKontrahent.nip;
                txtBoxAkronimKnt.Text = AktualnyKontrahent.acronym;
                txtBoxNazwaKnt.Text = AktualnyKontrahent.name;

                if (AktualnyAdres.apartment_number == "")
                {
                    txtBoxAdresKnt.Text = AktualnyAdres.street + " " + AktualnyAdres.house_number;
                }
                else
                {

                    txtBoxAdresKnt.Text = AktualnyAdres.street + " " + AktualnyAdres.house_number + " " + AktualnyAdres.apartment_number;
                }


                txtBoxKodPoczKnt.Text = AktualnyAdres.postal_code;
                txtBoxMiastoKnt.Text = AktualnyAdres.city;
            }



        }



        public async void SzukajPoNIP(string nip)
        {
            try
            {
                var binding = new WSHttpBinding();
                binding.MessageEncoding = WSMessageEncoding.Mtom;
                binding.Security.Mode = SecurityMode.Transport;

                var endpointAddress = new EndpointAddress("https://wyszukiwarkaregontest.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc");
                var client = new GUSAPI.UslugaBIRzewnPublClient(binding, endpointAddress);

                // Logowanie i pobranie SID (sesji)
                var loginResponse = await client.ZalogujAsync("abcde12345abcde12345");
                string sid = loginResponse.ZalogujResult;

                // Dodanie SID do nagłówków
                using (var scope = new OperationContextScope(client.InnerChannel))
                {
                    var httpRequestProperty = new HttpRequestMessageProperty();
                    httpRequestProperty.Headers["sid"] = sid;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;

                    // Przygotowanie parametrów wyszukiwania po NIP
                    var parametry = new GUSAPI.ParametryWyszukiwania { Nip = nip };

                    // Wykonanie zapytania
                    var wynikResponse = await client.DaneSzukajPodmiotyAsync(parametry);
                    string wynik = wynikResponse.DaneSzukajPodmiotyResult;

                    // Przetwarzanie wyniku XML
                    WypelnijDaneZXml(wynik);
                }

                // Wylogowanie
                using (var scope = new OperationContextScope(client.InnerChannel))
                {
                    var httpRequestProperty = new HttpRequestMessageProperty();
                    httpRequestProperty.Headers["sid"] = sid;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;

                    await client.WylogujAsync(sid);
                }

                client.Close();
            }
            catch (Exception ex)
            {
                txtBoxNipKnt.Text = $"Błąd: {ex.Message}";
            }
        }


        private void btnPobierzPoNip_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz szukać po NIP-ie kontrahenta?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SzukajPoNIP(txtBoxNipKnt.Text);
            }


        }

        public void WypelnijDaneZXml(string xmlContent)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlContent);

            XmlNode daneNode = doc.SelectSingleNode("/root/dane");

            if (daneNode != null)
            {


                string czyBlad = daneNode.SelectSingleNode("ErrorCode")?.InnerText ?? "";

                if (czyBlad == "4")
                {


                    txtBoxNazwaKnt.Text = "";
                    txtBoxMiastoKnt.Text = "";
                    txtBoxKodPoczKnt.Text = "";

                    txtBoxAdresKnt.Text = "";

                    MessageBox.Show("Błąd nie znaleziono w bazie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    txtBoxNipKnt.Text = daneNode.SelectSingleNode("Nip")?.InnerText ?? "";
                    txtBoxNazwaKnt.Text = daneNode.SelectSingleNode("Nazwa")?.InnerText ?? "";
                    txtBoxMiastoKnt.Text = daneNode.SelectSingleNode("Miejscowosc")?.InnerText ?? "";
                    txtBoxKodPoczKnt.Text = daneNode.SelectSingleNode("KodPocztowy")?.InnerText ?? "";

                    string ulica = daneNode.SelectSingleNode("Ulica")?.InnerText ?? "";
                    string nrNieruchomosci = daneNode.SelectSingleNode("NrNieruchomosci")?.InnerText ?? "";
                    string nrLokalu = daneNode.SelectSingleNode("NrLokalu")?.InnerText ?? "";

                    string adres = $"{ulica} {nrNieruchomosci}".Trim();
                    if (!string.IsNullOrEmpty(nrLokalu))
                    {
                        adres += $"/{nrLokalu}";
                    }

                    txtBoxAdresKnt.Text = adres;

                }

            }
        }

        private void grpBoxNaglowek_Enter(object sender, EventArgs e)
        {

        }

        private bool zmianaProgramowa = false;

        private void numBoxIloscDni_ValueChanged(object sender, EventArgs e)
        {
            if (!zmianaProgramowa)
            {
                zmianaProgramowa = true;


                dtPickSprzed.Value = DateTime.Today.AddDays((double)numBoxIloscDni.Value);

                zmianaProgramowa = false;
            }
        }

        private void dtPickSprzed_ValueChanged(object sender, EventArgs e)
        {


            if (dtPickSprzed.Value >= DateTime.Today)
            {

                if (!zmianaProgramowa)
                {
                    zmianaProgramowa = true;

                    int dniRoznicy = (dtPickSprzed.Value.Date - DateTime.Today).Days;
                    if (dniRoznicy > 100)
                    {
                        dniRoznicy = 100;
                    }
                    else
                    {
                        numBoxIloscDni.Value = dniRoznicy;
                    }


                    zmianaProgramowa = false;
                }

            }
            else
            {

                MessageBox.Show("Nie można wystawić faktury na skibidi", "Elo");
                dtPickSprzed.Value = DateTime.Today;

            }





        }

        private void DokumentForm_Load(object sender, EventArgs e)
        {


            txtBoxNumerFaktury.Text = DzialanieNaFakturze.PobierzNumerFaktury();
            dtPickSprzed.MaxDate = DateTime.Now.AddDays(100);


            if (GlobalClass.StanFormyFaktury.StanFormy == 1)
            {
                //txtBoxNumerFaktury.Text = DzialanieNaFakturze.PobierzNumerFaktury();
            }

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            //ToolTip toolTip = new ToolTip
            //{
            //    IsBalloon = true,
            //    InitialDelay = 0,
            //    ShowAlways = true
            //};

            //bool isValid = true;
            //List<string> pustePola = new List<string>();

            //if (string.IsNullOrWhiteSpace(txtBoxNipKnt.Text))
            //{
            //    txtBoxNipKnt.BackColor = Color.Pink;
            //    toolTip.SetToolTip(txtBoxNipKnt, "Pole NIP nie może być puste!");
            //    pustePola.Add("NIP");
            //    isValid = false;
            //}
            //else
            //{
            //    txtBoxNipKnt.BackColor = SystemColors.Window;
            //}

            //if (string.IsNullOrWhiteSpace(txtBoxNazwaKnt.Text))
            //{
            //    txtBoxNazwaKnt.BackColor = Color.Pink;
            //    toolTip.SetToolTip(txtBoxNazwaKnt, "Pole Nazwa nie może być puste!");
            //    pustePola.Add("Nazwa");
            //    isValid = false;
            //}
            //else
            //{
            //    txtBoxNazwaKnt.BackColor = SystemColors.Window;
            //}

            //if (string.IsNullOrWhiteSpace(txtBoxKodPoczKnt.Text))
            //{
            //    txtBoxKodPoczKnt.BackColor = Color.Pink;
            //    toolTip.SetToolTip(txtBoxKodPoczKnt, "Pole Kod Pocztowy nie może być puste!");
            //    pustePola.Add("Kod Pocztowy");
            //    isValid = false;
            //}
            //else
            //{
            //    txtBoxKodPoczKnt.BackColor = SystemColors.Window;
            //}

            //if (string.IsNullOrWhiteSpace(txtBoxAdresKnt.Text))
            //{
            //    txtBoxAdresKnt.BackColor = Color.Pink;
            //    toolTip.SetToolTip(txtBoxAdresKnt, "Pole Adres nie może być puste!");
            //    pustePola.Add("Adres");
            //    isValid = false;
            //}
            //else
            //{
            //    txtBoxAdresKnt.BackColor = SystemColors.Window;
            //}

            //if (string.IsNullOrWhiteSpace(txtBoxMiastoKnt.Text))
            //{
            //    txtBoxMiastoKnt.BackColor = Color.Pink;
            //    toolTip.SetToolTip(txtBoxMiastoKnt, "Pole Miasto nie może być puste!");
            //    pustePola.Add("Miasto");
            //    isValid = false;
            //}
            //else
            //{
            //    txtBoxMiastoKnt.BackColor = SystemColors.Window;
            //}

            //if (!isValid)
            //{
            //    if (pustePola.Count > 1)
            //    {
            //        MessageBox.Show("Te pola nie mogą być puste: " + string.Join(", ", pustePola) + "!", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else if (pustePola.Count == 1)
            //    {
            //        string pustePole = pustePola[0];
            //        Control pustePoleControl = null;

            //        if (pustePole == "NIP") pustePoleControl = txtBoxNipKnt;
            //        else if (pustePole == "Nazwa") pustePoleControl = txtBoxNazwaKnt;
            //        else if (pustePole == "Kod Pocztowy") pustePoleControl = txtBoxKodPoczKnt;
            //        else if (pustePole == "Adres") pustePoleControl = txtBoxAdresKnt;
            //        else if (pustePole == "Miasto") pustePoleControl = txtBoxMiastoKnt;

            //        MessageBox.Show($"Pole {pustePole} nie może być puste!", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //        if (pustePoleControl != null)
            //        {
            //            toolTip.Show($"Uzupełnij pole {pustePole}!", pustePoleControl, 20, 21, 4000);
            //        }
            //    }
            //    return;
            //}





            DzialanieNaZamowieniu.EdytujStatusZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, "invoice_ready", "Faktura Gotowa", "");

            SzczegolyZamowieniaForm szczegolyZamowieniaForm = new SzczegolyZamowieniaForm();
            this.Hide();
            szczegolyZamowieniaForm.ShowDialog();





            // stanyFormy
        }

        private void txtBoxKodPoczKnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtBoxKodPoczKnt_TextChanged(object sender, EventArgs e)
        {
            string currentText = txtBoxKodPoczKnt.Text.Replace("-", "");
            if (currentText.Length > 2)
            {
                currentText = currentText.Insert(2, "-");
            }

            if (currentText.Length > 6)
            {
                currentText = currentText.Substring(0, 6);
            }

            txtBoxKodPoczKnt.Text = currentText;
            txtBoxKodPoczKnt.SelectionStart = txtBoxKodPoczKnt.Text.Length;
        }

        private void txtBoxNipKnt_Enter(object sender, EventArgs e)
        {
            txtBoxNipKnt.BackColor = SystemColors.Window;
        }

        private void txtBoxNazwaKnt_Enter(object sender, EventArgs e)
        {
            txtBoxNazwaKnt.BackColor = SystemColors.Window;
        }

        private void txtBoxAdresKnt_Enter(object sender, EventArgs e)
        {
            txtBoxAdresKnt.BackColor = SystemColors.Window;
        }

        private void txtBoxKodPoczKnt_Enter(object sender, EventArgs e)
        {
            txtBoxKodPoczKnt.BackColor = SystemColors.Window;
        }

        private void txtBoxMiastoKnt_Enter(object sender, EventArgs e)
        {
            txtBoxMiastoKnt.BackColor = SystemColors.Window;
        }
    }
}
