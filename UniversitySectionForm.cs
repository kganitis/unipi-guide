using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class UniversitySectionForm : WindowsFormsApp2023_Final.GuideSectionForm
    {
     
        public UniversitySectionForm()
        {
            InitializeComponent();

            section = new GuideSection("Πανεπιστήμιο");//parent Section1

            GuideSection subsection;

            subsection = new GuideSection("Ιστορία");//Subsection1.1
            section.AddSubsection(subsection);

            subsection = new GuideSection("Περιήγηση");//Subsection1.2
            subsection.AddSubsection(new GuideSection("Κεντρικό Κτίριο"));//Subsection1.2.1
            subsection.AddSubsection(new GuideSection("Εξωτερικές Αίθουσες"));//Subsection1.2.2
            subsection.AddSubsection(new GuideSection("Κτίριο Νίκαιας"));//Subsection1.2.3
            subsection.AddSubsection(new GuideSection("Επικοινωνία"));//Subsection1.2.4
            section.AddSubsection(subsection);

            subsection = new GuideSection("Στρατηγική Ιδρύματος");//Subsection1.3
            subsection.AddSubsection(new GuideSection("Χαιρετισμός"));//Subsection1.3.1
            subsection.AddSubsection(new GuideSection("Όραμα"));//Subsection1.3.2
            subsection.AddSubsection(new GuideSection("Αποστολή"));//Subsection1.3.3
            subsection.AddSubsection(new GuideSection("Στρατηγική"));//Subsection1.3.4
            section.AddSubsection(subsection);

            subsection = new GuideSection("Events");//Subsection1.4
            section.AddSubsection(subsection);

            ContentPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ContentPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            NavButton1_Click(this, null);
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
            if (((Button)sender).Text.Equals("Events")) //In case of subsection Events --> Load ViewEventsForm
            {
                NavigateToForm<ViewEventsForm>();
            }
            else
            {
                SubsectionButtonClick(sender);
            }
        }

    }
}
