using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pretest
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
            string[] str = textBox1.Text.Split(',');
            int len = str.Length;
            int[] x = new int[len];
            //Array.Sort(name);
            for (int i = 0; i <len; i++)
            {
                x[i] = Convert.ToInt32(str[i]);
            }
            string str2 = "";
            for (int i = len - 1; i>=0; i--)
            {
                str2 = str2 + x[i].ToString() + ",";
            }
            richTextBox1.Text = str2;
        }
    }
}
