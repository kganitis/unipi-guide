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
            currentSection = getClickedSection(clickedButton);
            if (currentSection.ContainsSubsections())
            {
                UpdateSectionButtonsText(currentSection.Subsections);
            }
            else
            {
                HighlightButton(clickedButton);
            }
        }

        protected void UpdateSectionButtonsText(List<GuideSection> subsections)
        {
            for (int i = 0; i < subsectionNavButtons.Count; i++)
            {
                subsectionNavButtons[i].Text = subsections[i].Name;
            }
        }

        private GuideSection getClickedSection(Button clickedButton)
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
    }
}
