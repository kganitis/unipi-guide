using System;
using System.Data.SQLite;

namespace WindowsFormsApp2023_Final
{
    public partial class ReviewsForm : WindowsFormsApp2023_Final.GuideForm
    {

        String connectionString = "Data source=rad19900.db;Version=3;";
        SQLiteConnection connection;

        public ReviewsForm()
        {
            InitializeComponent();
            HighlightButton(NavButton4);
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            // Απόκρυψη κουμπιού υποβολής σχολίου για τους επισκέπτες
            if (String.IsNullOrEmpty(UserSession.Instance.Username))
            {
                ReviewSubmitButton.Visible = false; // Απόκρυψη του κουμπιού
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
            while (reader.Read())
            {
                ReviewsTextBox.AppendText(Environment.NewLine);
                ReviewsTextBox.AppendText(Environment.NewLine);
                ReviewsTextBox.AppendText(reader.GetString(0));
                ReviewsTextBox.AppendText(" Total grade:  ");
                ReviewsTextBox.AppendText(reader.GetInt32(1).ToString());
                ReviewsTextBox.AppendText(" / 100");
            }
            connection.Close();
        }

        private void ReviewSubmitButton_Click(object sender, EventArgs e)
        {
            NavigateToForm<ReviewSubmitForm>();
        }
    }
}
