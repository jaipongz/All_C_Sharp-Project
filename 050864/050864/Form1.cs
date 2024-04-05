using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _050864
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = 5;
            int[] number = new int[size];
            Random r = new Random();
            r.Next(0, 100);
            textBox1.Text = r.Next(0, 100)+"";
            textBox2.Text = r.Next(0, 100)+"";
            textBox3.Text = r.Next(0, 100)+"";
            textBox4.Text = r.Next(0, 100)+"";
            textBox5.Text = r.Next(0, 100)+"";

            number[0] = int.Parse(textBox1.Text);
            number[1] = int.Parse(textBox2.Text);
            number[2] = int.Parse(textBox3.Text);
            number[3] = int.Parse(textBox4.Text);
            number[4] = int.Parse(textBox5.Text);
            int temp = 0;
            foreach (int n in number)
            {
                temp = temp + n;
            }
            double result = temp / size;
            textBox6.Text = "" + result;
        }
    }
}
