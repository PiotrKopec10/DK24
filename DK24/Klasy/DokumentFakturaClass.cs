using DK24.Klasy;
using MySql.Data.MySqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DK24
{
    public class DokumentFakturaClass : IDocument
    {
        private readonly string _nazwaSprzedawcy;
        private readonly List<(string Item, int Quantity, decimal PriceBrutto, decimal PriceNetto)> _produkty;
        private readonly string _sciezkaLogo;

 
        public string NazwaNabywcy = "";
        public string PelnyAdresNabywcy = "";
        public string SposobZaplaty = "";
        public DateTime DataWystawienia;
        public DateTime DataSprzedazy = DateTime.Now;
        public string NumerNip = "";
        public string NumerTel = "";

        public DokumentFakturaClass(
            string nazwaSprzedawcy,
            List<(string Item, int Quantity, decimal PriceBrutto, decimal PriceNetto)> produkty,
            string sciezkaLogo)
        {
            _nazwaSprzedawcy = nazwaSprzedawcy;
            _produkty = produkty;
            _sciezkaLogo = sciezkaLogo;
        }

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(strona =>
                {
                    strona.Margin(50);

                    
                    strona.Header().Row(wiersz =>
                    {
                        wiersz.RelativeColumn().Element(InformacjeSprzedawcy);
                        wiersz.ConstantColumn(200).Element(InformacjeFaktury);
                    });

                    
                    strona.Content().Column(kolumna =>
                    {
                        kolumna.Spacing(20);
                        kolumna.Item().Element(InformacjeNabywcy);

                        decimal lacznaCenaBrutto = 0; 

                        
                        kolumna.Item().Table(tabela =>
                        {
                            tabela.ColumnsDefinition(kolumny =>
                            {
                                kolumny.RelativeColumn(); 
                                kolumny.ConstantColumn(50); 
                                kolumny.ConstantColumn(90); 
                                kolumny.ConstantColumn(90);
                            });

                            
                            tabela.Header(naglowek =>
                            {
                                naglowek.Cell().Element(StylKomorki).Text("Nazwa").Bold();
                                naglowek.Cell().Element(StylKomorki).Text("Ilość").Bold().AlignCenter();
                                naglowek.Cell().Element(StylKomorki).Text("Cena Netto").Bold().AlignCenter();
                                naglowek.Cell().Element(StylKomorki).Text("Cena Brutto").Bold().AlignCenter();
                            });


                            foreach (var produkt in _produkty)
                            {
                                var (item, quantity, priceNetto, priceBrutto) = produkt;

                                tabela.Cell().Element(StylKomorki).Text(item).AlignCenter();
                                tabela.Cell().Element(StylKomorki).Text(quantity.ToString()).AlignCenter();
                                tabela.Cell().Element(StylKomorki).Text(string.Format(new System.Globalization.CultureInfo("pl-PL"), "{0:C}", priceNetto)).AlignCenter();
                                tabela.Cell().Element(StylKomorki).Text(string.Format(new System.Globalization.CultureInfo("pl-PL"), "{0:C}", priceBrutto)).AlignCenter();

                                lacznaCenaBrutto += priceBrutto; 
                            }
                        });

                        
                        kolumna.Item().PaddingTop(10).Column(poleKwoty =>
                        {
                            poleKwoty.Item().AlignRight().Element(StylKomorki2).Text("  ŁĄCZNA CENA:").Bold();
                            poleKwoty.Item().Text($"{lacznaCenaBrutto:C}").FontSize(15).Bold().AlignRight();
                        });
                    });
                });
        }


        private void InformacjeSprzedawcy(IContainer container)
        {
            container
                .Border(1) 
                .BorderColor(Colors.Grey.Medium) 
                .Padding(10) 
                .Column(kolumna =>
                {
                    if (File.Exists(_sciezkaLogo))
                    {
                        var obraz = File.ReadAllBytes(_sciezkaLogo);
                        kolumna.Item()
                            .AlignLeft()
                            .Width(120)
                            .Height(50)
                            .Image(obraz);
                    }
                    else
                    {
                        kolumna.Item().Text("Brak logo").Italic().FontSize(10);
                    }

                    
                    kolumna.Item().Text(_nazwaSprzedawcy).Bold();
                    kolumna.Item().Text("Jana Kilińskiego 4, 80-452 Gdańsk");
                    kolumna.Item().Text("C.H. Metropolia");
                    kolumna.Item().Text("Telefon: 58 770 34 30");
                    kolumna.Item().Text("Email: kserogdansk@wp.pl");
                });
        }


        private void InformacjeNabywcy(IContainer container)
        {
           
            PobierzDaneDoFaktury(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id);



            container
     .Padding(15)
     .Column(kolumna =>
     {
         kolumna.Item().Text("NABYWCA").FontSize(12).Bold();
         kolumna.Item().Text($"Nazwa: {NazwaNabywcy}");
         kolumna.Item().Text($"Adres: {PelnyAdresNabywcy}");
         kolumna.Item().Text($"Sposób zapłaty: {SposobZaplaty}");
         kolumna.Item().Text($"Data wystawienia: {DataWystawienia:dd-MM-yyyy}");
         kolumna.Item().Text($"Data sprzedaży: {DataSprzedazy:dd-MM-yyyy}");

         if (!string.IsNullOrEmpty(NumerNip))
         {

             kolumna.Item().Text($"NIP: {NumerNip}");
         }
         else
         {
             kolumna.Item().Text($"Telefon: {NumerTel}");
         }



     });

        }



        private void InformacjeFaktury(IContainer container)
        {
            string numerFaktury = GlobalClass.FakturaSesja.AktualnaFaktura.invoice_number;

            container.AlignRight().Column(kolumna =>
            {
                kolumna.Item().Text("Faktura").FontSize(20).Bold();
                kolumna.Item().Text($"Numer: {numerFaktury}");
                kolumna.Item().Text($"Data: {DateTime.Now:dd-MM-yyyy}");
            });
        }

        private IContainer StylKomorki(IContainer container)
        {
            return container.Padding(5).Background(Colors.Grey.Lighten3);
        }

        private IContainer StylKomorki2(IContainer container)
        {
            return container.Padding(5).Background(Colors.Grey.Lighten2);
        }

        //private string PobierzNumerFaktury()
        //{
        //    string polaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;
        //    string numerFaktury = "";

        //    using (MySqlConnection polaczenie = new MySqlConnection(polaczenieDB))
        //    {
        //        try
        //        {
        //            polaczenie.Open();

        //            string zapytanie = @"
        //            SELECT CONCAT('FV-', YEAR(NOW()), '-', LPAD(COALESCE(MAX(CAST(SUBSTRING_INDEX(invoice_number, '-', -1) AS UNSIGNED)) + 1, 1), 5, '0')) AS next_invoice_number
        //            FROM serwer197774_drukarnia.invoices
        //            WHERE invoice_number LIKE CONCAT('FV-', YEAR(NOW()), '-%');";

        //            using (MySqlCommand komenda = new MySqlCommand(zapytanie, polaczenie))
        //            {
        //                using (MySqlDataReader reader = komenda.ExecuteReader())
        //                {
        //                    if (reader.Read() && !reader.IsDBNull(0))
        //                    {
        //                        numerFaktury = reader.GetString("next_invoice_number");
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Błąd pobierania numeru faktury: " + ex.Message, "Błąd");
        //        }
        //        finally
        //        {
        //            polaczenie.Close();
        //        }
        //    }

        //    return numerFaktury;
        //}



        public void PobierzDaneDoFaktury(int orderId)
        {
            using (MySqlConnection polaczenie = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie))
            {
                try
                {
                    polaczenie.Open();

                    string pobierzDaneSql = @"
                                    SELECT 
                        o.order_id,
                        o.created_at,
                        -- Pobieranie nazwy klienta z priorytetem na dane firmy
                        CASE 
                            WHEN cd.nip = o.number_nip THEN cd.name
                            ELSE CONCAT(u.first_name, ' ', u.last_name)
                        END AS buyer_name,
                        -- Pobieranie NIP na podstawie number_nip
                        o.number_nip AS buyer_nip,
                        -- Numer telefonu z priorytetem na company_details
                        COALESCE(cd.phone_number, u.phone_number) AS buyer_phone,
                        -- Pełny adres lub ""Odbiór osobisty""
                        CASE 
                            WHEN a.address_id IS NOT NULL THEN 
                                CONCAT(
                                    CASE 
                                        WHEN a.apartment_number IS NULL OR a.apartment_number = '' 
                                        THEN CONCAT(a.street, ' ', a.house_number)
                                        ELSE CONCAT(a.street, ' ', a.house_number, '/', a.apartment_number)
                                    END,
                                    ', ', a.postal_code, ' ', a.city
                                )
                            ELSE 'Odbiór osobisty'
                        END AS full_address
                    FROM orders AS o
                    LEFT JOIN users AS u ON o.user_id = u.user_id
                    LEFT JOIN company_details AS cd ON cd.nip = o.number_nip
                    LEFT JOIN addresses AS a ON o.delivery_address_id = a.address_id
                    WHERE o.order_id = @OrderId;
                         ";

                    using (MySqlCommand cmd = new MySqlCommand(pobierzDaneSql, polaczenie))
                    {
                        cmd.Parameters.AddWithValue("@OrderId", orderId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                NazwaNabywcy = reader["buyer_name"] != DBNull.Value ? reader["buyer_name"].ToString() : "";
                                NumerNip = reader["buyer_nip"] != DBNull.Value ? reader["buyer_nip"].ToString() : "";
                                SposobZaplaty = "Online";
                                DataWystawienia = reader["created_at"] != DBNull.Value ? Convert.ToDateTime(reader["created_at"]) : DateTime.MinValue;
                                PelnyAdresNabywcy = reader["full_address"] != DBNull.Value ? reader["full_address"].ToString() : "";
                                NumerTel = reader["buyer_phone"] != DBNull.Value? reader["buyer_phone"].ToString(): "";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania danych nabywcy: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }
        }




       






    }



}
