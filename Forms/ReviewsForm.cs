using System;
using System.Data.SQLite;

namespace WindowsFormsApp2023_Final
{
    public partial class ReviewsForm : WindowsFormsApp2023_Final.GuideForm
    {
        SQLiteConnection connection;

        public ReviewsForm()
        {
            InitializeComponent();
            HighlightButton(NavButton4);
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            // Απόκρυψη κουμπιού υποβολής σχολίου για τους επισκέπτες
            if (UserSession.Instance.IsVisitor())
            {
                ReviewSubmitButton.Visible = false;
            }
        }

        private void ReviewsForm_Activated(object sender, EventArgs e)
        {
            ReviewsTextBox.Clear();

            // Φορτώνει από τη βάση τις καταχωρημένες αξιολογήσεις και τις εμφανίζει
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String selectSQL = "SELECT comments, grade FROM reviews";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            string review, grade;
            while (reader.Read())
            {
                review = reader.GetString(0);
                grade = reader.GetInt32(1).ToString();
                ReviewsTextBox.AppendText($"\n{review} ({grade} / 5)\n");
            }
            connection.Close();
        }

        private void ReviewSubmitButton_Click(object sender, EventArgs e)
        {
            NavigateToForm<ReviewSubmitForm>();
        }
    }
}
