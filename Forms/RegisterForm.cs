using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class RegisterForm : WindowsFormsApp2023_Final.LoginForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            username = UsernameTextBox.Text;
            password = PasswordTextBox.Text;
            name = NameTextBox.Text;
            email = MailTextBox.Text;

            if (email != String.Empty && username != String.Empty && password != String.Empty && name != String.Empty)
            {
                try
                {
                    string insertSQL = "INSERT INTO student(name, email, passwordStudent, username) VALUES(@name, @email, @password, @username)";
                    SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@username", username);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Η εγγραφή πραγματοποιήθηκε επιτυχώς!");
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    Hide();
                    UsernameTextBox.Clear();
                    PasswordTextBox.Clear();
                    NameTextBox.Clear();
                    MailTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            NameTextBox.Clear();
            MailTextBox.Clear();
        }
    }
}
