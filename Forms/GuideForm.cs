using System;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class GuideForm : WindowsFormsApp2023_Final.BaseForm
    {
        public GuideForm()
        {
            InitializeComponent();
            if (Text.Equals("Αρχική"))
            {
                HomeToolStripMenuItem.Enabled = false;
            }
        }

        public void UpdateWelcomeMessage(string welcomeMessage)
        {
            WelcomeLabel.Visible = true;
            WelcomeLabel.Text = welcomeMessage;
            WelcomeLabel.Location = new System.Drawing.Point((ContentPanel.Width - WelcomeLabel.Width) / 2, WelcomeLabel.Location.Y); // κεντράρισμα στο panel
        }
    }
}
