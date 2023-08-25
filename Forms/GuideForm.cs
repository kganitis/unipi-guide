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
    }
}
