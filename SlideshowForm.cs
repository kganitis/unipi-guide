using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp2023_Final.UserControls;

namespace WindowsFormsApp2023_Final
{
    public partial class SlideshowForm : WindowsFormsApp2023_Final.GuideForm
    {
        private UserControl[] slides;
        private int currentIndex = 0;
        //OR
       // private List<UserControl> slide = new List<UserControl>();

        public SlideshowForm()
        {
            InitializeComponent();
            HighlightButton(NavButton5);
            slides = new UserControl[] { firstUC1, secondUC1, thirdUC1, forthUC1 };
            // OR
            // slides.AddRange(new UserControl[] { ucPicture1, ucPicture2, ucPicture3, ucPicture4});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guna2Transition2.HideSync(slides[currentIndex]);
            currentIndex = (currentIndex +1) % slides.Length;
            guna2Transition1.ShowSync(slides[currentIndex]);
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2Transition2.HideSync(slides[currentIndex]);
            currentIndex = (currentIndex + 1) % slides.Length;
            guna2Transition1.ShowSync(slides[currentIndex]);
        }
    }
}
