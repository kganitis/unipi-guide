namespace WindowsFormsApp2023_Final
{
    partial class LoginForm
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
            HideAllControls();
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "LoginForm";
            this.ResumeLayout(false);

        }

        private void HideAllControls()
        {
            HideExportAndListenControls();
            HideNavigationControls();
        }

        private void HideNavigationControls()
        {
            // 
            // NavButton1
            // 
            this.NavButton1.Visible = false;
            // 
            // NavButtonBack
            // 
            this.NavButtonBack.Visible = false;
            // 
            // NavButton5
            // 
            this.NavButton5.Visible = false;
            // 
            // NavButton4
            // 
            this.NavButton4.Visible = false;
            // 
            // NavButton3
            // 
            this.NavButton3.Visible = false;
            // 
            // NavButton2
            // 
            this.NavButton2.Visible = false;
            // 
            // NavButtonHome
            // 
            this.NavButtonHome.Visible = false;
        }

        private void HideExportAndListenControls()
        {
            // 
            // ExportButton
            // 
            this.ExportButton.Visible = false;
            // 
            // ListenButton
            // 
            this.ListenButton.Visible = false;
        }

        #endregion
    }
}
