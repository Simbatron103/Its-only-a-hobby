using Its_only_a_hobby.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Its_only_a_hobby
{
    public partial class Form2 : Form
    {
        Image[] imagesFirst = { Resources.arrow };
        Image[] imagesSecond = { Resources.bolt };
        Image[] imagesThird = { Resources.diamond };
        Image[] imagesFourth = { Resources.heart };
        Image[] imagesFifth = { Resources.money };
        Image[] imagesSixth = { Resources.star };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.arrow;
            pictureBox2.Image = Resources.bolt;
            pictureBox3.Image = Resources.diamond;
            pictureBox4.Image = Resources.heart;
            pictureBox5.Image = Resources.money;
            pictureBox6.Image = Resources.star;
        }
    }
}
