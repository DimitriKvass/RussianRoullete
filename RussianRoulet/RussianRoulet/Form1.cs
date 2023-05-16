using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace RussianRoulet
{
    public partial class Form1 : Form
    {

        int b1 = 0;
        int b2 = 0;
        int b3 = 0;
        int b4 = 0;
        int b5 = 0;
        int naredu;
        int brigr;
        bool p1s = true;
        bool p2s = true;
        bool p3s = true;
        bool p4s = true;
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int rand;
        bool shoot = false;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("1 Bullet");
            comboBox1.Items.Add("2 Bullet");
            comboBox1.Items.Add("3 Bullet");
            comboBox1.Items.Add("4 Bullet");
            comboBox1.Items.Add("5 Bullet");

            comboBox2.Items.Add("1 Player");
            comboBox2.Items.Add("2 Player");
            comboBox2.Items.Add("3 Player");
            comboBox2.Items.Add("4 Player");

            button2.Enabled = false;
            button3.Enabled = false;

            label3.Text = "";
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";

            pictureBox2.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox2.Hide();
            label3.Text = "";
            var random = new Random();
            shoot = false;
            label2.Text = "";
            b1 = 0;
            b2 = 0;
            b3 = 0;
            b4 = 0;
            b5 = 0;
            button2.Enabled = true;
            button3.Enabled = true;
            if(comboBox1.SelectedIndex == 0)
            {
                b1 = 1;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                b1 = 1;
                b2 = 2;
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                b1 = 1;
                b2 = 2;
                b3 = 3;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                b1 = 1;
                b2 = 2;
                b3 = 3;
                b4 = 4;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                b1 = 1;
                b2 = 2;
                b3 = 3;
                b4 = 4;
                b5 = 5;
            }

            if (comboBox2.SelectedIndex == 0)
            {
                p1 = 1;

                listBox1.Items.Add(p1);
                brigr = 1;

                label6.Show();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Text = "Alive";
                label11.Text = "";
                label12.Text = "";
                label13.Text = "";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                p1 = 1;
                p2 = 2;

                listBox1.Items.Add(p1);
                listBox1.Items.Add(p2);

                brigr = 2;

                label6.Show();
                label7.Show();
                label8.Hide();
                label9.Hide();
                label10.Text = "Alive";
                label11.Text = "Alive";
                label12.Text = "";
                label13.Text = "";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                p1 = 1;
                p2 = 2;
                p3 = 3;

                listBox1.Items.Add(p1);
                listBox1.Items.Add(p2);
                listBox1.Items.Add(p3);

                brigr = 3;

                label6.Show();
                label7.Show();
                label8.Show();
                label9.Hide();
                label10.Text = "Alive";
                label11.Text = "Alive";
                label12.Text = "Alive";
                label13.Text = "";
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                p1 = 1;
                p2 = 2;
                p3 = 3;
                p4 = 4;

                listBox1.Items.Add(p1);
                listBox1.Items.Add(p2);
                listBox1.Items.Add(p3);
                listBox1.Items.Add(p4);

                brigr = 4;

                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Text = "Alive";
                label11.Text = "Alive";
                label12.Text = "Alive";
                label13.Text = "Alive";
            }

            naredu = 1;
            listBox1.SelectedIndex = 0;

            rand = random.Next(1, 6);
            label2.Text = rand.ToString();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = rand.ToString();
            pictureBox2.Hide();

            if (rand == b1 || rand == b2 || rand == b3 || rand == b4 || rand == b5)
                {
                    SoundPlayer ssplayer = new SoundPlayer(@"C:\Users\Dorian\source\repos\RussianRoulet\3.wav");
                    ssplayer.Play();
                    if(listBox1.SelectedItem.ToString() == "1")
                    {
                        label10.Text = "Dead";
                    }
                    else if(listBox1.SelectedItem.ToString() == "2")
                    {
                        label11.Text = "Dead";
                    }
                    else if(listBox1.SelectedItem.ToString() == "3")
                    {
                        label12.Text = "Dead";
                    }
                    else if (listBox1.SelectedItem.ToString() == "4")
                    {
                        label13.Text = "Dead";
                    }
                    listBox1.Items.RemoveAt(naredu - 1);
                    brigr--;
                    naredu--;
                    pictureBox2.Show();
                }
                else
                {

                    shoot = true;
                    SoundPlayer splayer = new SoundPlayer(@"C:\Users\Dorian\source\repos\RussianRoulet\1.wav");
                    splayer.Play();
                }

                if (rand == 6)
                {
                    rand = 1;
                }
                else
                {
                    rand = rand + 1;
                }

            if (listBox1.Items.Count == 0)
            {
                label3.Text = "GAME OVER";
                button2.Enabled = false;
                button3.Enabled = false;
                shoot = false;
            }
            else
            {

                if (naredu == brigr)
                {
                    naredu = 1;
                    listBox1.SelectedIndex = naredu - 1;
                }
                else
                {
                    naredu++;
                    listBox1.SelectedIndex = naredu - 1;
                }

                button2.Enabled = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var random = new Random();
            label2.Text = rand.ToString();
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Dorian\source\repos\RussianRoulet\2.wav");
            rand = random.Next(1, 6);
            splayer.Play();

            button2.Enabled = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
