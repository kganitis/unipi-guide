namespace WindowsFormsApp2023_Final
{
    partial class ServicesSectionForm
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
            this.MainContentLabel = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // highlightedButton
            // 
            this.highlightedButton.Text = "Υπηρεσίες";
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.MainContentLabel);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ContentPanel.Size = new System.Drawing.Size(784, 437);
            // 
            // NavButton5
            // 
            this.NavButton5.Text = "Απόφοιτοι";
            // 
            // NavButton4
            // 
            this.NavButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton4.Text = "Φοιτητική Ζωή";
            // 
            // NavButton3
            // 
            this.NavButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton3.Text = "Ηλεκτρονικές Υπηρεσίες";
            // 
            // NavButton2
            // 
            this.NavButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton2.Text = "Φοιτητικές Παροχές";
            // 
            // MainContentLabel
            // 
            this.MainContentLabel.AutoSize = true;
            this.MainContentLabel.Location = new System.Drawing.Point(357, 84);
            this.MainContentLabel.Name = "MainContentLabel";
            this.MainContentLabel.Size = new System.Drawing.Size(0, 13);
            this.MainContentLabel.TabIndex = 0;
            // 
            // ServicesSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ServicesSectionForm";
            this.Text = "Υπηρεσίες";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainContentLabel;
    }
}
