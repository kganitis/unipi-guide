using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class UserControlDays : UserControl
    {
        private String connectionString = "Data source=rad19900.db;Version=3;";
        private SQLiteConnection connection;
        private CalendarForm calendar;
        private int month, year;
        private string day;

        public UserControlDays(int numday, int month, int year, CalendarForm calendar)
        {
            InitializeComponent();
            lbdays.Text = numday + "";
            this.month = month;
            this.year = year;
            this.calendar = calendar;
            displayEvent();
        }

        private void AddEvent()
        {
            if (UserSession.Instance.IsLoggedIn())
            {
                AddEventForm addEvent = new AddEventForm(lbdays.Text, month, year, calendar);
                addEvent.Show();
            }
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        private void lbevent1_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        private void lbevent2_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        private void lbdays_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        private void displayEvent()
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String selectSQL = "select description from event where date = @date";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            command.Parameters.AddWithValue("@date",
            year + "-" + month.ToString("00") + "-" + lbdays.Text.PadLeft(2, '0'));
            SQLiteDataReader reader = command.ExecuteReader();
            int labelnum = 1; // label number for updating the two labels
            while (reader.Read() && labelnum < 3)
            {
                if (labelnum == 1)
                {
                    lbevent1.Text = reader.GetString(0);
                }
                else if (labelnum == 2)
                {
                    lbevent2.Text = reader.GetString(0);
                }
                labelnum++;
            }
            // if there is no senond event, the first event takes all the available space
            if (lbevent2.Text.Equals(""))
            {
                lbevent2.Visible = false;
                lbevent1.Size = new Size(lbevent1.Width, lbevent1.Height * 2); 
            }
            reader.Close();
            command.Dispose();
            connection.Close();
        }
    }
}
