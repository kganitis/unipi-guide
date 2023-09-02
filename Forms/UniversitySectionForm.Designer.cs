namespace WindowsFormsApp2023_Final
{
    partial class UniversitySectionForm
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
            ((System.ComponentModel.ISupportInitialize)(this.ContentPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentPictureBox2)).BeginInit();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContentTextBox
            // 
            this.MainContentTextBox.Margin = new System.Windows.Forms.Padding(2);
            // 
            // SectionTitleTextBox
            // 
            this.SectionTitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SectionTitleTextBox.Size = new System.Drawing.Size(721, 37);
            // 
            // ContentPictureBox1
            // 
            this.ContentPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // highlightedButton
            // 
            this.highlightedButton.Text = "Πανεπιστήμιο";
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ContentPanel.Location = new System.Drawing.Point(267, 30);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(7);
            this.ContentPanel.Size = new System.Drawing.Size(1045, 537);
            // 
            // NavButton5
            // 
            this.NavButton5.Text = "Δραστηριότητες";
            // 
            // NavButton4
            // 
            this.NavButton4.Text = "Στρατηγικη Πάνεπιστημίου";
            // 
            // NavButton3
            // 
            this.NavButton3.Text = "Περιήγηση";
            // 
            // NavButton2
            // 
            this.NavButton2.Text = "Ιστορία";
            // 
            // UniversitySectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "UniversitySectionForm";
            this.Text = "Πανεπιστήμιο";
            ((System.ComponentModel.ISupportInitialize)(this.ContentPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentPictureBox2)).EndInit();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
