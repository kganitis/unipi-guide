using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class UserControlDays : UserControl
    {
        String connectionString = "Data source=rad19900.db;Version=3;";
        SQLiteConnection connection;
        //let's create another static variable for day
        public static string static_day;
        /*
         * TODO --> addition of some kind of display to alert the user that he can add an event??
         */
        public UserControlDays(int numday)
        {
            InitializeComponent();
            lbdays.Text = numday + "";
            displayEvent();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            //start timer if usercontroldays is clicked
            //timer1.Start();
            if (UserSession.Instance.IsLoggedIn())
            {
                AddEventForm addEvent = new AddEventForm();
                addEvent.Show();
            }
        }

        private void displayEvent()
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String selectSQL = "select description from event where date = @date";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            command.Parameters.AddWithValue("@date",
            CalendarForm.static_year + "-" + CalendarForm.static_month.ToString("00") + "-" + lbdays.Text.PadLeft(2, '0'));
            SQLiteDataReader reader = command.ExecuteReader();
            int labelnum = 1;//label number for updating the two labels
            while (reader.Read())
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
                if (labelnum >= 3)
                {
                    break;
                }
            }
            //if there is no event or events, the labels become invisible, so the area is clickable
            if (lbevent1.Text.Equals(""))
            {
                lbevent1.Visible = false;
            }
            //if there is no senond event, the first event all the space
            if (lbevent2.Text.Equals(""))
            {
                lbevent2.Visible = false;
                lbevent1.Size = new Size(140, 60);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
        }

        //TODO --> create a timer for auto display event if new event is added
        private void timer1_Tick(object sender, EventArgs e)
        {
            //call the display Event method
            //displayEvent();
        }
    }
}
