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
    public partial class AddEventForm : Form
    {
        //create a connectionstring
        String connectionString = "Data source=rad19900.db;Version=3;";
        SQLiteConnection connection;

        public AddEventForm()
        {
            InitializeComponent();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            //let's call the static variable we declare
            txdate.Text = CalendarForm.static_year + "-" + CalendarForm.static_month + "-" + UserControlDays.static_day;
        }

        private void btnregister_Click(object sender, EventArgs e)// for registered users only
        {
            string date = txdate.Text;
            string description = rtxdescr.Text;
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String insertSQL = "insert INTO event (description, date, student_ID) values" +
                "(@description, @date, 2)";
            SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@description", description);
            command.ExecuteNonQuery();
            MessageBox.Show("Η Δραστηριότητα καταχωρήθηκε επιτυχώς!");
            this.Close();
            connection.Close();

            
        }
    }
}
