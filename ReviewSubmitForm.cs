using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2023_Final
{
    public partial class ReviewSubmitForm : WindowsFormsApp2023_Final.BaseForm
    {
        String connectionString = "Data source = rad19900.db;Version=3;";
        SQLiteConnection connection;

        public ReviewSubmitForm()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserSession session = UserSession.Instance;
           
            MessageBox.Show("Name== " + session.Name);
            try
            {
                connection.Open();
                int grade = (int)numericUpDown2.Value;
                // string insertSQL = "INSERT INTO reviews(comments,commentatorId,grade) VALUES('" + ReviewTextBox.Text + "','"+session.UserId+"','"+grade+"')";
                string insertSQL = "INSERT INTO reviews(comments, commentatorId, grade) VALUES(@comments, @commentatorId, @grade)";
                SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                command.Parameters.AddWithValue("@comments", ReviewTextBox.Text);
                command.Parameters.AddWithValue("@commentatorId", session.UserId);
                command.Parameters.AddWithValue("@grade", grade);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Comment added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
