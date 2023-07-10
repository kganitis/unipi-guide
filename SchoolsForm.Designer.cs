namespace WindowsFormsApp2023_Final
{
    partial class SchoolsForm
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
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(300, 36);
            this.ContentPanel.Size = new System.Drawing.Size(1176, 673);
            // 
            // NavButton1
            // 
            this.NavButton1.Text = "Σχολές";
            // 
            // SchoolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1476, 863);
            this.Margin = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.Name = "SchoolsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
