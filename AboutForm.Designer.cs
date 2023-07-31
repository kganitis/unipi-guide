namespace WindowsFormsApp2023_Final
{
    partial class AboutForm
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
            this.AboutLabel = new System.Windows.Forms.Label();
            this.AboutTitleLabel = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.AboutTitleLabel);
            this.ContentPanel.Controls.Add(this.AboutLabel);
            this.ContentPanel.Location = new System.Drawing.Point(267, 30);
            this.ContentPanel.Size = new System.Drawing.Size(1045, 537);
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.Location = new System.Drawing.Point(172, 220);
            this.AboutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(647, 145);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = "Γανίτης Κωνσταντίνος, ΜΠΠΛ2212, mppl2212@unipi.gr\r\n\r\nΣίμος Γεώργιος, ΜΠΠΛ2238, mp" +
    "pl2238@unipi.gr\r\n\r\nΤουλιούδας Στέργιος, ΜΠΠΛ2245, mppl2245@unipi.gr";
            // 
            // AboutTitleLabel
            // 
            this.AboutTitleLabel.AutoSize = true;
            this.AboutTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTitleLabel.Location = new System.Drawing.Point(307, 107);
            this.AboutTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutTitleLabel.Name = "AboutTitleLabel";
            this.AboutTitleLabel.Size = new System.Drawing.Size(353, 39);
            this.AboutTitleLabel.TabIndex = 1;
            this.AboutTitleLabel.Text = "Στοιχεία δημιουργών";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AboutForm";
            this.Text = "Σχετικά";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label AboutTitleLabel;
    }
}
