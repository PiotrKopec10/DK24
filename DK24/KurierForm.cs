using DK24.Klasy;
using Newtonsoft.Json;
using RestSharp;


namespace DK24
{
    public partial class KurierForm : Form
    {
        ZamowieniaClass DzialanieNaZamowieniu = new ZamowieniaClass();
        MainForm mainForm = new MainForm();

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

            bool authenticated = await furgonetkaService.Authenticate("jakub.szufrajda02@gmail.com", "PioKu2002$");
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
                    street = "Ulica Grunwaldzka 82",
                    postcode = "80-244",
                    city = "Gdańsk",
                    country_code = "PL",
                    county = "",
                    email = "kserogdansk@wp.pl",
                    phone = "58 770 34 30"
                },
                receiver = new
                {
                    //Tutaj jeszcze zweryfikowac co konkretnie dodajemy 
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
                            string folderPath = Path.Combine(desktopPath, "D&K_Etykiety_zamówień");

                            if (!Directory.Exists(folderPath))
                            {
                                Directory.CreateDirectory(folderPath);
                            }
                            string labelPath = Path.Combine(folderPath, $"label_{packageId}.pdf");

                            File.WriteAllBytes(labelPath, labelData);

                            rchBoxLogi.SelectionColor = Color.Red;
                            rchBoxLogi.SelectionFont = new Font(rchBoxLogi.Font.FontFamily, rchBoxLogi.Font.Size + 2, FontStyle.Bold);


                           // rchBoxLogi.AppendText($"Etykieta została zapisana jako {labelPath}\n");


                            

                            DzialanieNaZamowieniu.EdytujStatusZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, "completed", "Zakończone",labelPath);

                            this.Hide();
                            mainForm.ShowDialog();



                        }
                        else
                        {
                            MessageBox.Show("Nie udało się pobrać etykiety po kilkukrotnych próbach.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się zamówić przesyłki.");
                        
                    }


                }
                else
                {
                    MessageBox.Show("Nie udało się utworzyć przesyłki. Sprawdź szczegóły logów.");
                 
                }
            }
            else
            {
                MessageBox.Show("Paczka nie przeszła walidacji. Sprawdź szczegóły błędów w konsoli.");
           
            }


         

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }
    }






  
}
