using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class ReviewSubmitForm : WindowsFormsApp2023_Final.BaseForm
    {
<<<<<<< HEAD:ReviewSubmitForm.cs
        int grade;
        String connectionString = "Data source = rad19900.db;Version=3;";
=======
>>>>>>> 26b4658fde9774219534e38806c0df3718782632:Forms/ReviewSubmitForm.cs
        SQLiteConnection connection;

        public ReviewSubmitForm()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);
            numericUpDown2.Visible = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
<<<<<<< HEAD:ReviewSubmitForm.cs
        {
            UserSession session = UserSession.Instance;
           
           // MessageBox.Show("Name== " + session.Name);
            try
            {
                connection.Open();
                //  int grade = (int)numericUpDown2.Value;
                // string insertSQL = "INSERT INTO reviews(comments,commentatorId,grade) VALUES('" + ReviewTextBox.Text + "','"+session.UserId+"','"+grade+"')";
=======
        {         
            try
            {
                connection.Open();
                int grade = (int)numericUpDown2.Value;
>>>>>>> 26b4658fde9774219534e38806c0df3718782632:Forms/ReviewSubmitForm.cs
                string insertSQL = "INSERT INTO reviews(comments, commentatorId, grade) VALUES(@comments, @commentatorId, @grade)";
                SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                command.Parameters.AddWithValue("@comments", ReviewTextBox.Text);
                command.Parameters.AddWithValue("@commentatorId", UserSession.Instance.UserId);
                command.Parameters.AddWithValue("@grade", grade);
                command.ExecuteNonQuery();
                connection.Close();
<<<<<<< HEAD:ReviewSubmitForm.cs

                MessageBox.Show("Comment added successfully!");
                SubmitButton.Enabled = false;
                ReviewTextBox.Text = "";
                guna2Button1.BackgroundImage = Properties.Resources.blackStar3;
                guna2Button2.BackgroundImage = Properties.Resources.blackStar3;
                guna2Button3.BackgroundImage = Properties.Resources.blackStar3;
                guna2Button4.BackgroundImage = Properties.Resources.blackStar3;
                guna2Button5.BackgroundImage = Properties.Resources.blackStar3;
=======
                MessageBox.Show("Το σχόλιο υποβλήθηκε επιτυχώς!");
>>>>>>> 26b4658fde9774219534e38806c0df3718782632:Forms/ReviewSubmitForm.cs
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            NavigateToForm<ReviewsForm>();
        }
<<<<<<< HEAD:ReviewSubmitForm.cs
       

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

=======

        private void ReviewTextBox_Click(object sender, EventArgs e)
        {
            if (ReviewTextBox.Text.Equals("Γράψτε εδώ τα σχόλιά σας..."))
            {
                ReviewTextBox.Clear();
            }
>>>>>>> 26b4658fde9774219534e38806c0df3718782632:Forms/ReviewSubmitForm.cs
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            grade = 1;
            guna2Button1.BackgroundImage = Properties.Resources.yellow;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            grade = 2;
            guna2Button1.BackgroundImage = Properties.Resources.yellow;
            guna2Button2.BackgroundImage = Properties.Resources.yellow;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            grade = 3;
            guna2Button1.BackgroundImage = Properties.Resources.yellow;
            guna2Button2.BackgroundImage = Properties.Resources.yellow;
            guna2Button3.BackgroundImage = Properties.Resources.yellow;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            grade = 4;
            guna2Button1.BackgroundImage = Properties.Resources.yellow;
            guna2Button2.BackgroundImage = Properties.Resources.yellow;
            guna2Button3.BackgroundImage = Properties.Resources.yellow;
            guna2Button4.BackgroundImage = Properties.Resources.yellow;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            grade = 5;
            guna2Button1.BackgroundImage = Properties.Resources.yellow;
            guna2Button2.BackgroundImage = Properties.Resources.yellow;
            guna2Button3.BackgroundImage = Properties.Resources.yellow;
            guna2Button4.BackgroundImage = Properties.Resources.yellow;
            guna2Button5.BackgroundImage = Properties.Resources.yellow;
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            guna2Button1.BackgroundImage = Properties.Resources.blackStar3;
            guna2Button2.BackgroundImage = Properties.Resources.blackStar3;
            guna2Button3.BackgroundImage = Properties.Resources.blackStar3;
            guna2Button4.BackgroundImage = Properties.Resources.blackStar3;
            guna2Button5.BackgroundImage = Properties.Resources.blackStar3;
        }
    }
}
