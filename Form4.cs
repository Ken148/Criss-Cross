using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace criss_cross
{
    public partial class Form4 : Form
    {
        string username2;
        public Form4(string username)
        {
            InitializeComponent();
            username2 = username;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(username2);
            form1.Show();
            this.Hide();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(username2);
            form6.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(username2);
            form7.Show();
            this.Hide();
        }
    }
}
