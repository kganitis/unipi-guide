using System;
using System.Data.SQLite;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class LoginForm : WindowsFormsApp2023_Final.BaseForm
    {
        protected string name = "";
        protected string username = "";
        protected int id;
        protected string email = "";
        protected string password;
        protected SQLiteConnection connection;

        public LoginForm()
        {
            InitializeComponent();
            HideAllControls();
            LoadInstalledVoices();
        }

        private void LoadInstalledVoices()
        {
            // Γεμίζει το combobox με τις φωνές που υπάρχουν εγκατεστημένες στο λειτουργικό
            foreach (InstalledVoice voice in engine.GetInstalledVoices())
            {
                switch (voice.VoiceInfo.Name)
                {
                    case "Microsoft Zira Desktop":
                        LanguageComboBox.Items.Add("Αγγλικά(Ηνωμένου Βασιλείου)");
                        break;
                    case "Microsoft Hazel Desktop":
                        LanguageComboBox.Items.Add("Αγγλικά(ΗΠΑ)");
                        break;
                    case "Microsoft Hedda Desktop":
                        LanguageComboBox.Items.Add("Γερμανικά");
                        break;
                    case "Microsoft Hortense Desktop":
                        LanguageComboBox.Items.Add("Γαλλικά");
                        break;
                    case "Microsoft Helena Desktop":
                        LanguageComboBox.Items.Add("Ισπανικά");
                        break;
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string selectSQL = "SELECT passwordStudent, username, name, studentId, email FROM student";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            
            bool foundMatch = false;
            while (reader.Read()) // Τι γίνεται εδώ μέσα; Μπορούμε να το απλοποιήσουμε;
            {
                password = reader.GetString(0);
                username = reader.GetString(1);
                if (PasswordTextBox.Text.Equals(password) && UsernameTextBox.Text.Equals(username))
                {
                    password = reader.GetString(0);
                }
                username = reader.GetString(1);
                if (PasswordTextBox.Text.Equals(password) && UsernameTextBox.Text.Equals(username))
                {
                    foundMatch = true;
                    password = reader.GetString(0);
                    username = reader.GetString(1);
                    name = reader.GetString(2);
                    id = reader.GetInt32(3);
                    email = reader.GetString(4);
                    break;
                }
            }

            connection.Close();

            if (foundMatch)
            {
                UpdateSessionInfo();
                SpeakWelcomeMessage();
                NavigateToForm<GuideForm>();
            }
            else
            {
                MessageBox.Show("Ο χρήστης ή ο κωδικός που εισάγατε δεν υπάρχει ή είναι λανθασμένος!");
            }

            UsernameTextBox.Clear();
            PasswordTextBox.Clear();

            void UpdateSessionInfo()
            {
                UserSession session = UserSession.Instance;
                session.Username = username;
                session.UserId = id;
                session.Name = name;
                session.Email = email;
                session.Password = password;
            }
        }

        private void SpeakWelcomeMessage()
        {
            String welcomeMessage;
            
            // Προσθήκη ενός space στο όνομα (εάν έχει τεθεί όνομα) για εμφάνιση στο μήνυμα παρακάτω
            String welcomeName = name;
            if (!String.IsNullOrEmpty(welcomeName))
            {
                welcomeName = " " + welcomeName;
            }

            bool isSetLanguage = LanguageComboBox.Text != "";
            if (isSetLanguage)
            {
                switch (LanguageComboBox.Text)
                {
                    case "Αγγλικά(Ηνωμένου Βασιλείου)":
                        engine.SelectVoice("Microsoft Zira Desktop");
                        welcomeMessage = "Hello" + welcomeName + "! Welcome to the University of Piraeus!";
                        break;
                    case "Αγγλικά(ΗΠΑ)":
                        engine.SelectVoice("Microsoft Hazel Desktop");
                        welcomeMessage = "Hello" + welcomeName + "! Welcome to the University of Piraeus!";
                        break;
                    case "Γερμανικά":
                        engine.SelectVoice("Microsoft Hedda Desktop");
                        welcomeMessage = "Hallo" + welcomeName + "! Willkommen an der Universität Piräus!";
                        break;
                    case "Γαλλικά":
                        engine.SelectVoice("Microsoft Hortense Desktop");
                        welcomeMessage = "Bonjour" + welcomeName + "! Bienvenue à l'Université du Pirée!";
                        break;
                    case "Ισπανικά":
                        engine.SelectVoice("Microsoft Helena Desktop");
                        welcomeMessage = "¡Hola" + welcomeName + "! Bienvenido a la Universidad del Pireo!";
                        break;
                    default:
                        welcomeMessage = "";
                        break;
                }
                engine.SpeakAsync(welcomeMessage);
            }
            else
            {
                welcomeMessage = "Γεια σου" + welcomeName + ". Καλωσόρισες στο Πανεπιστήμιο Πειραιώς!";
            }
            FormCacheManager.Instance.GetFormInstance<GuideForm>().UpdateWelcomeMessage(welcomeMessage);
        }

        private void VisitorButton_Click(object sender, EventArgs e)
        {
            SpeakWelcomeMessage();
            NavigateToForm<GuideForm>();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            NavigateToForm<RegisterForm>();
        }
    }
}