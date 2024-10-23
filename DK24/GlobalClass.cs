using System.Text.RegularExpressions;

namespace DK24
{
    internal class GlobalClass
    {
        public static class GlobalnaZmienna
        {
            public static readonly string DBPolaczenie =
                  "SERVER=sql98.lh.pl;" +
                "DATABASE=serwer197774_drukarnia;" +
                "UID=serwer197774_drukarnia;" +
                "PASSWORD=Zu41Xut!C1;";
        }

        public string WyczyscTekst(string TekstDoWyczyszczenia)
        {
            TekstDoWyczyszczenia = TekstDoWyczyszczenia.Trim();
            return Regex.Replace(TekstDoWyczyszczenia, @"[,;:/|=+*^%$#\\]", string.Empty);

        }


        public List<(string Kraj, string NumerKierunkowy, string Skrot)> SpisPanstwNrKierunkowych()
        {
            return new List<(string Kraj, string NumerKierunkowy, string Skrot)>()
    {
        ("Afganistan", "+93", "AF"), ("Alaska", "+1907", "US"), ("Albania", "+355", "AL"),
        ("Algieria", "+213", "DZ"), ("Andora", "+376", "AD"), ("Angola", "+244", "AO"),
        ("Antyle Holenderskie", "+599", "AN"), ("Arabia Saudyjska", "+966", "SA"),
        ("Argentyna", "+54", "AR"), ("Armenia", "+374", "AM"), ("Australia", "+61", "AU"),
        ("Austria", "+43", "AT"), ("Azerbejdżan", "+994", "AZ"), ("Bahrajn", "+973", "BH"),
        ("Bangladesz", "+880", "BD"), ("Belgia", "+32", "BE"), ("Benin", "+229", "BJ"),
        ("Białoruś", "+375", "BY"), ("Boliwia", "+591", "BO"), ("Bośnia i Hercegowina", "+387", "BA"),
        ("Botswana", "+267", "BW"), ("Brazylia", "+55", "BR"), ("Brunei", "+673", "BN"),
        ("Bułgaria", "+359", "BG"), ("Burkina Faso", "+226", "BF"), ("Burundi", "+257", "BI"),
        ("Chile", "+56", "CL"), ("Chiny", "+86", "CN"), ("Chorwacja", "+385", "HR"),
        ("Cypr", "+357", "CY"), ("Czechy", "+420", "CZ"), ("Dania", "+45", "DK"),
        ("Egipt", "+20", "EG"), ("Ekwador", "+593", "EC"), ("Estonia", "+372", "EE"),
        ("Finlandia", "+358", "FI"), ("Francja", "+33", "FR"), ("Grecja", "+30", "GR"),
        ("Hiszpania", "+34", "ES"), ("Holandia", "+31", "NL"), ("Indie", "+91", "IN"),
        ("Irak", "+964", "IQ"), ("Iran", "+98", "IR"), ("Irlandia", "+353", "IE"),
        ("Islandia", "+354", "IS"), ("Izrael", "+972", "IL"), ("Japonia", "+81", "JP"),
        ("Kanada", "+1", "CA"), ("Kazachstan", "+7", "KZ"), ("Kenia", "+254", "KE"),
        ("Korea Południowa", "+82", "KR"), ("Kuwejt", "+965", "KW"), ("Laos", "+856", "LA"),
        ("Liban", "+961", "LB"), ("Libia", "+218", "LY"), ("Litwa", "+370", "LT"),
        ("Luksemburg", "+352", "LU"), ("Łotwa", "+371", "LV"), ("Meksyk", "+52", "MX"),
        ("Niemcy", "+49", "DE"), ("Norwegia", "+47", "NO"), ("Nowa Zelandia", "+64", "NZ"),
        ("Pakistan", "+92", "PK"), ("Polska", "+48", "PL"), ("Portugalia", "+351", "PT"),
        ("Rosja", "+7", "RU"), ("Rumunia", "+40", "RO"), ("Stany Zjednoczone Ameryki", "+1", "US"),
        ("Szwajcaria", "+41", "CH"), ("Szwecja", "+46", "SE"), ("Węgry", "+36", "HU"),
        ("Wielka Brytania", "+44", "GB"), ("Włochy", "+39", "IT")
    };
        }
        public void PowiązKrajINumer(ComboBox cmbKraj, ComboBox cmbPrefixNrTel)
        {
            var spisPanstwNrKierunkowych = SpisPanstwNrKierunkowych();

            var kraj = spisPanstwNrKierunkowych.FirstOrDefault(x => x.Kraj == cmbKraj.Text || x.Skrot == cmbKraj.Text);
            if (kraj != default)
            {
                cmbPrefixNrTel.Text = kraj.NumerKierunkowy;
            }
            else
            {
                var numer = spisPanstwNrKierunkowych.FirstOrDefault(x => x.NumerKierunkowy == cmbPrefixNrTel.Text);
                if (numer != default)
                {
                    cmbKraj.Text = numer.Kraj;
                }
            }
        }

    }
}
