using System;
using System.Media;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class SlideshowForm : WindowsFormsApp2023_Final.GuideForm
    {
        SoundPlayer player;
        private UserControl[] slides;
        private int currentIndex = 0;

        // Γιατί λείπει το πάνω μέρος του παραθύρου από τη φόρμα; (minimize, close κλπ)

        public SlideshowForm()
        {
            InitializeComponent();
            HighlightButton(NavButton5);
            slides = new UserControl[] { firstUC1, secondUC1, thirdUC1, forthUC1, fifthUC1, sixthUC1, seventhUC1, eighthUC1, ninthUC1, tenthUC1, eleventhUC1, twelfthUC1 };
            ninthUC1.Visible = false; // WHY ?
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TransitionToNextSlide();
        }

        private void TransitionToNextSlide()
        {
            guna2Transition2.HideSync(slides[currentIndex]); // Δε μου αρέσει το εφέ που κάνει την εικόνα να διαλύεται, να βρούμε κάτι άλλο;
            currentIndex = (currentIndex + 1) % slides.Length;
            guna2Transition1.ShowSync(slides[currentIndex]);
        }

        protected override void ExportButton_Click(object sender, EventArgs e)
        {   
            player = new SoundPlayer();
            player.SoundLocation = "../../Resources/Music/music3.wav"; // Δε δουλεύει !!!
            player.Play();
            guna2Transition2.HideSync(slides[11]);
            TransitionToNextSlide(); // Γενικά να δούμε τι παίζει με το σταμάτα/ξεκίνα, το delay δεν είναι πάντα το ίδιο
            timer1.Start();
        }

        protected override void ListenButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            player.Stop();
            guna2Transition1.ShowSync(slides[11]);
        }

        private void SlideshowForm_Deactivate(object sender, EventArgs e)
        {
            timer1.Stop();
            player.Stop();
            guna2Transition1.ShowSync(slides[11]);
        }
    }
}
