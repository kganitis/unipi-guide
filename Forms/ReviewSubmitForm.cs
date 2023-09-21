using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2023_Final.Properties;

namespace WindowsFormsApp2023_Final
{
    public partial class ReviewSubmitForm : WindowsFormsApp2023_Final.BaseForm
    {
        String defaultText;
        int grade;
        PictureBox[] stars;
        SQLiteConnection connection;

        public ReviewSubmitForm()
        {
            InitializeComponent();
            defaultText = "Γράψτε εδώ τα σχόλιά σας...";
            grade = 0;
            stars = new PictureBox[5] { StarPictureBox1, StarPictureBox2, StarPictureBox3, StarPictureBox4, StarPictureBox5 };
            connection = new SQLiteConnection(connectionString);
            ReviewTextBox.Text = defaultText;
        }

        private void SetGrade(int grade)
        {
            this.grade = grade;

            for (int i = 0; i < stars.Length; i++)
            {
                if (i < grade)
                {
                    stars[i].BackgroundImage = Resources.star_gold;
                }
                else
                {
                    stars[i].BackgroundImage = Resources.star_black;
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool reviewIsWritten = !String.IsNullOrEmpty(ReviewTextBox.Text) && !ReviewTextBox.Text.Equals(defaultText);
            bool starIsSelected = grade != 0;
            if (reviewIsWritten && starIsSelected)
            {
                try
                {
                    connection.Open();
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
                SubmitButton.Enabled = false;
                ClearButton_Click(sender, e);
                NavigateToForm<ReviewsForm>();
            }
        }

        private void ReviewTextBox_Click(object sender, EventArgs e)
        {
            if (ReviewTextBox.Text.Equals(defaultText))
            {
                ReviewTextBox.Clear();
            }
        }

        private void StarPictureBox1_Click(object sender, EventArgs e)
        {
            SetGrade(1);
        }

        private void StarPictureBox2_Click(object sender, EventArgs e)
        {
            SetGrade(2);
        }

        private void StarPictureBox3_Click(object sender, EventArgs e)
        {
            SetGrade(3);
        }

        private void StarPictureBox4_Click(object sender, EventArgs e)
        {
            SetGrade(4);
        }

        private void StarPictureBox5_Click(object sender, EventArgs e)
        {
            SetGrade(5);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ReviewTextBox.Clear();
            SetGrade(0);
        }
    }
}
