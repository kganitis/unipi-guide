using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class BaseForm : Form
    {
        internal FormCacheManager cacheManager;
        private SpeechSynthesizer synthesizer;
        protected Color highlightedButtonColor = Color.BurlyWood;
        
        public BaseForm()
        {
            InitializeComponent();
            cacheManager = FormCacheManager.Instance;
            synthesizer = new SpeechSynthesizer();
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

        private void ExportButton_Click(object sender, EventArgs e)
        {
            string textToExport = testLabel.Text;
            string filename = Text;
            string filePath = "..\\..\\exports\\" + filename + ".txt";
            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(textToExport);
            MessageBox.Show("Οι πληροφορίες εξήχθησαν με επιτυχία!");
            writer.Close();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            {
                VoiceInfo info = voice.VoiceInfo;

                Console.WriteLine(" Name:          " + info.Name);
                Console.WriteLine(" Culture:       " + info.Culture);
                Console.WriteLine(" Age:           " + info.Age);
                Console.WriteLine(" Gender:        " + info.Gender);
                Console.WriteLine(" Description:   " + info.Description);
                Console.WriteLine(" ID:            " + info.Id);
                Console.WriteLine();
            }
            synthesizer.SelectVoice("Microsoft Stefanos");
            // synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, CultureInfo.GetCultureInfo("el-GR"));
            synthesizer.SpeakAsync(testLabel.Text);
        }
    }
}
