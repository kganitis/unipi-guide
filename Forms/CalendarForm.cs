using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class CalendarForm : Form
    {
        int month, year;
        // create a static variable that we can pass to another form for month and year
        public static int static_month, static_year;

        public CalendarForm()
        {
            InitializeComponent();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }
        
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            static_month = month;
            static_year = year;
            
            //Let's get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //get the counts of days of the month
            int days = DateTime.DaysInMonth(year, month);
            
            // convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            /**
             * decrement month to go to previous month. In the beginning of year (month = 1),  
             * month resets to 12 and year decreases by 1
             */
            if (month == 1)
            {
                month = 13;
                year--;
            }
            month--;
            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            
            //get the counts of days of the month
            int days = DateTime.DaysInMonth(year, month);
            
            // convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            /**
             * increment month to go to next month. In the end of year (month = 12),  
             * month resets to 0 and year increases by 1
             */
            if (month == 12)
            {
                month = 0;
                year++;
            }
            month++;
            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            
            //get the counts of days of the month
            int days = DateTime.DaysInMonth(year, month);
            
            // convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

    }

}
