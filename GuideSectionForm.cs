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
        protected GuideSection section;
        protected GuideSection currentSection;
        protected List<Button> subsectionNavButtons;

        public GuideSectionForm()
        {
            InitializeComponent();
            subsectionNavButtons = new List<Button>() { NavButton2, NavButton3, NavButton4, NavButton5 };
            HighlightButton(NavButton1);
        }

        protected void SubsectionButtonClick(object sender)
        {
            ResetHighlightedButton();
            Button clickedButton = (Button)sender;
            currentSection = GetCurrentlyClickedSection(clickedButton);
            if (currentSection.ContainsSubsections())
            {
                UpdateSectionButtonsText(currentSection.Subsections);
            }
            else
            {
                HighlightButton(clickedButton);
            }
            UpdateRootSectionButtonText();
        }

        protected void UpdateSectionButtonsText(List<GuideSection> subsections)
        {
            for (int i = 0; i < subsectionNavButtons.Count; i++)
            {
                subsectionNavButtons[i].Text = subsections[i].Name;
            }
        }

        private GuideSection GetCurrentlyClickedSection(Button clickedButton)
        {
            GuideSection clickedSection = null;
            // TO DO να βάλω comments
            if (currentSection.ContainsSubsections())
            {
                foreach (GuideSection subsection in currentSection.Subsections)
                {
                    if (subsection.Name == clickedButton.Text)
                    {
                        clickedSection = subsection;
                    }
                }
            }
            else
            {
                foreach (GuideSection subsection in currentSection.ParentSection.Subsections)
                {
                    if (subsection.Name == clickedButton.Text)
                    {
                        clickedSection = subsection;
                    }
                }
            }
            return clickedSection;
        }

        protected void UpdateRootSectionButtonText()
        {
            if (currentSection != section)
            {
                NavButton1.Text = "Πίσω σε " + section.Name;
            }
            else
            {
                NavButton1.Text = section.Name;
            }
        }

        protected void UpdateContent()
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
