using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp2023_Final.UserControls;

namespace WindowsFormsApp2023_Final
{
    public partial class SlideshowForm : WindowsFormsApp2023_Final.GuideForm
    {
        SoundPlayer player;
        private UserControl[] slides;
        private int currentIndex = 0;
        //OR
       // private List<UserControl> slide = new List<UserControl>();

        public SlideshowForm()
        {
            InitializeComponent();
            HighlightButton(NavButton5);
          //  HideExportAndListenControls();
            slides = new UserControl[] { firstUC1, secondUC1, thirdUC1, forthUC1, fifthUC1, sixthUC1, seventhUC1, eighthUC1, ninthUC1, tenthUC1, eleventhUC1, twelfthUC1};
            AboutButton.Visible = false;
            ninthUC1.Visible = false;   
            // OR
            // slides.AddRange(new UserControl[] { ucPicture1, ucPicture2, ucPicture3, ucPicture4});
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2Transition2.HideSync(slides[currentIndex]);
            currentIndex = (currentIndex + 1) % slides.Length;
            guna2Transition1.ShowSync(slides[currentIndex]);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            // SoundPlayer player = new SoundPlayer("music/pacman_beginning.wav");
            // player = new SoundPlayer("C:/Users/PX/source/repos/WindowsFormsGitHub/WindowsFormsApp2023_Final/Resources/Music/music2.wav");      
            player = new SoundPlayer("C:/Users/PX/source/repos/WindowsFormsGitHub/WindowsFormsApp2023_Final/Resources/Music/music3.wav");
            player.Play();
            guna2Transition2.HideSync(slides[11]);
            guna2Transition2.HideSync(slides[currentIndex]);
            currentIndex = (currentIndex + 1) % slides.Length;
            guna2Transition1.ShowSync(slides[currentIndex]);
            timer1.Start();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            player.Stop();
            guna2Transition1.ShowSync(slides[11]);
        }


    }
}
