using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class SchoolsSectionForm : WindowsFormsApp2023_Final.GuideSectionForm
    {
        public SchoolsSectionForm()
        {
            InitializeComponent();

            section = new GuideSection("Σχολές");//parent Section1

            GuideSection subsection;

            subsection = new GuideSection("Οικονομικών, Επιχειρηματικών και Διεθνών Σπουδών");//Subsection1.1
            subsection.AddSubsection(new GuideSection("Οικονομικής Επιστήμης"));//Subsection1.1.1
            subsection.AddSubsection(new GuideSection("Οργάνωσης Διοίκησης Επιχειρήσεων"));//Subsection1.1.2
            subsection.AddSubsection(new GuideSection("Διεθνών και Ευρωπαικών Σπουδών"));//Subsection1.1.3
            subsection.AddSubsection(new GuideSection("Τουριστικών Σπουδών"));//Subsection1.1.4
            section.AddSubsection(subsection);

            subsection = new GuideSection("Ναυτιλίας και Βιομαχανίας");//Subsection1.2
            subsection.AddSubsection(new GuideSection("Ναυτιλιακών Σπουδών"));//Subsection1.2.1
            subsection.AddSubsection(new GuideSection("Βιομηχανικής Διοικησης Τεχνολογίας"));//Subsection1.2.2
            subsection.AddSubsection(new GuideSection(""));//Subsection1.2.3
            subsection.AddSubsection(new GuideSection(""));//Subsection1.2.4
            section.AddSubsection(subsection);

            subsection = new GuideSection("Χρηματοοικονομικής και Στατιστικής");//Subsection1.3
            subsection.AddSubsection(new GuideSection("Χρηματοοικονομικής και Τραπεζικής Διοικητικής"));//Subsection1.3.1
            subsection.AddSubsection(new GuideSection("Στατιστικής και Ασφαλιστικής Επιστήμης"));//Subsection1.3.2
            subsection.AddSubsection(new GuideSection(""));//Subsection1.3.3
            subsection.AddSubsection(new GuideSection(""));//Subsection1.3.4
            section.AddSubsection(subsection);

            subsection = new GuideSection("Τεχνολογιών Πληροφορικής και Τηλεπικοινωνιών");//Subsection1.4
            subsection.AddSubsection(new GuideSection("Πληροφορικής"));//Subsection1.4.1
            subsection.AddSubsection(new GuideSection("Ψηφιακών Συστημάτων"));//Subsection1.4.2
            subsection.AddSubsection(new GuideSection(""));//Subsection1.4.3
            subsection.AddSubsection(new GuideSection(""));//Subsection1.4.4
            section.AddSubsection(subsection);

            ContentPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ContentPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            NavButton1_Click(this, null);

            /*if (subsection.Name.Equals("")) TODO --> i must hide button with no content
            {
                ((Button)subsection).Visible = false;
            }*/
        }
    }
}
