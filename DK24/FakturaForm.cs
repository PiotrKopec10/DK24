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
}
