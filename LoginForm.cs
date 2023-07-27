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
        string name = "";
        int id;
        string password;
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
        public string getName() { 
            return name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectSQL = "SELECT passwordStudent, username, name, studentId FROM student";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            bool foundMatch = false;

            while (reader.Read())
            {
                password = reader.GetInt32(0).ToString();
                Username = reader.GetString(1);
                if (textBox2.Text.Equals(password) && textBox1.Text.Equals(Username))
                {
                    foundMatch = true;
                    name = reader.GetString(2);
                    id = reader.GetInt32(3);
                    break;
                }
            }
            MessageBox.Show("Hi " + reader.GetString(2) + ", welcome to Unipi");
            connection.Close();

            textBox1.Clear();
            textBox2.Clear();

            if (foundMatch)
            {
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
            String selectSQL = "SELECT* FROM student";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.AppendText(reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetInt16(2) + ", " + reader.GetString(3));
                richTextBox1.AppendText(Environment.NewLine);
            }
            connection.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
