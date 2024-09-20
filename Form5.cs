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

namespace criss_cross
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox1.Text;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=database.db"))
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "INSERT INTO users (username, password) VALUES (@username, @password)";
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Account was successfully created!");

                Form3 form3 = new Form3();
                form3.Show();
                this.Hide(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with the users registration: " + ex.Message);
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
