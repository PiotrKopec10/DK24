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
                    strona.Margin(30);

                    strona.Header().Row(wiersz =>
                    {
                        wiersz.RelativeColumn().Element(InformacjeSprzedawcy);
                        wiersz.ConstantColumn(200).Element(InformacjeFaktury);
                    });

                    strona.Content()
                        .Column(kolumna =>
                        {
                            kolumna.Spacing(20);
                            kolumna.Item().Element(InformacjeNabywcy); // Sekcja Nabywca
                            kolumna.Item().Table(tabela =>
                            {
                                tabela.ColumnsDefinition(kolumny =>
                                {
                                    kolumny.RelativeColumn(); // Nazwa
                                    kolumny.ConstantColumn(50); // Ilość
                                    kolumny.ConstantColumn(70); // Cena Brutto
                                    kolumny.ConstantColumn(70); // Cena Netto
                                });

                                tabela.Header(naglowek =>
                                {
                                    naglowek.Cell().Element(StylKomorki).Text("Nazwa").Bold();
                                    naglowek.Cell().Element(StylKomorki).Text("Ilość").Bold();
                                    naglowek.Cell().Element(StylKomorki).Text("Cena Brutto").Bold();
                                    naglowek.Cell().Element(StylKomorki).Text("Cena Netto").Bold();
                                });

                                foreach (var (item, quantity, priceBrutto, priceNetto) in _produkty)
                                {
                                    tabela.Cell().Element(StylKomorki).Text(item);
                                    tabela.Cell().Element(StylKomorki).Text(quantity.ToString());
                                    tabela.Cell().Element(StylKomorki).Text($"{priceBrutto:C}");
                                    tabela.Cell().Element(StylKomorki).Text($"{priceNetto:C}");
                                }
                            });
                        });
                });
        }


        private void InformacjeSprzedawcy(IContainer container)
        {
            container
                .Border(1) // Ustawienie obramowania
                .BorderColor(Colors.Grey.Medium) // Kolor obramowania
                .Padding(10) // Odstęp między ramką a zawartością
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

                    // Dane sprzedawcy
                    kolumna.Item().Text(_nazwaSprzedawcy).Bold();
                    kolumna.Item().Text("aleja Grunwaldzka 82, Gdańsk Wrzeszcz, 80-244");
                    kolumna.Item().Text("C.H. Manhattan");
                    kolumna.Item().Text("Telefon: 58 770 34 30");
                    kolumna.Item().Text("Email: kserogdansk@wp.pl");
                });
        }


        private void InformacjeNabywcy(IContainer container)
        {
            container
                .Padding(15)
                .Column(kolumna =>
                {
                    kolumna.Item().Text("NABYWCA").FontSize(12).Bold();
                    kolumna.Item().Text("Nazwa: Jan Kowalski");
                    kolumna.Item().Text("Adres: ul. Przykładowa 123, 80-244 Gdańsk");
                    kolumna.Item().Text("Sposób zapłaty: Przelew");
                    kolumna.Item().Text("Data wystawienia: 08-01-2025");
                    kolumna.Item().Text("Data sprzedaży: 08-01-2025");
                    kolumna.Item().Text("NIP: 123-456-78-90");
                });
        }



        private void InformacjeFaktury(IContainer container)
        {
            string numerFaktury = PobierzNumerFaktury();

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

        private string PobierzNumerFaktury()
        {
            string polaczenieDB = GlobalClass.GlobalnaZmienna.DBPolaczenie;
            string numerFaktury = "";

            using (MySqlConnection polaczenie = new MySqlConnection(polaczenieDB))
            {
                try
                {
                    polaczenie.Open();

                    string zapytanie = @"
                    SELECT CONCAT('FV-', YEAR(NOW()), '-', LPAD(COALESCE(MAX(CAST(SUBSTRING_INDEX(invoice_number, '-', -1) AS UNSIGNED)) + 1, 1), 5, '0')) AS next_invoice_number
                    FROM serwer197774_drukarnia.invoices
                    WHERE invoice_number LIKE CONCAT('FV-', YEAR(NOW()), '-%');";

                    using (MySqlCommand komenda = new MySqlCommand(zapytanie, polaczenie))
                    {
                        using (MySqlDataReader reader = komenda.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(0))
                            {
                                numerFaktury = reader.GetString("next_invoice_number");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania numeru faktury: " + ex.Message, "Błąd");
                }
                finally
                {
                    polaczenie.Close();
                }
            }

            return numerFaktury;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
    }
}
