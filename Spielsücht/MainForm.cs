using System;
using System.IO;
using System.Windows.Forms;

namespace Spielsücht
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double Aktuelles_Guthaben = Properties.Settings.Default.Aktueller_Kontostand;
        double Einsatz = 0;
        Int64 Maxímaler_Einsatz = Int64.MaxValue;
        int Zahl_Nutzer = 0;
        Random zufall = new Random();
        string Aktuelle_Schwierigkeit = "Leicht";
        int Maximal_Random = 11;
        double Zufallszahl_zusatzgewinn1 = 0;
        double Zufallszahl_zusatzgewinn2 = 0;
        double Verzinsung;
        double zusatzgewinn;
        double Bonus;
        double Verlorer_Einsatz_haelfte = 0;
        int Zaeler_Gewinn = 0;
        string csvDateiName;
        string AppDataPfad;
        FileInfo csvDateiInfo;

        private void Button1Click(object sender, EventArgs e)
        {
            int Zahl_Zufall = zufall.Next(1, Maximal_Random);
            string Einsatz_Text = txtBox_Einsatz.Text;
            csvDateiName = "Highscore_Spiel1.csv";
            AppDataPfad = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Spielsücht\Spielsücht";
            csvDateiInfo = new FileInfo(AppDataPfad + @"\" + csvDateiName);
            //MessageBox.Show(AppDataPfad + "\n" + csvDateiInfo.FullName);

            Zahl_Nutzer = Convert.ToInt32(txtBox_Zahl_Nutzer.Text);
            Einsatz = Convert.ToDouble(txtBox_Einsatz.Text);

            if (Einsatz >= Maxímaler_Einsatz)
            {
                MessageBox.Show("Der höchst mögliche Einsatz beträgt:\n" + string.Format("{0:c}", Maxímaler_Einsatz));
                return;
            }

            lbl_Ergebnis.Text = "Letztes Ergebnis: " + Zahl_Zufall;

            if (Zahl_Zufall == Zahl_Nutzer)
            {
                Zufallszahl_zusatzgewinn1 = Math.Round(zufall.NextDouble(), 2);
                Zufallszahl_zusatzgewinn2 = Math.Round(zufall.NextDouble(), 2);
                Zufallszahl_zusatzgewinn1 = 1;      //Für Testzwecke
                Zufallszahl_zusatzgewinn2 = 1;      //Für Testzwecke
                Properties.Settings.Default.Gewonnen++;
                Properties.Settings.Default.Save();
                Zaeler_Gewinn++;

                if (checkBox1.Checked)
                {
                    if (Zufallszahl_zusatzgewinn2 == 0.2 || Zufallszahl_zusatzgewinn2 == 0.4 || Zufallszahl_zusatzgewinn2 == 0.8 || Zufallszahl_zusatzgewinn2 == 0.9 || Zufallszahl_zusatzgewinn2 == 1)
                        zusatzgewinn = Zufallszahl_zusatzgewinn2 * Einsatz;
                }

                if (Zufallszahl_zusatzgewinn1 == 0.2 || Zufallszahl_zusatzgewinn1 == 0.8 || Zufallszahl_zusatzgewinn1 == 1)
                {
                    if (checkBox1.Checked)
                    {
                        Bonus = (Zufallszahl_zusatzgewinn1 + (Zufallszahl_zusatzgewinn1 + Zufallszahl_zusatzgewinn2)) / 0.33 * Einsatz;
                        MessageBox.Show("Gewonnen! Du erhälst sogar einen kleinen Bonus in höhe von " + string.Format("{0:0%}", (Zufallszahl_zusatzgewinn1 + (Zufallszahl_zusatzgewinn1 + Zufallszahl_zusatzgewinn2)) / 0.33) + "\nvon deinem eingesetzten Wert.\nDer Bonus hat einen Betrag von: " + string.Format("{0:c}", Bonus));
                        zusatzgewinn += Bonus;
                    }
                    else
                    {
                        Bonus = Zufallszahl_zusatzgewinn1 * Einsatz;
                        MessageBox.Show("Gewonnen! Du erhälst sogar einen kleinen Bonus in höhe von " + string.Format("{0:0%}", Zufallszahl_zusatzgewinn1) + "\nvon deinem eingesetzten Wert.\nDer Bonus hat einen Betrag von: " + string.Format("{0:c}", Bonus));
                        zusatzgewinn += Bonus;
                    }

                    Aktuelles_Guthaben += Math.Round(zusatzgewinn, 2);
                    zusatzgewinn = 0;
                }
                else
                {
                    MessageBox.Show("Gewonnen. Aber leider keinen Zusatzgewinn erhalten.\nDie Zufallszahl war: " + Zufallszahl_zusatzgewinn1.ToString());
                    Aktuelles_Guthaben = Aktuelles_Guthaben + Einsatz;
                }
            }
            else
            {
                if (checkBox1.Checked)
                {
                    Verlorer_Einsatz_haelfte = Aktuelles_Guthaben / 2 + Einsatz;
                }

                if (Aktuelles_Guthaben < 0)
                {
                    int Verzinster_Einsatz = Convert.ToInt32(Einsatz * Verzinsung + Einsatz);
                    if (Aktuelles_Guthaben <= -100)
                    {
                        if (checkBox1.Checked)
                            Aktuelles_Guthaben -= Verzinster_Einsatz + Verlorer_Einsatz_haelfte;
                        else
                            Aktuelles_Guthaben -= Verzinster_Einsatz;

                        MessageBox.Show("Du hast das komplette Spiel verloren.\nDein Guthaben beträgt: " + string.Format("{0:c}", Aktuelles_Guthaben) + "\nEin neues Spiel wird gestartet.");
                        Aktuelles_Guthaben = 1000;
                        Properties.Settings.Default.Spiel_beendet++;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        if (checkBox1.Checked)
                            Aktuelles_Guthaben -= Verzinster_Einsatz - Verlorer_Einsatz_haelfte;
                        else
                            Aktuelles_Guthaben -= Verzinster_Einsatz;

                        MessageBox.Show(string.Format("{0:c}", Verzinster_Einsatz) + " Wurde ihnen durch Schulden und Zinsen abgezogen.\nDie Zinsen betragen einen Wert von: " + string.Format("{0:c}", Einsatz * Verzinsung));
                    }
                }
                else
                {
                    MessageBox.Show("Verloren");

                    if (checkBox1.Checked)
                        Aktuelles_Guthaben -= Einsatz + Verlorer_Einsatz_haelfte;
                    else
                        Aktuelles_Guthaben -= Einsatz;

                    Properties.Settings.Default.Verloren++;
                    Properties.Settings.Default.Save();
                }

                string lines = Properties.Settings.Default.score_Nr_Spiel_1.ToString() + ";" + Zaeler_Gewinn + ";" + Properties.Settings.Default.Name + ";" + DateTime.Now.ToString() + ";" + Aktuelles_Guthaben;

                using (StreamWriter file = new StreamWriter(csvDateiInfo.FullName, true))
                {
                    file.WriteLine(lines);
                }

                Properties.Settings.Default.score_Nr_Spiel_1++;
                Properties.Settings.Default.Save();
                Zaeler_Gewinn = 0;
            }

            Properties.Settings.Default.Aktueller_Kontostand = Aktuelles_Guthaben;
            Properties.Settings.Default.Save();
            lbl_Guthaben.Text = "Guthaben: " + string.Format("{0:c}", Aktuelles_Guthaben);
        }

        private void TxtBox_Zahl_NutzerTextChanged(object sender, EventArgs e)
        {
            if (txtBox_Einsatz.TextLength > 0 && txtBox_Zahl_Nutzer.TextLength > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.time_an)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;

            if (Properties.Settings.Default.Schwierigkeit == "Leicht")
            {
                Aktuelle_Schwierigkeit = "Leicht";
                Verzinsung = 0.05;
                radioBtn_Leicht.Checked = true;
            }

            if (Properties.Settings.Default.Schwierigkeit == "Mittel")
            {
                Aktuelle_Schwierigkeit = "Mittel";
                Verzinsung = 0.19;
                radioBtn_Mittel.Checked = true;
            }

            if (Properties.Settings.Default.Schwierigkeit == "Schwer")
            {
                Aktuelle_Schwierigkeit = "Schwer";
                Verzinsung = 0.40;
                radioBtn_Schwer.Checked = true;
            }

            lbl_Schwierigkeit.Text = "Schwierigkeit: (von 1 bis " + (Maximal_Random - 1) + " && " + string.Format("{0:0%}", Verzinsung) + ")";

            lbl_Guthaben.Text = "Guthaben: " + string.Format("{0:c}", Aktuelles_Guthaben);
        }

        private void RadioBtn_SchwerCheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_Schwer.Checked)
            {
                Aktuelle_Schwierigkeit = "Schwer";
                Properties.Settings.Default.Schwierigkeit = "Schwer";
                Properties.Settings.Default.Save();
                Maximal_Random = 101;
                Verzinsung = 0.40;
                //Maximal_Random = 2;     //Für Testzwecke
                lbl_Schwierigkeit.Text = "Schwierigkeit: (von 1 bis " + (Maximal_Random - 1) + " && " + string.Format("{0:0%}", Verzinsung) + ")";
            }

        }

        private void RadioBtn_MittelCheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_Mittel.Checked)
            {
                Aktuelle_Schwierigkeit = "Mittel";
                Properties.Settings.Default.Schwierigkeit = "Mittel";
                Properties.Settings.Default.Save();
                Maximal_Random = 21;
                Verzinsung = 0.19;
                //Maximal_Random = 2;     //Für Testzwecke
                lbl_Schwierigkeit.Text = "Schwierigkeit: (von 1 bis " + (Maximal_Random - 1) + " && " + string.Format("{0:0%}", Verzinsung) + ")";
            }

        }

        private void RadioBtn_LeichtCheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_Leicht.Checked)
            {
                Aktuelle_Schwierigkeit = "Leicht";
                Properties.Settings.Default.Schwierigkeit = "Leicht";
                Properties.Settings.Default.Save();
                Maximal_Random = 11;
                Verzinsung = 0.05;
                //Maximal_Random = 2;     //Für Testzwecke
                lbl_Schwierigkeit.Text = "Schwierigkeit: (von 1 bis " + (Maximal_Random - 1) + " && " + string.Format("{0:0%}", Verzinsung) + ")";
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string All_in = Aktuelles_Guthaben.ToString();
            txtBox_Einsatz.Text = All_in.Replace("-", "");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            txtBox_Zahl_Nutzer.Text = zufall.Next(1, Maximal_Random).ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Aktuelles_Guthaben = Properties.Settings.Default.Aktueller_Kontostand;
            lbl_Guthaben.Text = "Guthaben: " + string.Format("{0:c}", Aktuelles_Guthaben);
        }

        private void txtBox_Zahl_Nutzer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}