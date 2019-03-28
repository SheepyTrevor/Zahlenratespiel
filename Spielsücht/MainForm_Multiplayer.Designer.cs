namespace Spielsücht
{
    partial class MainForm_Multiplayer
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_Guthaben = new System.Windows.Forms.Label();
            this.lbl_Zahl = new System.Windows.Forms.Label();
            this.txtBox_Zahl_Nutzer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_Einsatz = new System.Windows.Forms.TextBox();
            this.lbl_Godzilla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(187, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Zufällig";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(187, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "All In";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbl_Guthaben
            // 
            this.lbl_Guthaben.AutoSize = true;
            this.lbl_Guthaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Guthaben.Location = new System.Drawing.Point(12, 9);
            this.lbl_Guthaben.Name = "lbl_Guthaben";
            this.lbl_Guthaben.Size = new System.Drawing.Size(75, 17);
            this.lbl_Guthaben.TabIndex = 25;
            this.lbl_Guthaben.Text = "Guthaben:";
            // 
            // lbl_Zahl
            // 
            this.lbl_Zahl.AutoSize = true;
            this.lbl_Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Zahl.Location = new System.Drawing.Point(12, 60);
            this.lbl_Zahl.Name = "lbl_Zahl";
            this.lbl_Zahl.Size = new System.Drawing.Size(62, 17);
            this.lbl_Zahl.TabIndex = 23;
            this.lbl_Zahl.Text = "Zahl (1):";
            // 
            // txtBox_Zahl_Nutzer
            // 
            this.txtBox_Zahl_Nutzer.Location = new System.Drawing.Point(83, 59);
            this.txtBox_Zahl_Nutzer.Name = "txtBox_Zahl_Nutzer";
            this.txtBox_Zahl_Nutzer.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Zahl_Nutzer.TabIndex = 22;
            this.txtBox_Zahl_Nutzer.TextChanged += new System.EventHandler(this.txtBox_Zahl_Nutzer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Einsatz:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_Einsatz
            // 
            this.txtBox_Einsatz.Enabled = false;
            this.txtBox_Einsatz.Location = new System.Drawing.Point(83, 33);
            this.txtBox_Einsatz.Name = "txtBox_Einsatz";
            this.txtBox_Einsatz.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Einsatz.TabIndex = 19;
            this.txtBox_Einsatz.Text = "100";
            // 
            // lbl_Godzilla
            // 
            this.lbl_Godzilla.AutoSize = true;
            this.lbl_Godzilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Godzilla.Location = new System.Drawing.Point(93, 88);
            this.lbl_Godzilla.Name = "lbl_Godzilla";
            this.lbl_Godzilla.Size = new System.Drawing.Size(105, 17);
            this.lbl_Godzilla.TabIndex = 28;
            this.lbl_Godzilla.Text = "Versuch es mit:";
            this.lbl_Godzilla.Visible = false;
            // 
            // MainForm_Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 125);
            this.Controls.Add(this.lbl_Godzilla);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_Guthaben);
            this.Controls.Add(this.lbl_Zahl);
            this.Controls.Add(this.txtBox_Zahl_Nutzer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_Einsatz);
            this.MaximumSize = new System.Drawing.Size(324, 163);
            this.MinimumSize = new System.Drawing.Size(324, 163);
            this.Name = "MainForm_Multiplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spiel 3 - Wetten dass du verlierst?";
            this.Load += new System.EventHandler(this.MainForm_Multiplayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_Guthaben;
        private System.Windows.Forms.Label lbl_Zahl;
        private System.Windows.Forms.TextBox txtBox_Zahl_Nutzer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_Einsatz;
        private System.Windows.Forms.Label lbl_Godzilla;
    }
}