﻿using System;
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
            HighlightButton(NavButton1);
        }

        static string LineBreak(string input, int position)//method to create line breaks to labels
        {
            StringBuilder sb = new StringBuilder(input);

            if (position < input.Length)
            {
                sb.Insert(position, Environment.NewLine);
            }
            return sb.ToString();
        }


        protected override void NavButtonHome_Click(object sender, EventArgs e)
        {
            //NavigateToForm<GuideForm>();
        }

        protected override void NavButton2_Click(object sender, EventArgs e)
        {
            label1.Text = "Όλες οι Δραστηριότητες";
           
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String selectSQL = "select description, date from event order by date desc";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                description = reader.GetString(0);
                //description = LineBreak(reader.GetString(0), 76);// in case i want a line break to fit screen
                date = reader.GetString(1);

                Label label_desc = new Label();
                label_desc.AutoSize = true;
                //label_desc.MaximumSize = new Size(this.Width, 0);
                //label_desc.AutoEllipsis = false;
                label_desc.Font = new Font("Modern No. 20", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label_desc.BackColor = Color.Transparent;
                label_desc.ForeColor = Color.Black;
                label_desc.Location = new Point(120, 115 + (3 * i) * label_desc.Height);
                label_desc.Name = "description";
                label_desc.Size = new Size(592, 132);
                label_desc.Text = description;
                ContentPanel.Controls.Add(label_desc);

                Label label_date = new Label();
                label_date.AutoSize = true;
                label_date.Font = new Font("Modern No. 20", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label_date.ForeColor = Color.Maroon;
                label_date.Location = new Point(30, 115 + (3 * i) * label_date.Height);
                label_date.Name = "date";
                label_date.Size = new Size(32, 32);
                label_date.Text = date;
                ContentPanel.Controls.Add(label_date);

                i++;
                
            }
            reader.Close();
            command.Dispose();
            connection.Close();
        }

        protected override void NavButton3_Click(object sender, EventArgs e)
        {
            label1.Text = "Ημερολόγιο";
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.ShowDialog();
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
