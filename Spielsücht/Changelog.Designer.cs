/*
 * Erstellt mit SharpDevelop. v. 5.1.0.5216
 * Benutzer: student
 * Datum: 29.6.2017
 * Zeit: 12:31
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
*/
namespace Spielsücht
{
	partial class Changelog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox_Changelog;
		
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
            this.richTextBox_Changelog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_Changelog
            // 
            this.richTextBox_Changelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Changelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox_Changelog.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Changelog.Name = "richTextBox_Changelog";
            this.richTextBox_Changelog.ReadOnly = true;
            this.richTextBox_Changelog.Size = new System.Drawing.Size(605, 277);
            this.richTextBox_Changelog.TabIndex = 0;
            this.richTextBox_Changelog.Text = "";
            // 
            // Changelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 277);
            this.Controls.Add(this.richTextBox_Changelog);
            this.MinimumSize = new System.Drawing.Size(593, 315);
            this.Name = "Changelog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changelog";
            this.Load += new System.EventHandler(this.ChangelogLoad);
            this.ResumeLayout(false);

		}
	}
}
