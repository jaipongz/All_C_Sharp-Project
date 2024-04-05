using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace benz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = double.Parse(textBox1.Text);
            double r = 0.44;
            double sum = b*r;
            
            textBox2.Text = sum + "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
