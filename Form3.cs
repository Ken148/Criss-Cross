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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace criss_cross
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox2.Focus();
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
                        cmd.CommandText = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int stevec = Convert.ToInt32(cmd.ExecuteScalar());

                        if (stevec > 0)
                        {
                            MessageBox.Show("Login successful!");
                            Form6 form6 = new Form6(username);
                            Form4 form4 = new Form4(username);
                            form6.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}