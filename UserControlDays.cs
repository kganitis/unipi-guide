using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class UserControlDays : UserControl
    {
        String connectionString = "Data source=rad19900.db;Version=3;";
        SQLiteConnection connection;
        //let's create another static variable for day
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            //start timer if usercontroldays is clicked
            //timer1.Start();
            //displayEvent();
            AddEventForm addEvent = new AddEventForm();
            addEvent.Show();
        }

        //Create a new method to display an event
        private void displayEvent()
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String selectSQL = "select description from event where date = @date";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            command.Parameters.AddWithValue("@date", 
            CalendarForm.static_year + "-" + CalendarForm.static_month + "-" + UserControlDays.static_day);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                lbevent1.Text = reader.GetString(0);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
        }
        
        private void displayAllEvents()
        {

        }
        //create a timer for auto display event if new event is added
        private void timer1_Tick(object sender, EventArgs e)
        {
            //call the display Event method
            //displayEvent();
        }
    }
}
