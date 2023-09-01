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
        public static string static_day;

        public UserControlDays(int numday)
        {
            InitializeComponent();
            lbdays.Text = numday + "";
            displayEvent();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            if (UserSession.Instance.IsLoggedIn())
            {
                AddEventForm addEvent = new AddEventForm();
                addEvent.Show();
            }
        }

        public void displayEvent()
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String selectSQL = "select description from event where date = @date";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            command.Parameters.AddWithValue("@date",
            CalendarForm.static_year + "-" + CalendarForm.static_month.ToString("00") + "-" + lbdays.Text.PadLeft(2, '0'));
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
            // if there is no event or events, the labels become invisible, so the area is clickable
            if (lbevent1.Text.Equals(""))
            {
                lbevent1.Visible = false;
            }
            if (lbevent2.Text.Equals(""))
            {
                lbevent2.Visible = false;
                lbevent1.Size = new Size(140, 60); // if there is no senond event, the first event takes all the available space
                // NAI αλλά τώρα δεν μπορούμε να προσθέσουμε δεύτερο !!!
            }
            reader.Close();
            command.Dispose();
            connection.Close();
        }
    }
}
