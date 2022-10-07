using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_and_Perimeter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side1, side2, side3;
            side1 = Double.Parse(textBox1.Text);
            side2 = Double.Parse(textBox2.Text);
            side3 = Double.Parse(textBox3.Text);

            double p = (side1 + side2 + side3) / 2;
            double a = Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
            double per=side1+side2+ side3;

            textBox4.Text = a.ToString();
            textBox5.Text = per.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }
    }
}
