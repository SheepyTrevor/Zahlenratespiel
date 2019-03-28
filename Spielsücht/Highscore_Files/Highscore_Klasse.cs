using System;

namespace Spielsücht.Highscore_Files
{
    public class Highscore_Klasse
    {
        public struct Person
        {
            public int Nr;
            public int Punkte;
            public string Name;
            public string Datum;
        }

        static char[] trennenMit = new char[1] { Trennzeichen.Semikolon };

        public static Person ToStruct(string Zeile)
        {
            string[] daten = Zeile.Split(trennenMit);

            Person rückGabeStruktur;
            rückGabeStruktur.Nr = Convert.ToInt32(daten[0]);
            rückGabeStruktur.Punkte = Convert.ToInt32(daten[1]);
            rückGabeStruktur.Name = daten[2];
            rückGabeStruktur.Datum = daten[3];

            return rückGabeStruktur;
        }

        public static string ToString(Person Kontakt)
        {
            string zeile;

            zeile = Kontakt.Nr.ToString() + Trennzeichen.Semikolon + Kontakt.Punkte.ToString() + Trennzeichen.Semikolon + Kontakt.Name + Trennzeichen.Semikolon + Kontakt.Datum;
            return zeile;
        }
    }
}
