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
        AddressClass DzialanieNaAdressie = new AddressClass();
        FakturaClass DzialanieNaFakturze = new FakturaClass();

        public DokumentForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelGorny, this.Handle);

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

                AktualnyAdres = DzialanieNaAdressie.PobierzAdresWgId(AktualnyKontrahent.address_id);

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


           
            dtPickSprzed.MaxDate = DateTime.Now.AddDays(100);


            if(GlobalClass.StanFormyFaktury.StanFormy == 1) 
            {
                txtBoxNumerFaktury.Text = DzialanieNaFakturze.PobierzNumerFaktury();
            }
            
        }
    }
}
