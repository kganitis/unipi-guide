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
            subsection.AddSubsection(new GuideSection("Λοιποί Χώροι"));//Subsection1.2.4
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
            //label1.Text = "Εγκαταστάσεις Πανεπιστημίου";
            //pictureBox1.ImageLocation = "..\\..\\Resources\\unipi_main_entr.png";
            //pictureBox2.ImageLocation = "..\\..\\Resources\\unipi_remote1.png";
            /*label2.Text = "\tΚεντρικό Κτίριο οδ. Καραολή & Δημητρίου 80\r\n\n" +
                                "\tΚτίρια οδ. Δεληγιώργη & Tσαμαδού\r\n\n" +
                                "\tΚτίριο οδ. Γρ. Λαμπράκη 21 & Διστόμου\r\n\n" +
                                "\tΚτίριο οδ. Ανδρούτσου 150\r\n\n" +
                                "\tΚτίριο οδ. Γρ. Λαμπράκη 126\r\n\n" +
                                "\tΚτίριο οδ. Ζέας 82\r\n\n" +
                                "\tΚτιριακό Συγκρότημα Νίκαιας ";*/

            SubsectionButtonClick(sender);
            UpdateContent();

        }

        protected override void NavButton4_Click(object sender, EventArgs e)
        {
            //label1.Text = "Αποστολή Πανεπιστημίου";

            //pictureBox1.ImageLocation = "..\\..\\Resources\\unipi_library.png";
            //pictureBox2.ImageLocation = "..\\..\\Resources\\unipi_comLab.png";

            /*label2.Text = "H αποστολή του Πανεπιστημίου Πειραιώς, στο πλαίσιο που εξ αρχής του ανέθεσε η Ελληνική Πολιτεία, είναι να εκπαιδεύει," +
                                " να παράγει νέα γνώση, να καλλιεργεί το πνεύμα των νέων, να προάγει τις αξίες της ελευθερίας, της δημοκρατίας " +
                                "και της προσφοράς στις υποθέσεις της Ελλάδας. Ειδικότερα, η αποστολή του Πανεπιστημίου είναι:\r\n1. Nα παράγει " +
                                "και να μεταδίδει τη γνώση με την έρευνα και τη διδασκαλία, να προετοιμάζει τους φοιτητές για την εφαρμογή της σε " +
                                "όλους τους τομείς της οικονομικής και κοινωνικής ζωής.\r\n2. Nα παρέχει υψηλού επιπέδου ανώτατη εκπαίδευση και " +
                                "να συμβάλλει στη διά βίου μάθηση με σύγχρονες μεθόδους διδασκαλίας, περιλαμβανομένης και της διδασκαλίας από " +
                                "απόσταση, με βάση την επιστημονική και τεχνολογική έρευνα στο ανώτερο επίπεδο ποιότητας, σύμφωνα με τα " +
                                "διεθνώς αναγνωρισμένα κριτήρια.\r\n3. Nα προωθεί την αριστεία στην εκπαίδευση και την αξιοποίηση της γνώσης, " +
                                "με στόχο τη διάπλαση επιστημόνων με αξίες.\r\n4. Nα αναπτύσσει και να υποστηρίζει την έρευνα για την αντιμετώπιση " +
                                "των προκλήσεων σε τομείς αιχμής.\r\n5. Nα συμβάλλει στην πρόοδο της επιχειρηματικότητας και στην ανάπτυξη " +
                                "της καινοτομίας.\r\n6. Nα προάγει την εξωστρέφεια και τη συνεργασία με ακαδημαϊκούς, ερευνητικούς," +
                                " κοινωνικούς και άλλους φορείς, για την ανάπτυξη του Ιδρύματος και της κοινωνίας.\r\n7. Nα λειτουργεί" +
                                " ως πόλος αναφοράς, πεδίο γόνιμου διαλόγου και ελεύθερης ανάπτυξης ιδεών για το τοπικό και εθνικό οικονομικό " +
                                "και κοινωνικό οικοσύστημα.\r\nΣτο πλαίσιο της παραπάνω αποστολής του, το Πανεπιστήμιο Πειραιώς παρέχει ποιοτική και" +
                                " ολοκληρωμένη εκπαίδευση, εναρμονιζόμενη με τις σύγχρονες τάσεις της επιστήμης, της τεχνολογίας " +
                                "και της διεθνούς επιστημονικής πρακτικής.";*/

            SubsectionButtonClick(sender);
            UpdateContent();

        }

        protected override void NavButton5_Click(object sender, EventArgs e)
        {
            if (currentSection.Name.Equals("Events"))//In case of subsection Events --> Load ViewEventsForm
                NavigateToForm<ViewEventsForm>();

            SubsectionButtonClick(sender);
            UpdateContent();
        }

    }
}
