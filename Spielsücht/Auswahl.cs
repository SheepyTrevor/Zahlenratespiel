using System;
using System.IO;
using System.Windows.Forms;

namespace Spielsücht
{
    public partial class Auswahl : Form
    {
        public Auswahl()
        {
            InitializeComponent();
        }

        public string Name_Nutzer = string.Empty;
        FileInfo csvDateiInfo;
        string csvDateiName;
        string AppDataPfad;

        private void Button1_Click(object sender, EventArgs e)
        {
            MainForm FormZahlenraten_Einzelspieler = new MainForm();
            Zahlenbereich_raten FormBereich_raten = new Zahlenbereich_raten();
            Highscore FormHighscore = new Highscore();
            MainForm_Multiplayer FormZahlenraten_Mehrspieler = new MainForm_Multiplayer();

            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Bitte einen Namen für die Highscore Liste eingeben.");
                return;
            }

            try
            {
                if (checkBox_Zr_E_ES.Checked)
                    FormZahlenraten_Einzelspieler.Show();

                if (checkBox_Zr_B_ES.Checked)
                    FormBereich_raten.Show();

                if (checkBox_Highscore.Checked)
                    FormHighscore.Show();

                if (checkBox_Zr_E_MS.Checked)
                    FormZahlenraten_Mehrspieler.Show();

                Name_Nutzer = textBox1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten:\n" + ex.ToString());
                return;
            }
        }

        private void Auswahl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Auswahl_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Name;
            csvDateiName = "Highscore_Spiel1.csv";

            AppDataPfad = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Spielsücht\Spielsücht";

            csvDateiInfo = new FileInfo(AppDataPfad + @"\" + csvDateiName);
            int Spielnummer = 0;

            if (Properties.Settings.Default.time_an)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;

            for (int i = 0; i <= 4; i++)
            {
                if (!File.Exists(csvDateiInfo.ToString()))
                {
                    Directory.CreateDirectory(AppDataPfad);
                    using (StreamWriter file = new StreamWriter(csvDateiInfo.ToString(), true))
                    {
                        file.WriteLine("Nr;Punkte;Name;Datum;Guthaben");
                    }
                }
                Spielnummer++;
                csvDateiName = "Highscore_Spiel" + Spielnummer + ".csv";
                csvDateiInfo = new FileInfo(AppDataPfad + @"\" + csvDateiName);
            }

            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(checkBox_Zr_E_ES, "Ein kleines Spiel um zu raten welche Zahl der NPC geraten hat.");
            ToolTip1.SetToolTip(checkBox_Zr_B_ES, "Ein kleines Spiel um zu raten im welchem Bereich die Zahl des NPC liegt.");
            ToolTip1.SetToolTip(checkBox_Zr_E_MS, "Ein kleines Spiel um zu raten welche Zahl der andere Spieler geraten hat.");
            ToolTip1.SetToolTip(checkBox_Highscore, "Eine Highscore Liste für jedes einzelne Spiel");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Über FormÜber = new Über();
            FormÜber.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double Aktuelles_Guthaben = Properties.Settings.Default.Aktueller_Kontostand;
            Text = "Auswahl - Wetten dass du verlierst? | " + string.Format("{0:c}", Aktuelles_Guthaben);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Statistiken FormStats = new Statistiken();
            FormStats.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Name = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
