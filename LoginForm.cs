using System;
using System.Data.SQLite;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class LoginForm : WindowsFormsApp2023_Final.BaseForm
    {
        SpeechSynthesizer engine = new SpeechSynthesizer();
        string name = "";
        string username = "";
        int id;
        string email = "";
        string password;
        String connectionString = "Data source=rad19900.db;Version=3;";
        SQLiteConnection connection;

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
                if (voice.VoiceInfo.Name == "Microsoft Zira Desktop")
                {
                    LanguageComboBox.Items.Add("Αγγλικά(Ηνωμένου Βασιλείου)");
                }
                else if (voice.VoiceInfo.Name == "Microsoft Hazel Desktop")
                {
                    LanguageComboBox.Items.Add("Αγγλικά(ΗΠΑ)");
                }
                else if (voice.VoiceInfo.Name == "Microsoft Hedda Desktop")
                {
                    LanguageComboBox.Items.Add("Γερμανικά");
                }
                else if (voice.VoiceInfo.Name == "Microsoft Hortense Desktop")
                {
                    LanguageComboBox.Items.Add("Γαλλικά");
                }
                else if (voice.VoiceInfo.Name == "Microsoft Helena Desktop")
                {
                    LanguageComboBox.Items.Add("Ισπανικά");
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

            while (reader.Read())
            {
                password = reader.GetString(0);
                username = reader.GetString(1);
                if (PasswordTextBox.Text.Equals(password) && UsernameTextBox.Text.Equals(username))
                {
                    password = reader.GetString(0);
                }
                Username = reader.GetString(1);
                if (PasswordTextBox.Text.Equals(password) && UsernameTextBox.Text.Equals(Username))
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
                UserSession session = UserSession.Instance;
                session.Username = username;
                session.UserId = id;
                session.Name = name;
                session.Email = email;
                session.Password = password;

                if (LanguageComboBox.Text != "") // Εάν ο χρήστης έχει επιλέξει γλώσσα
                {
                    if (LanguageComboBox.Text == "Αγγλικά(Ηνωμένου Βασιλείου)")
                    {
                        engine.SelectVoice("Microsoft Zira Desktop");
                        engine.SpeakAsync("Hello" + session.Name + "! Welcome to the University of Piraeus");
                    }
                    else if (LanguageComboBox.Text == "Αγγλικά(ΗΠΑ)")
                    {
                        engine.SelectVoice("Microsoft Hazel Desktop");
                        engine.SpeakAsync("Hello" + session.Name + "! Welcome to the University of Piraeus");
                    }
                    else if (LanguageComboBox.Text == "Γερμανικά")
                    {
                        engine.SelectVoice("Microsoft Hedda Desktop");
                        engine.SpeakAsync("Hallo" + session.Name + "! Willkommen an der Universität Piräus");
                    }
                    else if (LanguageComboBox.Text == "Γαλλικά")
                    {
                        engine.SelectVoice("Microsoft Hortense Desktop");
                        engine.SpeakAsync("Bonjour" + session.Name + "! Bienvenue à l'Université du Pirée");
                    }
                    else if (LanguageComboBox.Text == "Ισπανικά")
                    {
                        engine.SelectVoice("Microsoft Helena Desktop");
                        engine.SpeakAsync("¡Hola" + session.Name + "! Bienvenido a la Universidad del Pireo");
                    }
                }
                else
                {
                    MessageBox.Show("Γεια σου " + session.Name + ". Καλωσόρισες στο Πανεπιστήμιο Πειραιώς");
                }

                NavigateToForm<GuideForm>();
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Ο χρήστης ή ο κωδικός που εισάγατε δεν υπάρχει ή είναι λανθασμένος!!");
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
            }
        }

        private void VisitorButton_Click(object sender, EventArgs e)
        {
            UserSession session = UserSession.Instance;

            if (LanguageComboBox.Text != "") // Εάν ο χρήστης έχει επιλέξει γλώσσα
            {
                if (LanguageComboBox.Text == "Αγγλικά(Ηνωμένου Βασιλείου)")
                {
                    engine.SelectVoice("Microsoft Zira Desktop");
                    engine.SpeakAsync("Hello! Welcome to the University of Piraeus");
                }
                else if (LanguageComboBox.Text == "Αγγλικά(ΗΠΑ)")
                {
                    engine.SelectVoice("Microsoft Hazel Desktop");
                    engine.SpeakAsync("Hello! Welcome to the University of Piraeus");
                }
                else if (LanguageComboBox.Text == "Γερμανικά")
                {
                    engine.SelectVoice("Microsoft Hedda Desktop");
                    engine.SpeakAsync("Hallo! Willkommen an der Universität Piräus");
                }
                else if (LanguageComboBox.Text == "Γαλλικά")
                {
                    engine.SelectVoice("Microsoft Hortense Desktop");
                    engine.SpeakAsync("Bonjour! Bienvenue à l'Université du Pirée");
                }
                else if (LanguageComboBox.Text == "Ισπανικά")
                {
                    engine.SelectVoice("Microsoft Helena Desktop");
                    engine.SpeakAsync("¡Hola! Bienvenido a la Universidad del Pireo");
                }
            }
            NavigateToForm<GuideForm>();
        }
    }
}