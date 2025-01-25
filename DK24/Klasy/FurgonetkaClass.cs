using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DK24.Klasy
{
    internal class FurgonetkaClass
    {
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

      
                Console.WriteLine($"Błąd walidacji: {response.StatusCode} - {response.ErrorMessage}");
                Console.WriteLine("Szczegóły błędu: " + response.Content);

                try
                {
                    if (!string.IsNullOrEmpty(response.Content))
                    {
                      
                        var jsonDocument = System.Text.Json.JsonDocument.Parse(response.Content);                    
                        var errors = jsonDocument.RootElement.GetProperty("errors");
                        if (errors.GetArrayLength() > 0)
                        {
                            string message = errors[0].GetProperty("message").GetString();
                            GlobalClass.BladFurgonetkaWalidacja.WalidacjaPaczkiFurgonetka = message;
                        }
                        else
                        {
                            GlobalClass.BladFurgonetkaWalidacja.WalidacjaPaczkiFurgonetka = "Nieznany błąd walidacji.";
                        }
                    }
                    else
                    {
                        GlobalClass.BladFurgonetkaWalidacja.WalidacjaPaczkiFurgonetka = "Brak szczegółów błędu.";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Błąd podczas parsowania odpowiedzi JSON: " + ex.Message);
                    GlobalClass.BladFurgonetkaWalidacja.WalidacjaPaczkiFurgonetka = "Błąd podczas parsowania odpowiedzi.";
                }


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
                    Method = Method.Get,
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
}
