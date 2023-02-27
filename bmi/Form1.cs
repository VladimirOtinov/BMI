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

            //делаем видимой только инструкцию
            ind.Visible = false;
            stepen.Visible = false;
            trackBar1.Visible = false;

            //делаем видимой только инструкцию
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

            //делаем вид того, что идет разный расчета веса для мужчин и для женщин 
            if (fem.BackColor == Color.LightGray)
                index = (v+3) / (r * r);
            else
                index = v / (r * r);


            x.Text = index.ToString("N");
            trackBar1.Value = (int)index;

            if ((fem.BackColor == Color.White) & (pictureBox1.BackColor == Color.LightGray))
            {

                //рассчитываем к какой категории по весу относится человек с данным показателем ИМТ
                if (index <= 16)
                {
                    stepen.Text = "Выраженный дефицит массы тела";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\-2.png");
                }
                else if ((index > 16) & (index <= 18.5))
                {
                    stepen.Text = "Недостаточная масса тела";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\-1.png");
                }
                else if ((index > 18.5) & (index <= 25))
                {
                    stepen.Text = "Норма";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\норм.png");
                }
                else if ((index > 25) & (index <= 30))
                {
                    stepen.Text = "Избыточная масса тела";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\+1.png");
                }
                else if ((index > 30) & (index <= 35))
                {
                    stepen.Text = "Ожирение 1 степени";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\+2.png");
                }
                else if ((index > 35) & (index <= 40))
                {
                    stepen.Text = "Ожирение 2 степени";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\+3.png");
                }
                else if (index > 40)
                {
                    stepen.Text = "Ожирение 3 степени";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\+4.jpg");
                }
            }
            else 
            {
                if (index <= 16)
                {
                    stepen.Text = "Выраженный дефицит массы тела";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\f-1.png");
                }
                else if ((index > 16) & (index <= 18.5))
                {
                    stepen.Text = "Недостаточная масса тела";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\f.png");
                }
                else if ((index > 18.5) & (index <= 25))
                {
                    stepen.Text = "Норма";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\f1.png");
                }
                else if ((index > 25) & (index <= 30))
                {
                    stepen.Text = "Избыточная масса тела";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\f+1.png");
                }
                else if ((index > 30) & (index <= 35))
                {
                    stepen.Text = "Ожирение 1 степени";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\f+2.png");
                }
                else if ((index > 35) & (index <= 40))
                {
                    stepen.Text = "Ожирение 2 степени";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\f+3.png");
                }
                else if (index > 40)
                {
                    stepen.Text = "Ожирение 3 степени";
                    weight.Image = Image.FromFile("C:\\Users\\Vladimir\\Desktop\\bmi\\+4.jpg");
                }
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
