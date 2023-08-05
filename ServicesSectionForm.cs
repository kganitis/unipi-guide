using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class ServicesSectionForm : WindowsFormsApp2023_Final.GuideSectionForm
    {
        public ServicesSectionForm()
        {
            InitializeComponent();

            // Δημιουργία δομής υπο-τμημάτων του οδηγού
            section = new GuideSection("Υπηρεσίες");
            List<GuideSection> subsections = new List<GuideSection>();
            
            GuideSection subsection;

            subsection = new GuideSection("Φοιτητικές Παροχές");
            subsection.AddSubsection(new GuideSection("Φοιτητική Μέριμνα"));
            subsection.AddSubsection(new GuideSection("Βιβλιοθήκη"));
            subsection.AddSubsection(new GuideSection("Γραφείο Διασύνδεσης"));
            subsection.AddSubsection(new GuideSection("Ιατρείο"));
            subsections.Add(subsection);

            subsection = new GuideSection("Ηλεκτρονικές Υπηρεσίες");
            subsection.AddSubsection(new GuideSection("Ηλεκτρονική Γραμματεία"));
            subsection.AddSubsection(new GuideSection("Εξ Αποστάσεως Εκπαίδευση"));
            subsection.AddSubsection(new GuideSection("Ηλεκτρονικό Ταχυδρομείο"));
            subsection.AddSubsection(new GuideSection("Ασύρματες Συνδέσεις"));
            subsections.Add(subsection);

            subsection = new GuideSection("Φοιτητική Ζωή");
            subsection.AddSubsection(new GuideSection(""));
            subsection.AddSubsection(new GuideSection(""));
            subsection.AddSubsection(new GuideSection(""));
            subsection.AddSubsection(new GuideSection(""));
            subsections.Add(subsection);

            subsection = new GuideSection("Απόφοιτοι");
            subsection.AddSubsection(new GuideSection(""));
            subsection.AddSubsection(new GuideSection(""));
            subsection.AddSubsection(new GuideSection(""));
            subsection.AddSubsection(new GuideSection(""));
            subsections.Add(subsection);

            section.Subsections = subsections;
            currentSection = section;
            NavButton1_Click(this, null);
        }

        private void UpdateContent()
        {
            if (currentSection != null)
            {
                MainContentLabel.Text = currentSection.Info;
            }
        }

        protected override void NavButton1_Click(object sender, EventArgs e)
        {
            ResetHighlightedButton();
            currentSection = section;
            UpdateSectionButtonsText(section.Subsections);
            HighlightButton(NavButton1);
            UpdateContent();
        }

        protected override void NavButton2_Click(object sender, EventArgs e)
        {
            SubsectionButtonClick(sender);
            UpdateContent();
        }

        protected override void NavButton3_Click(object sender, EventArgs e)
        {
            SubsectionButtonClick(sender);
            UpdateContent();
        }

        protected override void NavButton4_Click(object sender, EventArgs e)
        {
            SubsectionButtonClick(sender);
            UpdateContent();
        }

        protected override void NavButton5_Click(object sender, EventArgs e)
        {
            SubsectionButtonClick(sender);
            UpdateContent();
        }
    }
}
