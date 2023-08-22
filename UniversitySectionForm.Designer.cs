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
            this.ContentPanel.Size = new System.Drawing.Size(1045, 541);
            // 
            // NavButton5
            // 
            this.NavButton5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton5.Location = new System.Drawing.Point(13, 465);
            this.NavButton5.Size = new System.Drawing.Size(240, 72);
            this.NavButton5.Text = "Events";
            this.NavButton5.Click += new System.EventHandler(this.NavButton5_Click);
            // 
            // NavButton4
            // 
            this.NavButton4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton4.Location = new System.Drawing.Point(13, 371);
            this.NavButton4.Size = new System.Drawing.Size(240, 86);
            this.NavButton4.Text = "Στρατηγικη Πάνεπιστημίου";
            this.NavButton4.Click += new System.EventHandler(this.NavButton4_Click);
            // 
            // NavButton3
            // 
            this.NavButton3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton3.Location = new System.Drawing.Point(13, 280);
            this.NavButton3.Size = new System.Drawing.Size(240, 83);
            this.NavButton3.Text = "Περιήγηση";
            this.NavButton3.Click += new System.EventHandler(this.NavButton3_Click);
            // 
            // NavButton2
            // 
            this.NavButton2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton2.Location = new System.Drawing.Point(13, 221);
            this.NavButton2.Size = new System.Drawing.Size(240, 51);
            this.NavButton2.Text = "Ιστορία";
            this.NavButton2.Click += new System.EventHandler(this.NavButton2_Click);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
