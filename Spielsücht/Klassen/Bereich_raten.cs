namespace Spielsücht.Klassen
{
    public class Bereich_raten
    {
        public static bool Double_o_seven(int Zahl, int Bereich_Auswahl)
        {
            //1 = 1 - 007, 2 = 8 - 10, 3 = 11 - 15, 4 = 16 - 20

            bool Ergebnis;
            if (Zahl >= 1 && Zahl <= 7 && Bereich_Auswahl == 1)
            {
                Ergebnis = true;
            }
            else if (Zahl >= 8 && Zahl <= 10 && Bereich_Auswahl == 2)
            {
                Ergebnis = true;
            }
            else if (Zahl >= 11 && Zahl <= 15 && Bereich_Auswahl == 3)
            {
                Ergebnis = true;
            }
            else if (Zahl >= 16 && Zahl <= 20 && Bereich_Auswahl == 4)
            {
                Ergebnis = true;
            }
            else
            {
                Ergebnis = false;
            }

            return Ergebnis;
        }
    }
}
