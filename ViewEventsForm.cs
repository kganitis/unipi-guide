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
    public partial class ViewEventsForm : WindowsFormsApp2023_Final.GuideForm
    {
        UserSession session = UserSession.Instance;

        String connectionString = "Data source=rad19900.db;Version=3;";
        SQLiteConnection connection;

        string description, date;


        public ViewEventsForm()
        {
            InitializeComponent();
        }

        private void myClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hi!");
        }

        protected override void NavButton2_Click(object sender, EventArgs e)
        {
            label1.Text = "Όλες οι Δραστηριότητες";
           
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String selectSQL = "select description, date from event";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                description = reader.GetString(0);
                date = reader.GetString(1);

                Label label_desc = new Label();
                label_desc.AutoSize = true;
                label_desc.Font = new Font("Modern No. 20", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label_desc.BackColor = Color.Maroon;
                label_desc.ForeColor = Color.Transparent;
                label_desc.Location = new Point(100, 45 + i * label_desc.Height);
                label_desc.Name = "descreption";
                label_desc.Size = new Size(192, 132);
                label_desc.Text = description;
                ContentPanel.Controls.Add(label_desc);
                //label_desc.Click += new EventHandler(myClick);
                //Controls.Add(label_desc);

                Label label_date = new Label();
                label_date.AutoSize = true;
                label_date.Font = new Font("Modern No. 20", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label_date.ForeColor = Color.Maroon;
                label_date.Location = new Point(100, 45 + i * label_date.Height);
                label_date.Name = "date";
                label_date.Size = new Size(32, 32);
                label_date.Text = date;
                //label_date.Click += new EventHandler(myClick);
                //Controls.Add(label_date);

                i++;
                //label2.Text += date + "\n";
                //label3.Text += description + "\n";
            }
            reader.Close();
            command.Dispose();
            connection.Close();
        }

        protected override void NavButton3_Click(object sender, EventArgs e)
        {
            label1.Text = "Ημερολόγιο";
        }

        protected override void NavButton4_Click(object sender, EventArgs e)
        {
            label1.Text = "Καταχώρηση";
        }

        protected override void NavButton5_Click(object sender, EventArgs e)// μόνο για εγγεγραμένους χρήστες
        {
            label1.Text = "Καταχώρηση νέου Event";
        }
    }
}
