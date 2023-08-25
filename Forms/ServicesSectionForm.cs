using System;

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
    }
}
