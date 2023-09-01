using System;
using System.Collections.Generic;
using System.Security.Permissions;
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
            HomeToolStripMenuItem.Enabled = true;
            ExportButton.Enabled = true;
            ExportToolStripMenuItem.Enabled = true;
        }

        protected override void NavButton1_Click(object sender, EventArgs e)
        {
            ResetHighlightedButton();
            currentSection = section;
            UpdateSectionButtonsText(section.Subsections);
            UpdateRootSectionButtonText();
            HighlightButton(NavButton1);
            UpdateContent();
            Text = currentSection.Name;
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

        protected void SubsectionButtonClick(object sender)
        {
            ResetHighlightedButton();
            Button clickedButton = (Button)sender;
            UpdateCurrentSection(clickedButton);
            if (currentSection.ContainsSubsections())
            {
                UpdateSectionButtonsText(currentSection.Subsections);
            }
            else
            {
                HighlightButton(clickedButton);
            }
            UpdateRootSectionButtonText();
            Text = currentSection.Name;
        }

        protected void UpdateSectionButtonsText(List<GuideSection> subsections)
        {
            for (int i = 0; i < subsectionNavButtons.Count; i++)
            {
                subsectionNavButtons[i].Text = subsections[i].Name;
                if (subsectionNavButtons[i].Text.Equals(""))
                {
                    subsectionNavButtons[i].Visible = false;
                }
                else
                {
                    subsectionNavButtons[i].Visible = true;
                }
            }
        }

        /**
         * Σκοπός της μεθόδου είναι να να ενημερωθεί το currentSection με βάση το αντίστοιχο κουμπί που κάναμε κλικ.
         * ΣΗΜΑΝΤΙΚΟ: Το Text των κουμπιών δεν έχει γίνει ακόμη update.
         * Η λογική είναι να βρούμε το subsection του οποίου το όνομα ταυτίζεται με το text του κουμπιού που μόλις πατήσαμε.
         * Αν το κουμπί που μόλις πατήσαμε αντιστοιχεί σε subsection που έχει περαιτέρω subsections,
         * τότε πρέπει να κάνουμε αναζήτηση στη λίστα των subsection του μέχρι πρότινος currentSubsection.
         * Αν δεν έχει περαιτέρω subsections, τότε για να βρούμε τη λίστα των subsections θα πρέπει να πάμε στο parentSection του currentSection.
         */
        private void UpdateCurrentSection(Button clickedButton)
        {
            GuideSection clickedSection = null;

            List<GuideSection> subsectionsToSearch;
            if (currentSection.ContainsSubsections())
            {
                subsectionsToSearch = currentSection.Subsections;
            }
            else
            {
                subsectionsToSearch = currentSection.ParentSection.Subsections;
            }

            foreach (GuideSection subsection in subsectionsToSearch)
            {
                if (subsection.Name == clickedButton.Text)
                {
                    clickedSection = subsection;
                }
            }
            currentSection = clickedSection;
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

        protected override void ExportButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(MainContentTextBox.Text))
            {
                Export(MainContentTextBox.Text);
            }
        }

        protected override void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(MainContentTextBox.Text))
            {
                Export(MainContentTextBox.Text);
            }
        }
    }
}
