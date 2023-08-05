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

        protected void UpdateSectionButtonsText(List<GuideSection> subsections)
        {
            for (int i = 0; i < subsectionNavButtons.Count; i++)
            {
                subsectionNavButtons[i].Text = subsections[i].Name;
            }
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

        private GuideSection getClickedSection(Button clickedButton)
        {
            GuideSection clickedSection = null;
            foreach (GuideSection subsection in (currentSection.ContainsSubsections() ? currentSection.Subsections : currentSection.ParentSection.Subsections))
            {
                if (subsection.Name == clickedButton.Text)
                {
                    clickedSection = subsection;
                }
            }
            return clickedSection;
        }

        
    }
}
