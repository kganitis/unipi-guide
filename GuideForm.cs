using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class GuideForm : WindowsFormsApp2023_Final.BaseForm
    {
        public GuideForm()
        {
            InitializeComponent();
            HomeToolStripMenuItem.Enabled = false;
        }
    }
}
