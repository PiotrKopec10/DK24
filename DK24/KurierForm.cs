using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Crmf;
using RestSharp;
using System;
using System.Net.Http.Headers;
using System.Text;


namespace DK24
{
    public partial class KurierForm : Form
    {

        public KurierForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var furgonetkaService = new FurgonetkaService();

            bool authenticated = await furgonetkaService.Authenticate("jakub.szufrajda02@gmail.com", "PioKu2002$");
            if (!authenticated)
            {
                MessageBox.Show("Autoryzacja nie powiodła się.");
                return;
            }


            var packageData = new
            {
                pickup = new
                {
                    name = "Jan Kowalski",
                    company = "Firma Nadawcy",
                    street = "Ulica Nadawcza 1",
                    postcode = "00-001",
                    city = "Warszawa",
                    country_code = "PL",
                    county = "",
                    email = "test@wp.pl",
                    phone = "606596110"
                },
                receiver = new
                {
                    name = "Anna Nowak",
                    company = "Firma Odbiorcy",
                    street = "Ulica Odbiorcza 2",
                    postcode = "31-002",
                    city = "Kraków",
                    country_code = "PL",
                    county = "",
                    email = "test1@wp.pl",
                    phone = "576358560"
                },
                service_id = 10232121,
                parcels = new[]
                {
        new
        {
            weight = 5.0,
            length = 30,
            width = 20,
            height = 10,
            depth = 2,
            content = "Dokumenty",
            type = "package"
        }
    },
                type = "package",
                user_reference_number = "Zamówienie 123",
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
                MessageBox.Show("Paczka jest poprawna.");

                string packageId = await furgonetkaService.CreatePackage(packageData);
                if (!string.IsNullOrEmpty(packageId))
                {
                    MessageBox.Show("Przesyłka została pomyślnie utworzona. ID: " + packageId);

                    bool isOrdered = await furgonetkaService.OrderPackage(packageId);
                    if (isOrdered)
                    {
                        MessageBox.Show("Przesyłka została pomyślnie zamówiona.");

                        // Pobranie etykiety
                        var labelData = await furgonetkaService.GetPackageLabel(packageId);
                        if (labelData != null)
                        {
                            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            string folderPath = Path.Combine(desktopPath, "D&K_Etykiety_zamówień");

                            // Tworzenie folderu, jeśli nie istnieje
                            if (!Directory.Exists(folderPath))
                            {
                                Directory.CreateDirectory(folderPath);
                            }

                            // Ścieżka zapisu etykiety
                            string labelPath = Path.Combine(folderPath, $"label_{packageId}.pdf");

                            // Zapis etykiety
                            File.WriteAllBytes(labelPath, labelData);

                            MessageBox.Show($"Etykieta została zapisana jako {labelPath}");
                            Console.WriteLine($"Etykieta została zapisana w: {Path.GetFullPath(labelPath)}");
                        }
                        else
                        {
                            MessageBox.Show("Nie udało się pobrać etykiety.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się zamówić przesyłki. Sprawdź szczegóły logów.");
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
    }






    public class FurgonetkaService
    {
        private const string BaseUrl = "https://api.sandbox.furgonetka.pl";
        private string ClientId = "dktest-c2c8a461a7ec3572f4d4427be03a12c1";
        private string ClientSecret = "ff7f8cefc88803239cc9370977509316967b1484a23233addefda58f132bf13a";
        private string AccessToken;

        public async Task<bool> Authenticate(string email, string password)
        {
            var client = new RestClient($"{BaseUrl}/oauth/token");
            var request = new RestRequest
            {
                Method = Method.Post
            };

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", email);
            request.AddParameter("password", password);
            request.AddParameter("scope", "api");

            string credentials = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}"));
            request.AddHeader("Authorization", $"Basic {credentials}");

            var response = await client.ExecuteAsync(request);
            Console.WriteLine("Authentication Response: " + response.Content);

            if (response.IsSuccessful)
            {
                dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                AccessToken = jsonResponse.access_token;
                return true;
            }

            return false;
        }

        public async Task<string> CreatePackage(object packageData)
        {
            if (string.IsNullOrEmpty(AccessToken))
            {
                throw new InvalidOperationException("Authenticate first before making API requests.");
            }

            var client = new RestClient($"{BaseUrl}/packages");
            var request = new RestRequest
            {
                Method = Method.Post
            };

            request.AddHeader("Authorization", $"Bearer {AccessToken}");
            request.AddHeader("Content-Type", "application/vnd.furgonetka.v1+json");
            request.AddJsonBody(packageData);

            var response = await client.ExecuteAsync(request);
            Console.WriteLine("CreatePackage Response: " + response.Content);

            if (response.IsSuccessful)
            {
                dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                string packageId = jsonResponse.package_id;
                Console.WriteLine("Utworzono paczkę z ID: " + packageId);
                return packageId;
            }

            Console.WriteLine($"Błąd tworzenia paczki: {response.StatusCode} - {response.ErrorMessage}");
            return null;
        }


        public async Task<string> GetCarriers()
        {
            if (string.IsNullOrEmpty(AccessToken))
            {
                throw new InvalidOperationException("Authenticate first before making API requests.");
            }

            var client = new RestClient($"{BaseUrl}/account/services");
            var request = new RestRequest
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", $"Bearer {AccessToken}");
            request.AddHeader("Accept", "application/vnd.furgonetka.v1+json");

            var response = await client.ExecuteAsync(request);
            Console.WriteLine("GetCarriers Response: " + response.Content);

            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ErrorMessage}");
                return null;
            }
        }






       




        public async Task<bool> ValidatePackage(object packageData)
        {
            if (string.IsNullOrEmpty(AccessToken))
            {
                throw new InvalidOperationException("Authenticate first before making API requests.");
            }

            var client = new RestClient($"{BaseUrl}/packages/validate");
            var request = new RestRequest
            {
                Method = Method.Post
            };

            request.AddHeader("Authorization", $"Bearer {AccessToken}");
            request.AddHeader("Content-Type", "application/vnd.furgonetka.v1+json");
            request.AddJsonBody(packageData);

            var response = await client.ExecuteAsync(request);

            Console.WriteLine("ValidatePackage Response Status Code: " + response.StatusCode);

           
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                Console.WriteLine("Paczka została poprawnie zweryfikowana (204 No Content).");
                return true;
            }

        
            if (response.IsSuccessful)
            {
                Console.WriteLine("Paczka została poprawnie zweryfikowana.");
                return true;
            }

            // Obsługa błędów
            Console.WriteLine($"Błąd walidacji: {response.StatusCode} - {response.ErrorMessage}");
            Console.WriteLine("Szczegóły błędu: " + response.Content);
            return false;
        }




        public async Task<bool> OrderPackage(string packageId)
        {
            if (string.IsNullOrEmpty(AccessToken))
            {
                throw new InvalidOperationException("Authenticate first before making API requests.");
            }

        
            string uuid = Guid.NewGuid().ToString();
            Console.WriteLine("Wygenerowany UUID dla zamówienia: " + uuid);

            var orderData = new
            {
                packages = new[]
                {
            new { id = packageId }
        },
                label = new
                {
                    page_format = "a6",
                    file_format = "pdf"
                },
                only_order_pickup = false,
                skip_email_send = false
            };

            var client = new RestClient($"{BaseUrl}/order-commands/{uuid}");
            var request = new RestRequest
            {
                Method = Method.Put
            };

            request.AddHeader("Authorization", $"Bearer {AccessToken}");
            request.AddHeader("Content-Type", "application/vnd.furgonetka.v1+json");
            request.AddJsonBody(orderData);

            var response = await client.ExecuteAsync(request);
            Console.WriteLine("OrderPackage Response: " + response.Content);

            if (response.IsSuccessful)
            {
                Console.WriteLine("Przesyłka została zamówiona.");
                return true;
            }
            else
            {
                Console.WriteLine($"Błąd zamawiania przesyłki: {response.StatusCode} - {response.ErrorMessage}");
                Console.WriteLine("Szczegóły błędu: " + response.Content);
                return false;
            }
        }


        public async Task<byte[]> GetPackageLabel(string packageId)
        {
            if (string.IsNullOrEmpty(AccessToken))
            {
                throw new InvalidOperationException("Authenticate first before making API requests.");
            }

            var client = new RestClient($"{BaseUrl}/packages/{packageId}/label");
            var request = new RestRequest
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", $"Bearer {AccessToken}");
            request.AddHeader("Accept", "application/vnd.furgonetka.v1+json");

            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                return response.RawBytes; // Zwraca dane w formacie PDF
            }

            return null;
        }


    }
}
