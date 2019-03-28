namespace Spielsücht
{
    partial class Auswahl
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
            this.checkBox_Zr_E_ES = new System.Windows.Forms.CheckBox();
            this.checkBox_EB = new System.Windows.Forms.CheckBox();
            this.checkBox_Zr_E_MS = new System.Windows.Forms.CheckBox();
            this.checkBox_Zr_B_ES = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox_Highscore = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox_Zr_E_ES
            // 
            this.checkBox_Zr_E_ES.AutoSize = true;
            this.checkBox_Zr_E_ES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_Zr_E_ES.Location = new System.Drawing.Point(12, 12);
            this.checkBox_Zr_E_ES.Name = "checkBox_Zr_E_ES";
            this.checkBox_Zr_E_ES.Size = new System.Drawing.Size(108, 55);
            this.checkBox_Zr_E_ES.TabIndex = 0;
            this.checkBox_Zr_E_ES.Text = "Zahlen raten\r\n(Einzeln)\r\nEinzelspieler";
            this.checkBox_Zr_E_ES.UseVisualStyleBackColor = true;
            // 
            // checkBox_EB
            // 
            this.checkBox_EB.AutoSize = true;
            this.checkBox_EB.Enabled = false;
            this.checkBox_EB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_EB.Location = new System.Drawing.Point(126, 90);
            this.checkBox_EB.Name = "checkBox_EB";
            this.checkBox_EB.Size = new System.Drawing.Size(136, 21);
            this.checkBox_EB.TabIndex = 4;
            this.checkBox_EB.Tag = "Nicht verfügbar";
            this.checkBox_EB.Text = "Einzahlige Bandit";
            this.checkBox_EB.UseVisualStyleBackColor = true;
            // 
            // checkBox_Zr_E_MS
            // 
            this.checkBox_Zr_E_MS.AutoSize = true;
            this.checkBox_Zr_E_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_Zr_E_MS.Location = new System.Drawing.Point(12, 73);
            this.checkBox_Zr_E_MS.Name = "checkBox_Zr_E_MS";
            this.checkBox_Zr_E_MS.Size = new System.Drawing.Size(108, 55);
            this.checkBox_Zr_E_MS.TabIndex = 2;
            this.checkBox_Zr_E_MS.Tag = "Nicht verfügbar";
            this.checkBox_Zr_E_MS.Text = "Zahlen raten\r\n(Einzeln)\r\nMehrspieler";
            this.checkBox_Zr_E_MS.UseVisualStyleBackColor = true;
            // 
            // checkBox_Zr_B_ES
            // 
            this.checkBox_Zr_B_ES.AutoSize = true;
            this.checkBox_Zr_B_ES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_Zr_B_ES.Location = new System.Drawing.Point(126, 20);
            this.checkBox_Zr_B_ES.Name = "checkBox_Zr_B_ES";
            this.checkBox_Zr_B_ES.Size = new System.Drawing.Size(104, 38);
            this.checkBox_Zr_B_ES.TabIndex = 3;
            this.checkBox_Zr_B_ES.Tag = "";
            this.checkBox_Zr_B_ES.Text = "Zahlenraten\r\n(Bereich)";
            this.checkBox_Zr_B_ES.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(437, 121);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Über";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox_Highscore
            // 
            this.checkBox_Highscore.AutoSize = true;
            this.checkBox_Highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_Highscore.Location = new System.Drawing.Point(250, 29);
            this.checkBox_Highscore.Name = "checkBox_Highscore";
            this.checkBox_Highscore.Size = new System.Drawing.Size(91, 21);
            this.checkBox_Highscore.TabIndex = 5;
            this.checkBox_Highscore.Tag = "Nicht verfügbar";
            this.checkBox_Highscore.Text = "Highscore";
            this.checkBox_Highscore.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Statistiken";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(195, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Auswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 153);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox_Highscore);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_Zr_B_ES);
            this.Controls.Add(this.checkBox_Zr_E_MS);
            this.Controls.Add(this.checkBox_EB);
            this.Controls.Add(this.checkBox_Zr_E_ES);
            this.MaximumSize = new System.Drawing.Size(504, 192);
            this.MinimumSize = new System.Drawing.Size(504, 192);
            this.Name = "Auswahl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auswahl - Wetten dass du verlierst?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auswahl_FormClosing);
            this.Load += new System.EventHandler(this.Auswahl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Zr_E_ES;
        private System.Windows.Forms.CheckBox checkBox_EB;
        private System.Windows.Forms.CheckBox checkBox_Zr_E_MS;
        private System.Windows.Forms.CheckBox checkBox_Zr_B_ES;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox_Highscore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}