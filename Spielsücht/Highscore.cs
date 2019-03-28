using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Spielsücht
{
    public partial class Highscore : Form
    {
        List<Highscore_Files.Highscore_Klasse.Person> Liste;

        string csvDateiName;
        string AppDataPfad;
        FileStream csvDatei;
        FileInfo csvDateiInfo;
        int Spielnummer = 1;

        public Highscore()
        {
            InitializeComponent();
        }

        void Breite()
        {
            int Data_Grid_breite = dataGridView1.Width;
            int Breite = Data_Grid_breite / 4;

            Column_Nr.Width = Breite;
            Column_Punkte.Width = Breite;
            Column_Name.Width = Breite;
            Column_Datum.Width = Breite;
            Column_Guthaben.Width = Breite;
        }

        void Anzeigen()
        {
            try
            {
                csvDateiName = "Highscore_Spiel" + Spielnummer + ".csv";
                AppDataPfad = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Spielsücht\Spielsücht";
                csvDateiInfo = new FileInfo(AppDataPfad + @"\" + csvDateiName);

                csvDatei = new FileStream(csvDateiInfo.FullName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

                Liste = new List<Highscore_Files.Highscore_Klasse.Person>();

                Highscore_Files.Dateihandling.ReadAllLinesToList(csvDatei, ref Liste);

                showKontakteToGridView(Liste);  //Die Datei im Grid anzeigen
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("Es ist ein Fehler aufgetreten.\nDie Datei: " + csvDateiName + " wurde nicht gefunden\nSoll die Datei neu ersetllt werden?", "Hinweis", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (StreamWriter file = new StreamWriter(csvDateiInfo.ToString(), false))
                    {
                        file.WriteLine("Nr;Punkte;Name;Datum;Guthaben");
                    }

                    MessageBox.Show("Die Datei: " + csvDateiName + " wurde erfolgreich erstellt.");
                }
                else
                    MessageBox.Show("Es wurde keine neue Datei erstellt.");
            }
        }

        private void showKontakteToGridView(List<Highscore_Files.Highscore_Klasse.Person> KontaktListe)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < KontaktListe.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = KontaktListe[i].Nr;
                dataGridView1.Rows[i].Cells[1].Value = KontaktListe[i].Punkte;
                dataGridView1.Rows[i].Cells[2].Value = KontaktListe[i].Name;
                dataGridView1.Rows[i].Cells[3].Value = KontaktListe[i].Datum;
            }
        }

        private void Highscore_Load(object sender, EventArgs e)
        {
            Anzeigen();
            Breite();
        }

        private void Highscore_Resize(object sender, EventArgs e)
        {
            Breite();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anzeigen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten sie den kompletten inhalt der csv Datei löschen?", "Hinweis", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (StreamWriter file = new StreamWriter(csvDateiInfo.ToString(), false))
                {
                    file.WriteLine("Nr;Punkte;Name;Datum;Guthaben");
                }

                if (Spielnummer == 1)
                {
                    Properties.Settings.Default.score_Nr_Spiel_1 = 1;
                    Properties.Settings.Default.Save();
                }

                if (Spielnummer == 2)
                {
                    Properties.Settings.Default.score_Nr_Spiel_2 = 1;
                    Properties.Settings.Default.Save();
                }

                if (Spielnummer == 3)
                {
                    Properties.Settings.Default.score_Nr_Spiel_3 = 1;
                    Properties.Settings.Default.Save();
                }

                if (Spielnummer == 4)
                {
                    Properties.Settings.Default.score_Nr_Spiel_4 = 1;
                    Properties.Settings.Default.Save();
                }
            }
            Anzeigen();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Spielnummer = 1;
                Anzeigen();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Spielnummer = 2;
                Anzeigen();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Spielnummer = 3;
                Anzeigen();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Spielnummer = 4;
                Anzeigen();
            }
        }
    }
}
