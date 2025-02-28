using DK24.Klasy;
using Newtonsoft.Json;
using RestSharp;


namespace DK24
{
    public partial class KurierForm : Form
    {
        ZamowieniaClass DzialanieNaZamowieniu = new ZamowieniaClass();
        MainForm mainForm = new MainForm();

        SzczegolyZamowieniaForm szczegolyZamowieniaForm = new SzczegolyZamowieniaForm();


        AddressClass DzialaniaNaAdresie = new AddressClass();
        AddressClass.Address Address = new AddressClass.Address();
        UserClass DzialaniaNaUserze = new UserClass();
        UserClass.User Uzytkownik = new UserClass.User();
        public KurierForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            btnAnuluj.Enabled = false;
            btnStworzZamowienie.Enabled = false;

            rchBoxLogi.Text = "Próba wygenerowania etykiety... \n Proszę czekać! \n";

            var furgonetkaService = new FurgonetkaClass.FurgonetkaService();

            //bool authenticated = await furgonetkaService.Authenticate("", "");
            string email = Environment.GetEnvironmentVariable("FURGONETKA_EMAIL");
            string password = Environment.GetEnvironmentVariable("FURGONETKA_PASSWORD");

            bool authenticated = await furgonetkaService.Authenticate(email, password);

            
            if (!authenticated)
            {
                MessageBox.Show("Autoryzacja nie powiodła się.");
                return;
            }

            Address = DzialaniaNaAdresie.PobierzAdresWgId(GlobalClass.AdressGlobalne.AktualnyAddress.address_id);

            Uzytkownik = DzialaniaNaUserze.PobierzUseraPoIdUsera(GlobalClass.UserGlobalne.AktualnyUser.user_id);


            string nazwaUlicy = "";

            if(Address.apartment_number == null)
            {
                 nazwaUlicy = Address.street + " " + Address.house_number;
            }
            else 
            {
                nazwaUlicy = Address.street + " " + Address.house_number + "/" + Address.apartment_number;
            }
            

            var packageData = new
            {
                pickup = new
                {
                    name = "Centrum Kopiowania",
                    company = "D&K",
                    street = "Ulica Jana Kilińskiego 4",
                    postcode = "80-452",
                    city = "Gdańsk",
                    country_code = "PL",
                    county = "",
                    email = "kserogdansk@wp.pl",
                    phone = "58 770 34 30"
                },
                receiver = new
                { 
                    name = GlobalClass.OdbiorcaPaczki.NazwaKlientaDoWysylki,
                    company = GlobalClass.OdbiorcaPaczki.NazwaKlientaDoWysylki,                 
                    street = nazwaUlicy,
                    postcode = Address.postal_code,
                    city = Address.city,
                    country_code = "PL",
                    county = "",
                    email = Uzytkownik.email,
                    phone = Uzytkownik.phone_number
                },
                service_id = 10232121,
                parcels = new[]
                {
        new
        {
            weight = 18,
            width = 50,
            height = 60,
            depth = 40,
            content = "Paczka ",
            type = "package"
        }
    },
                type = "package",
                user_reference_number = "Zamówienie D&K",
            };






            //string carriers = await furgonetkaService.GetCarriers();
            //if (!string.IsNullOrEmpty(carriers))
            //{
            //    MessageBox.Show("Lista przewoźników:\n" + carriers);
            //}
            //else
            //{
            //    MessageBox.Show("Nie udało się pobrać listy przewoźników.");
            //}



            bool isValid = await furgonetkaService.ValidatePackage(packageData);
            if (isValid)
            {
                string packageId = await furgonetkaService.CreatePackage(packageData);
                if (!string.IsNullOrEmpty(packageId))
                {
                    bool isOrdered = await furgonetkaService.OrderPackage(packageId);
                    if (isOrdered)
                    {
                        byte[] labelData = null;
                        int retries = 5;
                        int delay = 3000;

                        for (int i = 0; i < retries; i++)
                        {

                            await Task.Delay(delay);
                            labelData = await furgonetkaService.GetPackageLabel(packageId);

                            if (labelData != null && labelData.Length > 0)
                            {
                                rchBoxLogi.AppendText("Etykieta została pomyślnie pobrana.\n");
                                break;
                            }
                            else
                            {
                                rchBoxLogi.AppendText($"Próba {i + 1}/{retries}: Etykieta wciąż nie gotowa. Ponawiam próbę...\n");
                            }
                        }


                        if (labelData != null && labelData.Length > 0)
                        {
                            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            string ordersFolderPath = Path.Combine(desktopPath, "D&K_Zamówienia");

                            if (!Directory.Exists(ordersFolderPath))
                            {
                                Directory.CreateDirectory(ordersFolderPath);
                            }

                            string orderFolderName = $"Zamowienie_{GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id}";
                            string orderFolderPath = Path.Combine(ordersFolderPath, orderFolderName);

                            if (!Directory.Exists(orderFolderPath))
                            {
                                Directory.CreateDirectory(orderFolderPath);
                            }

                            string labelPath = Path.Combine(orderFolderPath, $"Etykieta_Przewozowa_Nr{packageId}.pdf");

                            File.WriteAllBytes(labelPath, labelData);

                            rchBoxLogi.SelectionColor = Color.Red;
                            rchBoxLogi.SelectionFont = new Font(rchBoxLogi.Font.FontFamily, rchBoxLogi.Font.Size + 2, FontStyle.Bold);




                            DzialanieNaZamowieniu.EdytujStatusZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, "label_ready", "Gotowa Etykieta", labelPath);




                            this.Hide();
                            szczegolyZamowieniaForm.ShowDialog();



                        }
                        else
                        {
                            MessageBox.Show("Nie udało się pobrać etykiety po kilkukrotnych próbach.");
                            MainForm mainForm = new MainForm();
                            this.Hide();
                            mainForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się zamówić przesyłki.");
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        mainForm.ShowDialog();
                    }


                }
                else
                {
                    MessageBox.Show("Nie udało się utworzyć przesyłki. Sprawdź szczegóły logów.");
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(GlobalClass.BladFurgonetkaWalidacja.WalidacjaPaczkiFurgonetka + "\n  Zamówienie zostanie anulowane automatycznie.", "Paczka nie przeszła walidacji.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DzialanieNaZamowieniu.EdytujStatusZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, "canceled", "Anulowane", "");
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
            }


         

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            SzczegolyZamowieniaForm szczegolyZamowieniaForm = new SzczegolyZamowieniaForm();
            this.Hide();
            szczegolyZamowieniaForm.ShowDialog();
        }
    }






  
}
