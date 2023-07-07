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
        public BaseForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NavButtonHome_Click(object sender, EventArgs e)
        {
            Close();
            new GuideIntroForm().Show();
        }

        private void NavButton1_Click(object sender, EventArgs e)
        {
            Close();
            new UniversitySectionForm().Show();
        }

        private void NavButton2_Click(object sender, EventArgs e)
        {
            Close();
            new ServicesSectionForm().Show();
        }

        private void NavButton3_Click(object sender, EventArgs e)
        {
            Close();
            new SchoolsSectionForm().Show();
        }
    }
}
