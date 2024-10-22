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



    }
}
