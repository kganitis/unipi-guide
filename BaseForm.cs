using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class BaseForm : Form
    {
        internal FormCacheManager cacheManager;
        protected Color highlightedButtonColor = Color.BurlyWood;
        
        public BaseForm()
        {
            InitializeComponent();
            cacheManager = FormCacheManager.Instance;
            if (GetType() == typeof(AboutForm))
            {
                AboutButton.Enabled = false;
            }
        }

        protected void HighlightButton(Button button)
        {
            button.Enabled = false;
            button.BackColor = highlightedButtonColor;
        }

        protected void HideAllControls()
        {
            HideExportAndListenControls();
            HideNavigationControls();
        }

        protected void HideNavigationControls()
        {
            NavButtonHome.Visible = false;
            NavButton1.Visible = false;
            NavButton2.Visible = false;
            NavButton3.Visible = false;
            NavButton4.Visible = false;
            NavButton5.Visible = false;
            NavButtonBack.Visible = false;
            HomeToolStripMenuItem.Enabled = false;
            UniversityToolStripMenuItem.Enabled = false;
            ServicesToolStripMenuItem.Enabled = false;
            SchoolsToolStripMenuItem.Enabled = false;
            ReviewsToolStripMenuItem.Enabled = false;
            SlideshowToolStripMenuItem.Enabled = false;
            BackToolStripMenuItem.Enabled = false;
        }

        protected void HideExportAndListenControls()
        {
            ExportButton.Visible = false;
            ListenButton.Visible = false;
            ToolsToolStripMenuItem.Enabled = false;
            ExportToolStripMenuItem.Enabled = false;
            ListenToolStripMenuItem.Enabled = false;
        }

        protected void NavigateToForm<T>() where T : Form, new()
        {
            cacheManager.NavigateToForm<T>(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NavButtonHome_Click(object sender, EventArgs e)
        {
            NavigateToForm<GuideForm>();
        }

        private void NavButton1_Click(object sender, EventArgs e)
        {
            NavigateToForm<UniversitySectionForm>();
        }

        private void NavButton2_Click(object sender, EventArgs e)
        {
            NavigateToForm<ServicesSectionForm>();
        }

        private void NavButton3_Click(object sender, EventArgs e)
        {
            NavigateToForm<SchoolsSectionForm>();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            NavigateToForm<AboutForm>();
        }

        private void NavButtonBack_Click(object sender, EventArgs e)
        {
            cacheManager.NavigateBack(this);
        }

        private void NavButton4_Click(object sender, EventArgs e)
        {
            NavigateToForm<ReviewsForm>();
        }

        private void NavButton5_Click(object sender, EventArgs e)
        {
            NavigateToForm<SlideshowForm>();
        }

        private void UniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<UniversitySectionForm>();
        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<ServicesSectionForm>();
        }

        private void SchoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<SchoolsSectionForm>();
        }

        private void ReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<ReviewsForm>();
        }

        private void SlideshowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<SlideshowForm>();
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cacheManager.NavigateBack(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<AboutForm>();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<GuideForm>();
        }
    }
}
