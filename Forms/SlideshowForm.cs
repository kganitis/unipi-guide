using System;
using System.Media;
using System.Windows.Forms;
using WindowsFormsApp2023_Final.Properties;

namespace WindowsFormsApp2023_Final
{
    public partial class SlideshowForm : WindowsFormsApp2023_Final.GuideForm
    {
        SoundPlayer player;
        private UserControl[] slides;
        private int currentIndex = 0;

        public SlideshowForm()
        {
            InitializeComponent();
            HighlightButton(NavButton5);
            HomeToolStripMenuItem.Enabled = true;
            ExportToolStripMenuItem.Text = ExportButton.Text;
            ListenToolStripMenuItem.Text = ListenButton.Text;
            slides = new UserControl[] { firstUC1, secondUC1, thirdUC1, forthUC1, fifthUC1, sixthUC1, seventhUC1, eighthUC1, ninthUC1, tenthUC1, eleventhUC1, twelfthUC1 };
            ninthUC1.Visible = false; // WHY ?
            player = new SoundPlayer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TransitionToNextSlide();
        }

        private void BeginSlideshow()
        {
            ToogleListenEnabled(true);
            timer1.Start();
            player.Stream = Resources.music3;
            player.Play();
            guna2Transition2.HideSync(slides[11]);
            ToogleExportEnabled(false);
        }

        private void TransitionToNextSlide()
        {
            guna2Transition2.HideSync(slides[currentIndex]); // Δε μου αρέσει το εφέ που κάνει την εικόνα να διαλύεται, να βρούμε κάτι άλλο;
            currentIndex = (currentIndex + 1) % slides.Length;
            guna2Transition1.ShowSync(slides[currentIndex]);
        }

        private void StopSlideshow()
        {
            ToogleListenEnabled(false);
            timer1.Stop();
            player.Stop();
            guna2Transition1.ShowSync(slides[11]);
            ToogleExportEnabled(true);
        }

        protected override void ExportButton_Click(object sender, EventArgs e)
        {
            BeginSlideshow();
        }

        protected override void ListenButton_Click(object sender, EventArgs e)
        {
            StopSlideshow();
        }

        protected override void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeginSlideshow();
        }

        protected override void ListenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopSlideshow();
        }

        private void SlideshowForm_Deactivate(object sender, EventArgs e)
        {
            StopSlideshow();
        }
    }
}
