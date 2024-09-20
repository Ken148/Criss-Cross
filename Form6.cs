using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace criss_cross
{
    public partial class Form6 : Form
    {
        string username2;
        public Form6(string username)
        {
            InitializeComponent();
            username2 = username;
            label1.Text = label1.Text + " " + username2;
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int num1 = (groupBox2.Width - label1.Width) / 2;
            label1.Location = new Point(num1, label1.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(username2);
            form4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
