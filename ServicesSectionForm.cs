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
            
            GuideSection subsection;

            subsection = new GuideSection("Φοιτητικές Παροχές");
            subsection.AddSubsection(new GuideSection("Φοιτητική Μέριμνα"));
            subsection.AddSubsection(new GuideSection("Βιβλιοθήκη"));
            subsection.AddSubsection(new GuideSection("Γραφείο Διασύνδεσης"));
            subsection.AddSubsection(new GuideSection("Ιατρείο"));
            section.AddSubsection(subsection);

            subsection = new GuideSection("Ηλεκτρονικές Υπηρεσίες");
            subsection.AddSubsection(new GuideSection("Ηλεκτρονική Γραμματεία"));
            subsection.AddSubsection(new GuideSection("Εξ Αποστάσεως Εκπαίδευση"));
            subsection.AddSubsection(new GuideSection("Ηλεκτρονικό Ταχυδρομείο"));
            subsection.AddSubsection(new GuideSection("Ασύρματες Συνδέσεις"));
            section.AddSubsection(subsection);

            subsection = new GuideSection("Φοιτητική Ζωή");
            subsection.AddSubsection(new GuideSection("Πολιτιστικές Ομάδες"));
            subsection.AddSubsection(new GuideSection("Φοιτητικοί Σύλλογοι"));
            subsection.AddSubsection(new GuideSection("Φοιτητικές Παρατάξεις"));
            subsection.AddSubsection(new GuideSection("Άλλες Δραστηριότητες"));
            section.AddSubsection(subsection);

            subsection = new GuideSection("Απόφοιτοι");
            section.AddSubsection(subsection);

            NavButton1_Click(this, null);
        }

        private void UpdateContent()
        {
            if (currentSection != null)
            {
                string title = currentSection.Name;
                string content = currentSection.Content;

                // Ενημέρωση τίτλου και κειμένου
                SectionTitleTextBox.Text = title;
                MainContentTextBox.Text = content;

                // Ενημέρωση τυχόν εικόνων
                ContentPictureBox1.Image = currentSection.Pictures[0];
                ContentPictureBox2.Image = currentSection.Pictures[1];

                // Αν δεν υπάρχουν εικόνες για το συγκεκριμένο τμήμα, μεγάλωσε το TextBox του κυρίως περιεχομένου
                if (ContentPictureBox1.Image == null && ContentPictureBox2.Image == null)
                {
                    MainContentTextBox.Width = 678;
                }
                else
                {
                    MainContentTextBox.Width = 492;
                }
            }
        }

        protected override void NavButton1_Click(object sender, EventArgs e)
        {
            ResetHighlightedButton();
            currentSection = section;
            UpdateSectionButtonsText(section.Subsections);
            UpdateRootSectionButtonText();
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

        // Αλλαγή του focus όταν ο χρήστης κάνει κλικ στα TextBox, ώστε να μην εμφανίζεται ο κέρσορας που αναβοσβήνει
        // πιστεύοντας έτσι ο χρήστης ότι μπορεί να επεξεργαστεί το κείμενο
        private void MainContentTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ContentPanel.Focus();
        }

        private void SectionTitleTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ContentPanel.Focus();
        }
    }
}
