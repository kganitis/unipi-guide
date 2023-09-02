using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class AddEventForm : Form
    {
        private String connectionString = "Data source=rad19900.db;Version=3;";
        private SQLiteConnection connection;
        private CalendarForm calendar;

        public AddEventForm(string day, int month, int year, CalendarForm calendar)
        {
            InitializeComponent();
            txdate.Text = year + "-" + month.ToString("00") + "-" + day.PadLeft(2, '0');
            this.calendar = calendar;
        }

        private void btnregister_Click(object sender, EventArgs e) // for registered users only
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String insertSQL = "insert INTO event (description, date, student_ID) values" +
                "(@description, @date, @userID)";
            SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
            command.Parameters.AddWithValue("@date", txdate.Text);
            command.Parameters.AddWithValue("@description", rtxdescr.Text);
            command.Parameters.AddWithValue("userID", UserSession.Instance.UserId);
            command.ExecuteNonQuery();
            connection.Close();
            calendar.Close();
            new CalendarForm().Show();
            MessageBox.Show("Η Δραστηριότητα καταχωρήθηκε επιτυχώς!");
            this.Close();
        }
    }
}
