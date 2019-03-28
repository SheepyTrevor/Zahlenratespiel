using System;
using System.IO;
using System.Windows.Forms;

namespace Spielsücht
{
    public partial class MainForm_Multiplayer : Form
    {
        public MainForm_Multiplayer()
        {
            InitializeComponent();
        }

        int Zahl_Spieler1;
        int Zahl_Spieler2;
        Random zufall = new Random();
        bool godzilla = false;
        string csvDateiName;
        string AppDataPfad;
        FileInfo csvDateiInfo;

        void auswahl(int wechsel)
        {
            switch (wechsel)
            {
                case 1:
                    {

                        try
                        {
                            Zahl_Spieler1 = Convert.ToInt32(txtBox_Zahl_Nutzer.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bitte keinen text eingeben.\n" + "Ebendfalls bitte das maximum: " + string.Format("{0:0,0}", Int32.MaxValue) + " beachten.");
                            button1.Enabled = false;
                            return;
                        }

                        lbl_Zahl.Text = "Zahl (2):";
                        if (godzilla == true)
                            lbl_Godzilla.Visible = true;
                        lbl_Godzilla.Text = "Versuch es mit: " + string.Format("{0:0,0}", Zahl_Spieler1);
                        godzilla = false;
                        txtBox_Zahl_Nutzer.Clear();
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            Zahl_Spieler2 = Convert.ToInt32(txtBox_Zahl_Nutzer.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bitte keinen text eingeben.\n" + "Ebendfalls bitte das maximum: " + string.Format("{0:0,0}", Int32.MaxValue) + " beachten.");
                            button1.Enabled = false;
                            return;
                        }

                        auswahl(3);
                        break;
                    }
                case 3:
                    {
                        if (Zahl_Spieler1 == Zahl_Spieler2)
                        {
                            MessageBox.Show("Die Zahl: " + string.Format("{0:0,0}", Zahl_Spieler1) + " hast du korrekt erraten.");
                            Zahl_Spieler1 = 0;
                            Zahl_Spieler1 = 0;
                            lbl_Zahl.Text = "Zahl (1):";
                            txtBox_Zahl_Nutzer.Clear();
                            lbl_Godzilla.Visible = false;
                            Properties.Settings.Default.Gewonnen++;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Die geratene Zahl " + string.Format("{0:0,0}", Zahl_Spieler1) + " war leider falsch.\nNochmal versuchen?", "Hinweis", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                Zahl_Spieler1 = 0;
                                Zahl_Spieler1 = 0;
                                lbl_Zahl.Text = "Zahl (1):";
                                txtBox_Zahl_Nutzer.Clear();
                                Properties.Settings.Default.Verloren++;
                                Properties.Settings.Default.Save();
                            }
                        }
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox_Zahl_Nutzer.Text == "Godzilla" || txtBox_Zahl_Nutzer.Text == "godzilla")
            {
                godzilla = true;
                txtBox_Zahl_Nutzer.Clear();
            }
            else
            {
                if (lbl_Zahl.Text == "Zahl (1):")
                    auswahl(1);
                else if (lbl_Zahl.Text == "Zahl (2):")
                    auswahl(2);
            }
        }

        private void txtBox_Zahl_Nutzer_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_Zahl_Nutzer.TextLength > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBox_Zahl_Nutzer.Text = zufall.Next(1, Int32.MaxValue).ToString();
        }

        private void MainForm_Multiplayer_Load(object sender, EventArgs e)
        {
            csvDateiName = "Highscore_Spiel1.csv";
            AppDataPfad = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Spielsücht\Spielsücht";
            csvDateiInfo = new FileInfo(AppDataPfad + @"\" + csvDateiName);
        }
    }
}
