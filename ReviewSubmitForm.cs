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
            MessageBox.Show("Name== " + Username);
            try
            {
                connection.Open();
                string insertSQL = "INSERT INTO reviews(comments) VALUES('" + ReviewTextBox.Text + "')";
                SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Comment added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
