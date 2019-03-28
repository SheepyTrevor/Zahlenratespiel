using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Spielsücht.Highscore_Files
{
    public class Dateihandling
    {
        public static void SaveAllToCSV(ref FileStream Datei, List<Highscore_Klasse.Person> Datenstrom)
        {
            using (StreamWriter Writer = new StreamWriter(Datei))
            {
                Writer.WriteLine("Nr;Punkte;Name;Datum;Guthaben");

                for (int i = 0; i < Datenstrom.Count; i++)
                {
                    Writer.WriteLine(Highscore_Klasse.ToString(Datenstrom[i]));
                }
            }

            MessageBox.Show("Daten eingelesen");
        }

        public static string ReadAllLinesToList(FileStream Datei, ref List<Highscore_Klasse.Person> DataList)
        {
            try
            {
                using (StreamReader Reader = new StreamReader(Datei))
                {
                    string Parameter = Reader.ReadLine();

                    while (!Reader.EndOfStream)
                    {
                        DataList.Add(Highscore_Klasse.ToStruct(Reader.ReadLine()));
                    }
                    return Parameter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }
    }
}
