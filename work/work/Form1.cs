using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "+";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void butcal(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(firstbox.Text);
            b = double.Parse(secondbox.Text);
            resultlab.Text = calculate();
        }
        public string calculate(double x,double y)
        {
            double z = 0;
                if (comboBox1.Text =="+")
                {
                z = x + y;
                }
                else if (comboBox1.Text == "-") 
                {
                z = x - y; 
                }
                else if (comboBox1.Text == "*")
                {
                z = x * y;
                }
                else if (comboBox1.Text == "/")
                {
                z = x / y;
                }
                else if (comboBox1.Text == "root")
                {
                z = Math.Pow(x, (1 / y));
                }
                else if (comboBox1.Text == "pow")
                {
                z = Math.Pow(x, y);
                }
            return z.ToString();
        }
    }
}
