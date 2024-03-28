using Its_only_a_hobby.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Its_only_a_hobby
{
    public partial class Form1 : Form
    {
        Image[] imagesFirst = { Resources.arrow };
        Image[] imagesSecond = { Resources.bolt };
        Image[] imagesThird = { Resources.diamond };
        Image[] imagesFourth = { Resources.heart };
        Image[] imagesFifth = { Resources.money };
        Image[] imagesSixth = { Resources.star };
        int First = 1;
        int Second = 2;
        int Third = 3;
        int Fourth = 4;
        int Fifth = 5;
        int Sixth = 6;
        int nummer;
        int Nubmer;
        int Number;
        int Money = 1000;
        Random Random = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {



            Money--;
            label1.Text = Money.ToString();

            if (checkBox1.Checked == false)
            {
                nummer = Random.Next(1, 6);

            }

            if (nummer == First)
            {
                pictureBox1.Image = Resources.arrow;
            }
            else if (nummer == Second)
            {
                pictureBox1.Image = Resources.bolt;
            }
            else if (nummer == Third)
            {
                pictureBox1.Image = Resources.diamond;
            }
            else if (nummer == Fourth)
            {
                pictureBox1.Image = Resources.heart;
            }
            else if (nummer == Fifth)
            {
                pictureBox1.Image = Resources.money;
            }
            else if (nummer == Sixth)
            {
                pictureBox1.Image = Resources.star;
            }







            if (checkBox2.Checked == false)
            {
                Nubmer = Random.Next(1, 6);
            }
            if (Nubmer == First)
            {
                pictureBox2.Image = Resources.arrow;
            }
            else if (Nubmer == Second)
            {
                pictureBox2.Image = Resources.bolt;
            }
            else if (Nubmer == Third)
            {
                pictureBox2.Image = Resources.diamond;
            }
            else if (Nubmer == Fourth)
            {
                pictureBox2.Image = Resources.heart;
            }
            else if (Nubmer == Fifth)
            {
                pictureBox2.Image = Resources.money;
            }
            else if (Nubmer == Sixth)
            {
                pictureBox2.Image = Resources.star;
            }







            if (checkBox3.Checked == false)
            {
                Number = Random.Next(1, 6);
            }

            if (Number == First)
            {
                pictureBox3.Image = Resources.arrow;
            }
            else if (Number == Second)
            {
                pictureBox3.Image = Resources.bolt;
            }
            else if (Number == Third)
            {
                pictureBox3.Image = Resources.diamond;
            }
            else if (Number == Fourth)
            {
                pictureBox3.Image = Resources.heart;
            }
            else if (Number == Fifth)
            {
                pictureBox3.Image = Resources.money;
            }
            else if (Number == Sixth)
            {
                pictureBox3.Image = Resources.star;
            }
            if (nummer == Number && Number == Nubmer)
            {
                nummer = Random.Next(1, 6);
                Nubmer = Random.Next(1, 6);
                Number = Random.Next(1, 6);
                MessageBox.Show("winner Omg");
                Money = Money + 10;
                label1.Text = Money.ToString();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                if (checkBox1.Checked == false)
                {
                    nummer = Random.Next(1, 6);

                }

                if (nummer == First)
                {
                    pictureBox1.Image = Resources.arrow;
                }
                else if (nummer == Second)
                {
                    pictureBox1.Image = Resources.bolt;
                }
                else if (nummer == Third)
                {
                    pictureBox1.Image = Resources.diamond;
                }
                else if (nummer == Fourth)
                {
                    pictureBox1.Image = Resources.heart;
                }
                else if (nummer == Fifth)
                {
                    pictureBox1.Image = Resources.money;
                }
                else if (nummer == Sixth)
                {
                    pictureBox1.Image = Resources.star;
                }







                if (checkBox2.Checked == false)
                {
                    Nubmer = Random.Next(1, 6);
                }
                if (Nubmer == First)
                {
                    pictureBox2.Image = Resources.arrow;
                }
                else if (Nubmer == Second)
                {
                    pictureBox2.Image = Resources.bolt;
                }
                else if (Nubmer == Third)
                {
                    pictureBox2.Image = Resources.diamond;
                }
                else if (Nubmer == Fourth)
                {
                    pictureBox2.Image = Resources.heart;
                }
                else if (Nubmer == Fifth)
                {
                    pictureBox2.Image = Resources.money;
                }
                else if (Nubmer == Sixth)
                {
                    pictureBox2.Image = Resources.star;
                }







                if (checkBox3.Checked == false)
                {
                    Number = Random.Next(1, 6);
                }

                if (Number == First)
                {
                    pictureBox3.Image = Resources.arrow;
                }
                else if (Number == Second)
                {
                    pictureBox3.Image = Resources.bolt;
                }
                else if (Number == Third)
                {
                    pictureBox3.Image = Resources.diamond;
                }
                else if (Number == Fourth)
                {
                    pictureBox3.Image = Resources.heart;
                }
                else if (Number == Fifth)
                {
                    pictureBox3.Image = Resources.money;
                }
                else if (Number == Sixth)
                {
                    pictureBox3.Image = Resources.star;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Money.ToString();
            Random.Next(1, 6);
            Nubmer = Random.Next(1, 6);
            nummer = Random.Next(1, 6);
            Number = Random.Next(1, 6);

            if (checkBox1.Checked)
            {

            }
            else if (nummer == First)
            {
                pictureBox1.Image = Resources.arrow;
            }
            else if (nummer == Second)
            {
                pictureBox1.Image = Resources.bolt;
            }
            else if (nummer == Third)
            {
                pictureBox1.Image = Resources.diamond;
            }
            else if (nummer == Fourth)
            {
                pictureBox1.Image = Resources.heart;
            }
            else if (nummer == Fifth)
            {
                pictureBox1.Image = Resources.money;
            }
            else if (nummer == Sixth)
            {
                pictureBox1.Image = Resources.star;
            }


            if (checkBox2.Checked)
            {

            }
            else if (Nubmer == First)
            {
                pictureBox2.Image = Resources.arrow;
            }
            else if (Nubmer == Second)
            {
                pictureBox2.Image = Resources.bolt;
            }
            else if (Nubmer == Third)
            {
                pictureBox2.Image = Resources.diamond;
            }
            else if (Nubmer == Fourth)
            {
                pictureBox2.Image = Resources.heart;
            }
            else if (Nubmer == Fifth)
            {
                pictureBox2.Image = Resources.money;
            }
            else if (Nubmer == Sixth)
            {
                pictureBox2.Image = Resources.star;
            }





            if (checkBox3.Checked)
            {

            }
            else if (Number == First)
            {
                pictureBox3.Image = Resources.arrow;
            }
            else if (Number == Second)
            {
                pictureBox3.Image = Resources.bolt;
            }
            else if (Number == Third)
            {
                pictureBox3.Image = Resources.diamond;
            }
            else if (Number == Fourth)
            {
                pictureBox3.Image = Resources.heart;
            }
            else if (Number == Fifth)
            {
                pictureBox3.Image = Resources.money;
            }
            else if (Number == Sixth)
            {
                pictureBox3.Image = Resources.star;
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Money = Money - 2;
            label1.Text = Money.ToString();

            if (checkBox1.Checked == false)
            {
                nummer = Random.Next(1, 6);

            }

            if (nummer == First)
            {
                pictureBox1.Image = Resources.arrow;
            }
            else if (nummer == Second)
            {
                pictureBox1.Image = Resources.bolt;
            }
            else if (nummer == Third)
            {
                pictureBox1.Image = Resources.diamond;
            }
            else if (nummer == Fourth)
            {
                pictureBox1.Image = Resources.heart;
            }
            else if (nummer == Fifth)
            {
                pictureBox1.Image = Resources.money;
            }
            else if (nummer == Sixth)
            {
                pictureBox1.Image = Resources.star;
            }







            if (checkBox2.Checked == false)
            {
                Nubmer = Random.Next(1, 6);
            }
            if (Nubmer == First)
            {
                pictureBox2.Image = Resources.arrow;
            }
            else if (Nubmer == Second)
            {
                pictureBox2.Image = Resources.bolt;
            }
            else if (Nubmer == Third)
            {
                pictureBox2.Image = Resources.diamond;
            }
            else if (Nubmer == Fourth)
            {
                pictureBox2.Image = Resources.heart;
            }
            else if (Nubmer == Fifth)
            {
                pictureBox2.Image = Resources.money;
            }
            else if (Nubmer == Sixth)
            {
                pictureBox2.Image = Resources.star;
            }







            if (checkBox3.Checked == false)
            {
                Number = Random.Next(1, 6);
            }

            if (Number == First)
            {
                pictureBox3.Image = Resources.arrow;
            }
            else if (Number == Second)
            {
                pictureBox3.Image = Resources.bolt;
            }
            else if (Number == Third)
            {
                pictureBox3.Image = Resources.diamond;
            }
            else if (Number == Fourth)
            {
                pictureBox3.Image = Resources.heart;
            }
            else if (Number == Fifth)
            {
                pictureBox3.Image = Resources.money;
            }
            else if (Number == Sixth)
            {
                pictureBox3.Image = Resources.star;
            }
            if (nummer == Number && Number == Nubmer)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                nummer = Random.Next(1, 6);
                Nubmer = Random.Next(1, 6);
                Number = Random.Next(1, 6);
                MessageBox.Show("winner Omg");
                Money = Money + 20;
                label1.Text = Money.ToString();
                if (checkBox1.Checked == false)
                {
                    nummer = Random.Next(1, 6);

                }

                if (nummer == First)
                {
                    pictureBox1.Image = Resources.arrow;
                }
                else if (nummer == Second)
                {
                    pictureBox1.Image = Resources.bolt;
                }
                else if (nummer == Third)
                {
                    pictureBox1.Image = Resources.diamond;
                }
                else if (nummer == Fourth)
                {
                    pictureBox1.Image = Resources.heart;
                }
                else if (nummer == Fifth)
                {
                    pictureBox1.Image = Resources.money;
                }
                else if (nummer == Sixth)
                {
                    pictureBox1.Image = Resources.star;
                }







                if (checkBox2.Checked == false)
                {
                    Nubmer = Random.Next(1, 6);
                }
                if (Nubmer == First)
                {
                    pictureBox2.Image = Resources.arrow;
                }
                else if (Nubmer == Second)
                {
                    pictureBox2.Image = Resources.bolt;
                }
                else if (Nubmer == Third)
                {
                    pictureBox2.Image = Resources.diamond;
                }
                else if (Nubmer == Fourth)
                {
                    pictureBox2.Image = Resources.heart;
                }
                else if (Nubmer == Fifth)
                {
                    pictureBox2.Image = Resources.money;
                }
                else if (Nubmer == Sixth)
                {
                    pictureBox2.Image = Resources.star;
                }







                if (checkBox3.Checked == false)
                {
                    Number = Random.Next(1, 6);
                }

                if (Number == First)
                {
                    pictureBox3.Image = Resources.arrow;
                }
                else if (Number == Second)
                {
                    pictureBox3.Image = Resources.bolt;
                }
                else if (Number == Third)
                {
                    pictureBox3.Image = Resources.diamond;
                }
                else if (Number == Fourth)
                {
                    pictureBox3.Image = Resources.heart;
                }
                else if (Number == Fifth)
                {
                    pictureBox3.Image = Resources.money;
                }
                else if (Number == Sixth)
                {
                    pictureBox3.Image = Resources.star;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Money = Money - 500;
            label1.Text = Money.ToString();

            if (checkBox1.Checked == false)
            {
                nummer = Random.Next(1, 6);

            }

            if (nummer == First)
            {
                pictureBox1.Image = Resources.arrow;
            }
            else if (nummer == Second)
            {
                pictureBox1.Image = Resources.bolt;
            }
            else if (nummer == Third)
            {
                pictureBox1.Image = Resources.diamond;
            }
            else if (nummer == Fourth)
            {
                pictureBox1.Image = Resources.heart;
            }
            else if (nummer == Fifth)
            {
                pictureBox1.Image = Resources.money;
            }
            else if (nummer == Sixth)
            {
                pictureBox1.Image = Resources.star;
            }







            if (checkBox2.Checked == false)
            {
                Nubmer = Random.Next(1, 6);
            }
            if (Nubmer == First)
            {
                pictureBox2.Image = Resources.arrow;
            }
            else if (Nubmer == Second)
            {
                pictureBox2.Image = Resources.bolt;
            }
            else if (Nubmer == Third)
            {
                pictureBox2.Image = Resources.diamond;
            }
            else if (Nubmer == Fourth)
            {
                pictureBox2.Image = Resources.heart;
            }
            else if (Nubmer == Fifth)
            {
                pictureBox2.Image = Resources.money;
            }
            else if (Nubmer == Sixth)
            {
                pictureBox2.Image = Resources.star;
            }







            if (checkBox3.Checked == false)
            {
                Number = Random.Next(1, 6);
            }

            if (Number == First)
            {
                pictureBox3.Image = Resources.arrow;
            }
            else if (Number == Second)
            {
                pictureBox3.Image = Resources.bolt;
            }
            else if (Number == Third)
            {
                pictureBox3.Image = Resources.diamond;
            }
            else if (Number == Fourth)
            {
                pictureBox3.Image = Resources.heart;
            }
            else if (Number == Fifth)
            {
                pictureBox3.Image = Resources.money;
            }
            else if (Number == Sixth)
            {
                pictureBox3.Image = Resources.star;
            }
            if (nummer == Number && Number == Nubmer)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                nummer = Random.Next(1, 6);
                Nubmer = Random.Next(1, 6);
                Number = Random.Next(1, 6);
                MessageBox.Show("winner Omg");
                Money = Money * 6;
                label1.Text = Money.ToString();
                if (checkBox1.Checked == false)
                {
                    nummer = Random.Next(1, 6);

                }

                if (nummer == First)
                {
                    pictureBox1.Image = Resources.arrow;
                }
                else if (nummer == Second)
                {
                    pictureBox1.Image = Resources.bolt;
                }
                else if (nummer == Third)
                {
                    pictureBox1.Image = Resources.diamond;
                }
                else if (nummer == Fourth)
                {
                    pictureBox1.Image = Resources.heart;
                }
                else if (nummer == Fifth)
                {
                    pictureBox1.Image = Resources.money;
                }
                else if (nummer == Sixth)
                {
                    pictureBox1.Image = Resources.star;
                }







                if (checkBox2.Checked == false)
                {
                    Nubmer = Random.Next(1, 6);
                }
                if (Nubmer == First)
                {
                    pictureBox2.Image = Resources.arrow;
                }
                else if (Nubmer == Second)
                {
                    pictureBox2.Image = Resources.bolt;
                }
                else if (Nubmer == Third)
                {
                    pictureBox2.Image = Resources.diamond;
                }
                else if (Nubmer == Fourth)
                {
                    pictureBox2.Image = Resources.heart;
                }
                else if (Nubmer == Fifth)
                {
                    pictureBox2.Image = Resources.money;
                }
                else if (Nubmer == Sixth)
                {
                    pictureBox2.Image = Resources.star;
                }







                if (checkBox3.Checked == false)
                {
                    Number = Random.Next(1, 6);
                }

                if (Number == First)
                {
                    pictureBox3.Image = Resources.arrow;
                }
                else if (Number == Second)
                {
                    pictureBox3.Image = Resources.bolt;
                }
                else if (Number == Third)
                {
                    pictureBox3.Image = Resources.diamond;
                }
                else if (Number == Fourth)
                {
                    pictureBox3.Image = Resources.heart;
                }
                else if (Number == Fifth)
                {
                    pictureBox3.Image = Resources.money;
                }
                else if (Number == Sixth)
                {
                    pictureBox3.Image = Resources.star;
                }
                if (Money <= -1000)
                {
                    MessageBox.Show("broke mf");
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Money = 1000;
            label1.Text = Money.ToString();
        }
    }
}
