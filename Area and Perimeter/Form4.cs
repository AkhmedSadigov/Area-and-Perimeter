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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side;
            side = Double.Parse(textBox1.Text);

            double per = 6 * side;
            double a = ((3 * Math.Sqrt(3) *(side * side)) / 2);

            textBox4.Text=a.ToString(); 
            textBox5.Text=per.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }
    }
}
