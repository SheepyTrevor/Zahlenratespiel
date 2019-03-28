/*
 * Erstellt mit SharpDevelop. v. 5.1.0.5216
 * Benutzer: student
 * Datum: 29.6.2017
 * Zeit: 11:36
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
*/
namespace Spielsücht
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtBox_Einsatz;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBox_Zahl_Nutzer;
		private System.Windows.Forms.Label lbl_Ergebnis;
		private System.Windows.Forms.Label lbl_Schwierigkeit;
		private System.Windows.Forms.RadioButton radioBtn_Leicht;
		private System.Windows.Forms.RadioButton radioBtn_Mittel;
		private System.Windows.Forms.RadioButton radioBtn_Schwer;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.txtBox_Einsatz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Zahl_Nutzer = new System.Windows.Forms.TextBox();
            this.lbl_Ergebnis = new System.Windows.Forms.Label();
            this.lbl_Schwierigkeit = new System.Windows.Forms.Label();
            this.radioBtn_Leicht = new System.Windows.Forms.RadioButton();
            this.radioBtn_Mittel = new System.Windows.Forms.RadioButton();
            this.radioBtn_Schwer = new System.Windows.Forms.RadioButton();
            this.lbl_Guthaben = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtBox_Einsatz
            // 
            this.txtBox_Einsatz.Location = new System.Drawing.Point(83, 33);
            this.txtBox_Einsatz.Name = "txtBox_Einsatz";
            this.txtBox_Einsatz.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Einsatz.TabIndex = 0;
            this.txtBox_Einsatz.Text = "100";
            this.txtBox_Einsatz.TextChanged += new System.EventHandler(this.TxtBox_Zahl_NutzerTextChanged);
            this.txtBox_Einsatz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Zahl_Nutzer_KeyPress);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(15, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Einsatz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zahl:";
            // 
            // txtBox_Zahl_Nutzer
            // 
            this.txtBox_Zahl_Nutzer.Location = new System.Drawing.Point(83, 59);
            this.txtBox_Zahl_Nutzer.Name = "txtBox_Zahl_Nutzer";
            this.txtBox_Zahl_Nutzer.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Zahl_Nutzer.TabIndex = 4;
            this.txtBox_Zahl_Nutzer.TextChanged += new System.EventHandler(this.TxtBox_Zahl_NutzerTextChanged);
            this.txtBox_Zahl_Nutzer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Zahl_Nutzer_KeyPress);
            // 
            // lbl_Ergebnis
            // 
            this.lbl_Ergebnis.AutoSize = true;
            this.lbl_Ergebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Ergebnis.Location = new System.Drawing.Point(12, 82);
            this.lbl_Ergebnis.Name = "lbl_Ergebnis";
            this.lbl_Ergebnis.Size = new System.Drawing.Size(118, 17);
            this.lbl_Ergebnis.TabIndex = 6;
            this.lbl_Ergebnis.Text = "Letztes Ergebnis:";
            // 
            // lbl_Schwierigkeit
            // 
            this.lbl_Schwierigkeit.AutoSize = true;
            this.lbl_Schwierigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Schwierigkeit.Location = new System.Drawing.Point(12, 132);
            this.lbl_Schwierigkeit.Name = "lbl_Schwierigkeit";
            this.lbl_Schwierigkeit.Size = new System.Drawing.Size(94, 17);
            this.lbl_Schwierigkeit.TabIndex = 9;
            this.lbl_Schwierigkeit.Text = "Schwierigkeit:";
            // 
            // radioBtn_Leicht
            // 
            this.radioBtn_Leicht.AutoSize = true;
            this.radioBtn_Leicht.Checked = true;
            this.radioBtn_Leicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtn_Leicht.Location = new System.Drawing.Point(15, 161);
            this.radioBtn_Leicht.Name = "radioBtn_Leicht";
            this.radioBtn_Leicht.Size = new System.Drawing.Size(64, 21);
            this.radioBtn_Leicht.TabIndex = 10;
            this.radioBtn_Leicht.TabStop = true;
            this.radioBtn_Leicht.Text = "Leicht";
            this.radioBtn_Leicht.UseVisualStyleBackColor = true;
            this.radioBtn_Leicht.CheckedChanged += new System.EventHandler(this.RadioBtn_LeichtCheckedChanged);
            // 
            // radioBtn_Mittel
            // 
            this.radioBtn_Mittel.AutoSize = true;
            this.radioBtn_Mittel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtn_Mittel.Location = new System.Drawing.Point(83, 161);
            this.radioBtn_Mittel.Name = "radioBtn_Mittel";
            this.radioBtn_Mittel.Size = new System.Drawing.Size(59, 21);
            this.radioBtn_Mittel.TabIndex = 11;
            this.radioBtn_Mittel.Text = "Mittel";
            this.radioBtn_Mittel.UseVisualStyleBackColor = true;
            this.radioBtn_Mittel.CheckedChanged += new System.EventHandler(this.RadioBtn_MittelCheckedChanged);
            // 
            // radioBtn_Schwer
            // 
            this.radioBtn_Schwer.AutoSize = true;
            this.radioBtn_Schwer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtn_Schwer.Location = new System.Drawing.Point(148, 161);
            this.radioBtn_Schwer.Name = "radioBtn_Schwer";
            this.radioBtn_Schwer.Size = new System.Drawing.Size(72, 21);
            this.radioBtn_Schwer.TabIndex = 12;
            this.radioBtn_Schwer.Text = "Schwer";
            this.radioBtn_Schwer.UseVisualStyleBackColor = true;
            this.radioBtn_Schwer.CheckedChanged += new System.EventHandler(this.RadioBtn_SchwerCheckedChanged);
            // 
            // lbl_Guthaben
            // 
            this.lbl_Guthaben.AutoSize = true;
            this.lbl_Guthaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Guthaben.Location = new System.Drawing.Point(12, 9);
            this.lbl_Guthaben.Name = "lbl_Guthaben";
            this.lbl_Guthaben.Size = new System.Drawing.Size(75, 17);
            this.lbl_Guthaben.TabIndex = 16;
            this.lbl_Guthaben.Text = "Guthaben:";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(187, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "All In";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(187, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Zufällig";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(15, 188);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 21);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Mehr Zusatzzahlen";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton1.Location = new System.Drawing.Point(226, 152);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 38);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.Text = "Chuck\r\nNorris";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 221);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_Guthaben);
            this.Controls.Add(this.radioBtn_Schwer);
            this.Controls.Add(this.radioBtn_Mittel);
            this.Controls.Add(this.radioBtn_Leicht);
            this.Controls.Add(this.lbl_Schwierigkeit);
            this.Controls.Add(this.lbl_Ergebnis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Zahl_Nutzer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_Einsatz);
            this.Controls.Add(this.radioButton1);
            this.MaximumSize = new System.Drawing.Size(319, 260);
            this.MinimumSize = new System.Drawing.Size(319, 225);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spiel 1 - Wetten dass du verlierst?";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.Label lbl_Guthaben;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
