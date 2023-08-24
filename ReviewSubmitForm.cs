using System;
using System.Data.SQLite;
using System.Windows.Forms;

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
            try
            {
                connection.Open();
                int grade = (int)numericUpDown2.Value;
                string insertSQL = "INSERT INTO reviews(comments, commentatorId, grade) VALUES(@comments, @commentatorId, @grade)";
                SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                command.Parameters.AddWithValue("@comments", ReviewTextBox.Text);
                command.Parameters.AddWithValue("@commentatorId", UserSession.Instance.UserId);
                command.Parameters.AddWithValue("@grade", grade);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Το σχόλιο υποβλήθηκε επιτυχώς!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            NavigateToForm<ReviewsForm>();
        }

        private void ReviewTextBox_Click(object sender, EventArgs e)
        {
            if (ReviewTextBox.Text.Equals("Γράψτε εδώ τα σχόλιά σας..."))
            {
                ReviewTextBox.Clear();
            }
        }
    }
}
