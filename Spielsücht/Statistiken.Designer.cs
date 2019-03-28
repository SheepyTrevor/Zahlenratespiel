namespace Spielsücht
{
    partial class Statistiken
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Guthaben = new System.Windows.Forms.Label();
            this.lbl_Gewonnen = new System.Windows.Forms.Label();
            this.lbl_Verloren = new System.Windows.Forms.Label();
            this.lbl_Spiel_beendet = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_GV = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Guthaben
            // 
            this.lbl_Guthaben.AutoSize = true;
            this.lbl_Guthaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Guthaben.Location = new System.Drawing.Point(12, 12);
            this.lbl_Guthaben.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_Guthaben.Name = "lbl_Guthaben";
            this.lbl_Guthaben.Size = new System.Drawing.Size(136, 17);
            this.lbl_Guthaben.TabIndex = 0;
            this.lbl_Guthaben.Text = "Aktuelles Guthaben:";
            // 
            // lbl_Gewonnen
            // 
            this.lbl_Gewonnen.AutoSize = true;
            this.lbl_Gewonnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Gewonnen.Location = new System.Drawing.Point(12, 32);
            this.lbl_Gewonnen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_Gewonnen.Name = "lbl_Gewonnen";
            this.lbl_Gewonnen.Size = new System.Drawing.Size(80, 17);
            this.lbl_Gewonnen.TabIndex = 1;
            this.lbl_Gewonnen.Text = "Gewonnen:";
            // 
            // lbl_Verloren
            // 
            this.lbl_Verloren.AutoSize = true;
            this.lbl_Verloren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Verloren.Location = new System.Drawing.Point(12, 52);
            this.lbl_Verloren.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_Verloren.Name = "lbl_Verloren";
            this.lbl_Verloren.Size = new System.Drawing.Size(66, 17);
            this.lbl_Verloren.TabIndex = 2;
            this.lbl_Verloren.Text = "Verloren:";
            // 
            // lbl_Spiel_beendet
            // 
            this.lbl_Spiel_beendet.AutoSize = true;
            this.lbl_Spiel_beendet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Spiel_beendet.Location = new System.Drawing.Point(12, 72);
            this.lbl_Spiel_beendet.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_Spiel_beendet.Name = "lbl_Spiel_beendet";
            this.lbl_Spiel_beendet.Size = new System.Drawing.Size(107, 17);
            this.lbl_Spiel_beendet.TabIndex = 3;
            this.lbl_Spiel_beendet.Text = "Spiele beendet:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbl_GV
            // 
            this.lbl_GV.AutoSize = true;
            this.lbl_GV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_GV.Location = new System.Drawing.Point(12, 92);
            this.lbl_GV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_GV.Name = "lbl_GV";
            this.lbl_GV.Size = new System.Drawing.Size(146, 17);
            this.lbl_GV.TabIndex = 4;
            this.lbl_GV.Text = "Gewonnen / Verloren:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(15, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zurücksetzten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Statistiken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_GV);
            this.Controls.Add(this.lbl_Spiel_beendet);
            this.Controls.Add(this.lbl_Verloren);
            this.Controls.Add(this.lbl_Gewonnen);
            this.Controls.Add(this.lbl_Guthaben);
            this.MaximumSize = new System.Drawing.Size(300, 190);
            this.MinimumSize = new System.Drawing.Size(300, 190);
            this.Name = "Statistiken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiken - Wetten dass du verlierst?";
            this.Load += new System.EventHandler(this.Statistiken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Guthaben;
        private System.Windows.Forms.Label lbl_Gewonnen;
        private System.Windows.Forms.Label lbl_Verloren;
        private System.Windows.Forms.Label lbl_Spiel_beendet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_GV;
        private System.Windows.Forms.Button button1;
    }
}