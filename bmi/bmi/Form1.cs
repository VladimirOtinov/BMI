using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi
{
    public partial class Form1 : Form
    {
        float index;
        float r;
        float v;

        public Form1()
        {
            InitializeComponent();

            ind.Visible = false;
            stepen.Visible = false;
            trackBar1.Visible = false;

            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            la.Visible = false;
            lb.Visible = false;
            lc.Visible = false;
            ld.Visible = false;
            l11.Visible = false;
            l22.Visible = false;
            l33.Visible = false;
            l44.Visible = false;

        }

        private void вес_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = float.Parse(рост.Text);
            v = float.Parse(вес.Text);
            r = r / 100;

            if (fem.BackColor == Color.LightGray)
                index = (v+3) / (r * r);
            else
                index = v / (r * r);


            x.Text = index.ToString("N");
            trackBar1.Value = (int)index;

            if (trackBar1.Value <= 16)
            {
                stepen.Text = "Выраженный дефицит массы тела";
                weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\-2.png");
            }
            else if ((trackBar1.Value > 16) & (trackBar1.Value <= 18.5))
            {
                stepen.Text = "Недостаточная масса тела";
                weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\-1.png");
            }
                
            else if ((trackBar1.Value > 18.5) & (trackBar1.Value <= 25))
            {
                stepen.Text = "Норма";
                weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\норм.png");
            }
            else if ((trackBar1.Value > 25) & (trackBar1.Value <= 30))
            {
                stepen.Text = "Избыточная масса тела";
                weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\+1.png");
            }
            else if ((trackBar1.Value > 30) & (trackBar1.Value <= 35))
            {
                stepen.Text = "Ожирение 1 степени";
                weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\+2.png");
            }
            else if ((trackBar1.Value > 35) & (trackBar1.Value <= 40))
            {
                stepen.Text = "Ожирение 2 степени";
                weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\+3.png");
            }
            else if (trackBar1.Value > 40)
            {
                stepen.Text = "Ожирение 3 степени";
                weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\+4.jpg");
            }

            instr1.Visible = false;
            instr2.Visible = false;

            ind.Visible= true;
            stepen.Visible= true;
            

            l1.Visible = true;
            l2.Visible = true;
            l3.Visible = true;
            l4.Visible = true;
            la.Visible = true;
            lb.Visible = true;
            lc.Visible = true;
            ld.Visible = true;
            l11.Visible = true;
            l22.Visible = true;
            l33.Visible = true;
            l44.Visible = true;
            trackBar1.Visible = true;
        }

        private void x_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void stepen_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// кнопка мужчины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightGray;
            fem.BackColor = Color.White;
        }

        private void fem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            fem.BackColor = Color.LightGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
