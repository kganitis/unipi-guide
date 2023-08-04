using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class ReviewsForm : WindowsFormsApp2023_Final.GuideForm
    {

        String connectionString = "Data source=rad19900.db;Version=3;";
        SQLiteConnection connection;

        public ReviewsForm()
        {
            InitializeComponent();
            HighlightButton(NavButton4);
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            UserSession session = UserSession.Instance;
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String selectSQL = "SELECT comments, grade FROM reviews";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText(reader.GetString(0));
                richTextBox1.AppendText(" Total grade:  ");
                richTextBox1.AppendText(reader.GetInt32(1).ToString());
                richTextBox1.AppendText(" / 100");
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToForm<ReviewSubmitForm>();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            NavigateToForm<ReviewSubmitForm>();
        }

    }
}
