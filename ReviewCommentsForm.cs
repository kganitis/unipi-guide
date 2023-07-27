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
    public partial class ReviewCommentsForm : Form
    {
        String connectionString = "Data source = rad19900.db;Version=3;";
        SQLiteConnection connection;
        string onoma = "";

        public ReviewCommentsForm()
        {
            InitializeComponent();
        }

        public ReviewCommentsForm(string name) {
            InitializeComponent();
            onoma = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReviewCommentsForm_Load(object sender, EventArgs e)
        {
            
        }
        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name== "+onoma);
            try
            {
                connection.Open();
                string insertSQL = "INSERT INTO reviews(comments) VALUES('"+textBox1.Text+"')";
                SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Comment added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
