using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace criss_cross
{
    public partial class Form1 : Form
    {
        string username2;
        public Form1(string username)
        {
            InitializeComponent();
            username2 = username;
        }
        int num = 1;
        bool win = false;
        bool righttop = false;
        bool rightmiddle = false;
        bool rightbottom = false;
        bool middletop = false;
        bool middle = false;
        bool middlebottome = false;
        bool lefttop = false;
        bool leftmiddle = false;
        bool leftbottom = false;

        public void PreveriZmago()
        {
            //vse za playerja 1

            if (pictureBox1.Visible == true && pictureBox2.Visible == true && pictureBox3.Visible == true)
            {
                if(win == false)
                {
                    label3.Visible = true;
                    win = true;
                    int a;
                    a = Convert.ToInt32(label4.Text);
                    a = a + 1;
                    label4.Text = a.ToString();
                }
            }

            if (pictureBox4.Visible == true && pictureBox5.Visible == true && pictureBox6.Visible == true)
            {
                if (win == false)
                {
                    label3.Visible = true;
                    win = true;
                    int a;
                    a = Convert.ToInt32(label4.Text);
                    a = a + 1;
                    label4.Text = a.ToString();
                }
            }

            if (pictureBox7.Visible == true && pictureBox8.Visible == true && pictureBox9.Visible == true)
            {
                if (win == false)
                {
                    label3.Visible = true;
                    win = true;
                    int a;
                    a = Convert.ToInt32(label4.Text);
                    a = a + 1;
                    label4.Text = a.ToString();
                }
            }

            if (pictureBox1.Visible == true && pictureBox4.Visible == true && pictureBox7.Visible == true)
            {
                if (win == false)
                {
                    label3.Visible = true;
                    win = true;
                    int a;
                    a = Convert.ToInt32(label4.Text);
                    a = a + 1;
                    label4.Text = a.ToString();
                }
            }

            if (pictureBox2.Visible == true && pictureBox5.Visible == true && pictureBox8.Visible == true)
            {
                if (win == false)
                {
                    label3.Visible = true;
                    win = true;
                    int a;
                    a = Convert.ToInt32(label4.Text);
                    a = a + 1;
                    label4.Text = a.ToString();
                }
            }

            if (pictureBox3.Visible == true && pictureBox6.Visible == true && pictureBox9.Visible == true)
            {
                if (win == false)
                {
                    label3.Visible = true;
                    win = true;
                    int a;
                    a = Convert.ToInt32(label4.Text);
                    a = a + 1;
                    label4.Text = a.ToString();
                }
            }

            if (pictureBox1.Visible == true && pictureBox5.Visible == true && pictureBox9.Visible == true)
            {
                if (win == false)
                {
                    label3.Visible = true;
                    win = true;
                    int a;
                    a = Convert.ToInt32(label4.Text);
                    a = a + 1;
                    label4.Text = a.ToString();
                }
            }

            if (pictureBox3.Visible == true && pictureBox5.Visible == true && pictureBox7.Visible == true)
            {
                if (win == false)
                {
                    label3.Visible = true;
                    win = true;
                    int a;
                    a = Convert.ToInt32(label4.Text);
                    a = a + 1;
                    label4.Text = a.ToString();
                }
            }

            //vse za playerja 2

            if (pictureBox10.Visible == true && pictureBox11.Visible == true && pictureBox12.Visible == true)
            {
                if (win == false)
                {
                    label7.Visible = true;
                    win = true;
                    int a2;
                    a2 = Convert.ToInt32(label6.Text);
                    a2 = a2 + 1;
                    label6.Text = a2.ToString();
                }
            }

            if (pictureBox13.Visible == true && pictureBox14.Visible == true && pictureBox15.Visible == true)
            {
                if (win == false)
                {
                    label7.Visible = true;
                    win = true;
                    int a2;
                    a2 = Convert.ToInt32(label6.Text);
                    a2 = a2 + 1;
                    label6.Text = a2.ToString();
                }
            }

            if (pictureBox16.Visible == true && pictureBox17.Visible == true && pictureBox18.Visible == true)
            {
                if (win == false)
                {
                    label7.Visible = true;
                    win = true;
                    int a2;
                    a2 = Convert.ToInt32(label6.Text);
                    a2 = a2 + 1;
                    label6.Text = a2.ToString();
                }
            }

            if (pictureBox10.Visible == true && pictureBox13.Visible == true && pictureBox16.Visible == true)
            {
                if (win == false)
                {
                    label7.Visible = true;
                    win = true;
                    int a2;
                    a2 = Convert.ToInt32(label6.Text);
                    a2 = a2 + 1;
                    label6.Text = a2.ToString();
                }
            }

            if (pictureBox11.Visible == true && pictureBox14.Visible == true && pictureBox17.Visible == true)
            {
                if (win == false)
                {
                    label7.Visible = true;
                    win = true;
                    int a2;
                    a2 = Convert.ToInt32(label6.Text);
                    a2 = a2 + 1;
                    label6.Text = a2.ToString();
                }
            }

            if (pictureBox12.Visible == true && pictureBox15.Visible == true && pictureBox18.Visible == true)
            {
                if (win == false)
                {
                    label7.Visible = true;
                    win = true;
                    int a2;
                    a2 = Convert.ToInt32(label6.Text);
                    a2 = a2 + 1;
                    label6.Text = a2.ToString();
                }
            }

            if (pictureBox10.Visible == true && pictureBox14.Visible == true && pictureBox18.Visible == true)
            {
                if (win == false)
                {
                    label7.Visible = true;
                    win = true;
                    int a2;
                    a2 = Convert.ToInt32(label6.Text);
                    a2 = a2 + 1;
                    label6.Text = a2.ToString();
                }
            }

            if (pictureBox12.Visible == true && pictureBox14.Visible == true && pictureBox16.Visible == true)
            {
                if (win == false)
                {
                    label7.Visible = true;
                    win = true;
                    int a2;
                    a2 = Convert.ToInt32(label6.Text);
                    a2 = a2 + 1;
                    label6.Text = a2.ToString();
                }
            }

            //Za izenačenje

            if(win == false && righttop == true && rightmiddle == true && rightbottom == true && middletop == true && middle == true && middlebottome == true && lefttop == true && leftmiddle == true && leftbottom == true)
            {
                label8.Visible = true;
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox10.Visible = true;
                num = 2;
                righttop = true;
            }
            else
            {
                pictureBox1.Visible = true;
                num = 1;
                righttop = true;
            }
            PreveriZmago();
        }
        private void pictureBox20_Click_1(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox11.Visible = true;
                num = 2;
                rightmiddle = true;
            }
            else
            {
                pictureBox2.Visible = true;
                num = 1;
                rightmiddle = true;
            }
            PreveriZmago();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox12.Visible = true;
                num = 2;
                rightbottom = true;
            }
            else
            {
                pictureBox3.Visible = true;
                num = 1;
                rightbottom = true;
            }
            PreveriZmago();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox13.Visible = true;
                num = 2;
                middletop = true;
            }
            else
            {
                pictureBox4.Visible = true;
                num = 1;
                middletop = true;
            }
            PreveriZmago();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox14.Visible = true;
                num = 2;
                middle = true;
            }
            else
            {
                pictureBox5.Visible = true;
                num = 1;
                middle = true;
            }
            PreveriZmago();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox15.Visible = true;
                num = 2;
                middlebottome = true;
            }
            else
            {
                pictureBox6.Visible = true;
                num = 1;
                middlebottome = true;  
            }
            PreveriZmago();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox16.Visible = true;
                num = 2;
                lefttop = true;
            }
            else
            {
                pictureBox7.Visible = true;
                num = 1;
                lefttop = true;
            }
            PreveriZmago();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox17.Visible = true;
                num = 2;
                leftmiddle = true;
            }
            else
            {
                pictureBox8.Visible = true;
                num = 1;
                leftmiddle = true;
            }
            PreveriZmago();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox18.Visible = true;
                num = 2;
                leftbottom = true;
            }
            else
            {
                pictureBox9.Visible = true;
                num = 1;
                leftbottom = true;
            }
            PreveriZmago();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            num = 1;
            win = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            righttop = false;
            rightmiddle = false;
            rightbottom = false;
            middletop = false;
            middle = false;
            middlebottome = false;
            lefttop = false;
            leftmiddle = false;
            leftbottom = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(username2);
            form4.Show();
            this.Hide();
        }
    }
}
