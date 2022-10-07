using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_and_Perimeter
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length, breadth;
            length = Double.Parse(textBox1.Text);
            breadth = Double.Parse(textBox2.Text);

            double per=2*(length+breadth);
            double a=length*breadth;

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
