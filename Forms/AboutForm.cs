namespace WindowsFormsApp2023_Final
{
    public partial class AboutForm : WindowsFormsApp2023_Final.BaseForm
    {
        public AboutForm()
        {
            InitializeComponent();
            HideAllControls();
            NavButtonBack.Visible = true;
            BackToolStripMenuItem.Enabled = true;
        }
    }
}
