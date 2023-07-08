using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class GuideSectionForm : WindowsFormsApp2023_Final.GuideForm
    {
        public GuideSectionForm()
        {
            InitializeComponent();
            NavButton1.Enabled = false;
            NavButton1.BackColor = highlightedButtonColor;
        }
    }
}
