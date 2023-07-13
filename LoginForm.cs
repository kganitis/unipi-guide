using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class LoginForm : WindowsFormsApp2023_Final.BaseForm
    {
        String connectionString = "Data source=rad19900.db;Version=3;";
        SQLiteConnection connection;
        public LoginForm()
        {
            InitializeComponent();
            HideAllControls();
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectSQL = "SELECT passwordStudent, username FROM Student";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            bool foundMatch = false;

            while (reader.Read())
            {
                string password = reader.GetInt32(0).ToString();
                string username = reader.GetString(1);

                if (textBox2.Text.Equals(password) && textBox1.Text.Equals(username))
                {
                    foundMatch = true;
                    break;
                }
            }

            connection.Close();
            textBox1.Clear();
            textBox2.Clear();

            if (foundMatch)
            {
                MessageBox.Show("Καλωσορίσατε στο Πανεπιστήμιο Πειραιώς");
                NavigateToForm<GuideForm>();
            }
            else
            {
                MessageBox.Show("Ο χρήστης ή ο κωδικός που εισάγατε δεν υπάρχει ή είναι λανθασμένος!!");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            connection.Open();
            String selectSQL = "SELECT* FROM Student";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.AppendText(reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetInt16(2) + ", " + reader.GetString(3));
                richTextBox1.AppendText(Environment.NewLine);
            }
            connection.Close();
        }
    }
}
