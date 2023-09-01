using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class AddEventForm : Form
    {
        String connectionString = "Data source=rad19900.db;Version=3;";
        SQLiteConnection connection;

        public AddEventForm()
        {
            InitializeComponent();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            txdate.Text = CalendarForm.static_year + "-" + CalendarForm.static_month.ToString("00") + "-" + UserControlDays.static_day.PadLeft(2, '0');
        }

        private void btnregister_Click(object sender, EventArgs e) // for registered users only
        {
            string date = txdate.Text;
            string description = rtxdescr.Text;
            int userID = UserSession.Instance.UserId;
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String insertSQL = "insert INTO event (description, date, student_ID) values" +
                "(@description, @date, @userID)";
            SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("userID", userID);
            command.ExecuteNonQuery();
            MessageBox.Show("Η Δραστηριότητα καταχωρήθηκε επιτυχώς!");
            this.Close();
            connection.Close();
        }
    }
}
