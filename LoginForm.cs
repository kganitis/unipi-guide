using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Speech.Synthesis;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2023_Final
{
    public partial class LoginForm : WindowsFormsApp2023_Final.BaseForm
    {
        SpeechSynthesizer engine = new SpeechSynthesizer();
      // string voice = "";
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
            //Γεμίζει το combobox με τις φωνές που υπάρχουν εγκατεστημένες στο λειτουργικό
            foreach (InstalledVoice voice in engine.GetInstalledVoices())
            {
                // comboBox1.Items.Add(voice.VoiceInfo.Name);
                if (voice.VoiceInfo.Name == "Microsoft Zira Desktop"){
                    comboBox1.Items.Add("Αγγλικά(Ηνωμένου Βασιλείου)");
                }
                else if (voice.VoiceInfo.Name == "Microsoft Hazel Desktop") {
                    comboBox1.Items.Add("Αγγλικά(ΗΠΑ)");
                }
                else if (voice.VoiceInfo.Name == "Microsoft Hedda Desktop") {
                    comboBox1.Items.Add("Γερμανικά");
                } 
                else if (voice.VoiceInfo.Name == "Microsoft Hortense Desktop") {
                    comboBox1.Items.Add("Γαλλικά");
                }
                else if (voice.VoiceInfo.Name == "Microsoft Helena Desktop") {
                    comboBox1.Items.Add("Ισπανικά");
                }
            }
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            richTextBox1.Visible = false;
        }

        //Εισοδος χρήστη
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectSQL = "SELECT passwordStudent, username, name, studentId, email FROM student";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            bool foundMatch = false;

            while (reader.Read())
            {
                password = reader.GetString(0);
                username = reader.GetString(1);
                if (textBox2.Text.Equals(password) && textBox1.Text.Equals(username))

                    password = reader.GetString(0);
                Username = reader.GetString(1);
                if (textBox2.Text.Equals(password) && textBox1.Text.Equals(Username))

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
                session.Username = username; // Replace with actual username
                session.UserId = id; // Replace with actual user ID or relevant data
                session.Name = name; // Replace with actual username
                session.Email = email; // Replace with actual user ID or relevant data
                session.Password = password;

                if (comboBox1.Text != "") {
                    if (comboBox1.Text == "Αγγλικά(Ηνωμένου Βασιλείου)")
                    {
                        engine.SelectVoice("Microsoft Zira Desktop");
                        engine.SpeakAsync("Hello" + session.Name + "Welcome to the University of Piraeus");
                    }
                    else if (comboBox1.Text == "Αγγλικά(ΗΠΑ)") {
                        engine.SelectVoice("Microsoft Hazel Desktop");
                        engine.SpeakAsync("Hello" + session.Name + "Welcome to the University of Piraeus");
                    }
                    else if (comboBox1.Text == "Γερμανικά") {
                        engine.SelectVoice("Microsoft Hedda Desktop");
                        engine.SpeakAsync("Hallo"+session.Name+ "Willkommen an der Universität Piräus");
                    }
                    else if (comboBox1.Text == "Γαλλικά") {
                        engine.SelectVoice("Microsoft Hortense Desktop");
                        engine.SpeakAsync("Bonjour" +session.Name+ "Bienvenue à l'Université du Pirée");
                    }
                    else if (comboBox1.Text == "Ισπανικά") {
                        engine.SelectVoice("Microsoft Helena Desktop");
                        engine.SpeakAsync("¡Hola" +session.Name+ "Bienvenido a la Universidad del Pireo");
                    }
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Γεια σου " + session.Name + ". Καλωσόρισες στο Πανεπιστήμιο Πειραιώς");
                    NavigateToForm<GuideForm>();
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ο χρήστης ή ο κωδικός που εισάγατε δεν υπάρχει ή είναι λανθασμένος!!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        //Είσοδος Επισκέπτη--Κουμπί
        private void button2_Click(object sender, EventArgs e)
        {
            UserSession session = UserSession.Instance;
            session.Username = ""; // Replace with actual username
          
            if (comboBox1.Text != "")
            {
                if (comboBox1.Text == "Αγγλικά(Ηνωμένου Βασιλείου)")
                {
                    engine.SelectVoice("Microsoft Zira Desktop");
                    engine.SpeakAsync("Hello!Welcome to the University of Piraeus");
                }
                else if (comboBox1.Text == "Αγγλικά(ΗΠΑ)")
                {
                    engine.SelectVoice("Microsoft Hazel Desktop");
                    engine.SpeakAsync("Hello!Welcome to the University of Piraeus");
                }
                else if (comboBox1.Text == "Γερμανικά")
                {
                    engine.SelectVoice("Microsoft Hedda Desktop");
                    engine.SpeakAsync("Hallo!Willkommen an der Universität Piräus");
                }
                else if (comboBox1.Text == "Γαλλικά")
                {
                    engine.SelectVoice("Microsoft Hortense Desktop");
                    engine.SpeakAsync("Bonjour!Bienvenue à l'Université du Pirée");
                }
                else if (comboBox1.Text == "Ισπανικά")
                {
                    engine.SelectVoice("Microsoft Helena Desktop");
                    engine.SpeakAsync("¡Hola!Bienvenido a la Universidad del Pireo");
                }
                timer1.Start();
            }
            else
            {
                NavigateToForm<GuideForm>();
            }

            //Εμφάνιση εγγραφών του πίνακα μαθητή στο richTextBox1
            /*  connection.Open();
              String selectSQL = "SELECT* FROM student";
              SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
              SQLiteDataReader reader = command.ExecuteReader();
              while (reader.Read())
              {
                  richTextBox1.AppendText(reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2) + ", " + reader.GetString(3));
                  richTextBox1.AppendText(Environment.NewLine);
              }
              connection.Close();
            */
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Παρακαλώ επιλέξτε τη Γλωσσα που επιθυμείτε!!");
            }
            if (comboBox1.Text != "")
            {
                if (comboBox1.Text == "Αγγλικά(Ηνωμένου Βασιλείου)")
                {
                    engine.SelectVoice("Microsoft Zira Desktop");
                    engine.SpeakAsync("Hello!Welcome to the University of Piraeus");
                }
                else if (comboBox1.Text == "Αγγλικά(ΗΠΑ)")
                {
                    engine.SelectVoice("Microsoft Hazel Desktop");
                    engine.SpeakAsync("Hello!Welcome to the University of Piraeus");
                }
                else if (comboBox1.Text == "Γερμανικά")
                {
                    engine.SelectVoice("Microsoft Hedda Desktop");
                    engine.SpeakAsync("Hallo!Willkommen an der Universität Piräus");
                }
                else if (comboBox1.Text == "Γαλλικά")
                {
                    engine.SelectVoice("Microsoft Hortense Desktop");
                    engine.SpeakAsync("Bonjour!Bienvenue à l'Université du Pirée");
                }
                else if (comboBox1.Text == "Ισπανικά")
                {
                    engine.SelectVoice("Microsoft Helena Desktop");
                    engine.SpeakAsync("¡Hola!Bienvenido a la Universidad del Pireo");
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            NavigateToForm<GuideForm>();
            timer1.Stop();
        }
    }
}
