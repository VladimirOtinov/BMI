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
        }

        private void вес_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = float.Parse(рост.Text);
            v = float.Parse(вес.Text);
            r = r / 100;
            index = v / (r * r);
            x.Text = index.ToString("N");
            trackBar1.Value = (int)index;
        }

        private void x_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }


    }
}
