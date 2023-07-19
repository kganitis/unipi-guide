using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class UniversitySectionForm : WindowsFormsApp2023_Final.GuideSectionForm
    {
     
        public UniversitySectionForm()
        {
            InitializeComponent();
            
        }

        

        protected override void NavButton2_Click(object sender, EventArgs e)
        {
            label1.Text = "Ιστορική Αναδρομή";
        }

        protected override void NavButton3_Click(object sender, EventArgs e)
        {
            label1.Text = "Περιήγηση";
        }

        protected override void NavButton4_Click(object sender, EventArgs e)
        {
            label1.Text = "Στρατηγική Πανεπιστημίου";
        }

        protected override void NavButton5_Click(object sender, EventArgs e)
        {
            label1.Text = "Events";
        }

    }
}
