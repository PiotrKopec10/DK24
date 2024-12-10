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
                    country_code = "",
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
                    country_code = "",
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




            string carriers = await furgonetkaService.GetCarriers();
            if (!string.IsNullOrEmpty(carriers))
            {
                MessageBox.Show("Lista przewoźników:\n" + carriers);
            }
            else
            {
                MessageBox.Show("Nie udało się pobrać listy przewoźników.");
            }


            
            string response = await furgonetkaService.CreatePackage(packageData);
            if (!string.IsNullOrEmpty(response))
            {
                MessageBox.Show("Przesyłka została pomyślnie utworzona.");
            }
            else
            {
                MessageBox.Show("Nie udało się utworzyć przesyłki.");
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
                return response.Content;
            }
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

















    }
}
