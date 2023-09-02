using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class CalendarForm : Form
    {
        private int month, year;

        public CalendarForm()
        {
            InitializeComponent();
            if (UserSession.Instance.IsVisitor())
            {
                AddEventLabel.Visible = false;
            }
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            DisplayCalendar(DateTime.Now);
        }

        private void DisplayCalendar(DateTime date)
        {
            month = date.Month;
            year = date.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = (int)startOfMonth.DayOfWeek;

            daycontainer.Controls.Clear();
            AddBlankDays(dayOfWeek);
            AddDaysOfMonth(daysInMonth);
        }

        private void AddBlankDays(int count)
        {
            for (int i = 0; i < count; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
        }

        private void AddDaysOfMonth(int daysInMonth)
        {
            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays ucdays = new UserControlDays(i, month, year, this);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            DateTime previousMonth = new DateTime(year, month, 1).AddMonths(-1);
            DisplayCalendar(previousMonth);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            DateTime nextMonth = new DateTime(year, month, 1).AddMonths(1);
            DisplayCalendar(nextMonth);
        }
    }
}
