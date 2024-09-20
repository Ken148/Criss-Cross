using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace criss_cross
{
    public partial class Form7 : Form
    {
        string username2;
        public Form7(string username)
        {
            InitializeComponent();
            username2 = username;
        }
        Random random = new Random();
        int stev = 0;
        bool pon = false;
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
        public void PravilniOdgovor()
        {
            if(stev == 1)
            {
                if(pictureBox10.Visible == true || pictureBox12.Visible == true || pictureBox16.Visible == true || pictureBox18.Visible == true)
                {
                    pictureBox5.Visible = true;
                    middle = true;
                    stev = stev + 1;
                }else if(pictureBox11.Visible == true || pictureBox13.Visible == true || pictureBox15.Visible == true || pictureBox17.Visible == true)
                {
                    pictureBox5.Visible = true;
                    middle = true;
                    stev = stev + 1;
                }
                if (pictureBox14.Visible == true)
                {
                    PictureBox[] pictureBoxi2 = { pictureBox1, pictureBox3, pictureBox7, pictureBox9 };

                    Random random = new Random();
                    int index2 = random.Next(pictureBoxi2.Length);
                    PictureBox izbraniPictureBox = pictureBoxi2[index2];

                    izbraniPictureBox.Visible = true;
                }
            }
            if (stev == 2 && pon == false)
            {
                if (pictureBox14.Visible == true)
                {
                    // desno zgoraj
                    if (pictureBox10.Visible == true)
                    {
                        pictureBox7.Visible = true;
                        leftmiddle = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    // sredina zgoraj
                    else if (pictureBox11.Visible == true)
                    {
                        pictureBox8.Visible = true;
                        middle = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    // leva zgoraj
                    else if (pictureBox12.Visible == true)
                    {
                        pictureBox9.Visible = true;
                        rightmiddle = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    // sredina desna
                    else if (pictureBox15.Visible == true)
                    {
                        pictureBox4.Visible = true;
                        leftbottom = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    // sredina leva
                    else if (pictureBox13.Visible == true)
                    {
                        pictureBox6.Visible = true;
                        middlebottome = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    // spodaj desno
                    else if (pictureBox16.Visible == true)
                    {
                        pictureBox1.Visible = true;
                        lefttop = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    // sredina spodaj
                    else if (pictureBox17.Visible == true)
                    {
                        pictureBox2.Visible = true;
                        middletop = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    // spodaj levo
                    else if (pictureBox18.Visible == true)
                    {
                        pictureBox3.Visible = true;
                        righttop = true;
                        pon = true;
                        stev = stev + 1;
                    }
                }
                if (pictureBox10.Visible == true || pictureBox12.Visible == true || pictureBox16.Visible == true || pictureBox18.Visible == true)
                {
                    if(pictureBox10.Visible == true && pictureBox16.Visible == true)
                    {
                        pictureBox4.Visible = true;
                        middletop = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    if(pictureBox16.Visible == true && pictureBox18.Visible == true)
                    {
                        pictureBox8.Visible = true;
                        leftmiddle = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    if(pictureBox10.Visible == true && pictureBox12.Visible == true)
                    {
                        pictureBox2.Visible = true;
                        rightmiddle = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    if(pictureBox12.Visible == true && pictureBox18.Visible == true)
                    {
                        pictureBox6.Visible = true;
                        middlebottome = true;
                        pon = true;
                        stev = stev + 1;
                    }
                    if(pictureBox12.Visible == true && pictureBox16.Visible == true)
                    {
                        PictureBox[] pictureBoxi3 = { pictureBox1, pictureBox9 };

                        Random random = new Random();
                        int index3 = random.Next(pictureBoxi3.Length);
                        PictureBox izbraniPictureBox2 = pictureBoxi3[index3];

                        izbraniPictureBox2.Visible = true;
                        stev = stev + 1;
                    }
                    if(pictureBox10.Visible == true && pictureBox18.Visible == true)
                    {
                        PictureBox[] pictureBoxi4 = { pictureBox3, pictureBox7 };

                        Random random = new Random();
                        int index4 = random.Next(pictureBoxi4.Length);
                        PictureBox izbraniPictureBox3 = pictureBoxi4[index4];

                        izbraniPictureBox3.Visible = true;
                        stev = stev + 1;
                    }
                }

            }
            if (stev == 3)
            {
                PictureBox[] pictureBoxi5 = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };

                Random random = new Random();
                int index5 = random.Next(pictureBoxi5.Length);
                PictureBox izbraniPictureBox5 = pictureBoxi5[index5];

                izbraniPictureBox5.Visible = true;
                stev = stev + 1;
            }
            if (stev == 4)
            {
                PictureBox[] pictureBoxi5 = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };

                Random random = new Random();
                int index5 = random.Next(pictureBoxi5.Length);
                PictureBox izbraniPictureBox5 = pictureBoxi5[index5];

                izbraniPictureBox5.Visible = true;
                stev = stev + 1;
            }
        }
        public void PreveriZmago()
        {
            //vse za playerja 

            if (pictureBox1.Visible == true && pictureBox2.Visible == true && pictureBox3.Visible == true)
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

            //vse za računalnik

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

            if (win == false && righttop == true && rightmiddle == true && rightbottom == true && middletop == true && middle == true && middlebottome == true && lefttop == true && leftmiddle == true && leftbottom == true)
            {
                label8.Visible = true;
            }
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=database.db"))
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "SELECT player, computer FROM users WHERE id == 1"; //sql stavek

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) //sql stavek izvršitev
                    {
                        if(reader.Read())
                        {
                            label6.Text = Convert.ToString(player);
                            label4.Text = Convert.ToString(computer);
                        }
                    }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            label3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
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
            stev = 0;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            righttop = true;
            stev = stev + 1;

            PreveriZmago();
            PravilniOdgovor();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = true;
            rightmiddle = true;
            stev = stev + 1;

            PreveriZmago();
            PravilniOdgovor();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
            rightbottom = true;
            stev = stev + 1;

            PreveriZmago();
            PravilniOdgovor();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible = true;
            middletop = true;
            stev = stev + 1;

            PreveriZmago();
            PravilniOdgovor();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true;
            middle = true;
            stev = stev + 1;

            PreveriZmago();
            PravilniOdgovor();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = true;
            middlebottome = true;
            stev = stev + 1;

            PreveriZmago();
            PravilniOdgovor();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = true;
            lefttop = true;
            stev = stev + 1;

            PreveriZmago();
            PravilniOdgovor();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = true;
            leftmiddle = true;
            stev = stev + 1;

            PreveriZmago();
            PravilniOdgovor();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox18.Visible = true;
            leftbottom = true;
            stev = stev + 1;

            PreveriZmago();
            PravilniOdgovor();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=database.db"))
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        player = Convert.ToInt32(label6.Text);
                        computer = Convert.ToInt32(label4.Text);

                        cmd.CommandText = "UPDATE users SET player = @player, computer = @computer";

                        cmd.Parameters.AddWithValue("@player", player);
                        cmd.Parameters.AddWithValue("@computer", computer);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Application.Exit();
        }

        int player = 0;
        int computer = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=database.db"))
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        player = Convert.ToInt32(label6.Text);
                        computer = Convert.ToInt32(label4.Text);

                        cmd.CommandText = "UPDATE users SET player = @player, computer = @computer";


                        cmd.Parameters.AddWithValue("@player", player);
                        cmd.Parameters.AddWithValue("@computer", computer);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Form4 form4 = new Form4(username2);
            form4.Show();
            this.Hide();
        }
    }
}
