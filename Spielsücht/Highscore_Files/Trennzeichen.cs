namespace Spielsücht.Highscore_Files
{
    public static class Trennzeichen
    {
        public static char Semikolon                                // statische Eigenschaft der Klasse Trennzeichen
        {
            get
            {
                return ';';
            }
            set { }
        }
        public static char Komma
        {
            get
            {
                return ',';
            }
            set
            { }
        }                                                           // statische Eigenschaft der Klasse Trennzeichen
        public static char Punkt                                    // statische Eigenschaft der Klasse Trennzeichen
        {
            get
            {
                return '.';
            }
            set { }
        }
        public const char Doppelpunkt = ':';                        // bereit gestellte Konstante der Klasse Trennzeichen
        public const char Strich = '|';                             // bereit gestellte Konstante der Klasse Trennzeichen
    }
}
