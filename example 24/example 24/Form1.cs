using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cost = int.Parse(textBox1.Text);
            int total = cost * 30;

            label3.Text = total + "";

            if (total > 30000)
            {
                label4.Text = "คุณใช้เงินเปลืองเกินไปแล้วนะคะ";
            }
            else if (total>=15000)
            {
                label4.Text = "คุณใช่เงินเปลืองมากนะคะ";
            }
            else if (total >=10000)
            {
                label4.Text = "คุณใช้เงินในระดับปกติ";
            }
            else if(total <10000)
            {
                label4.Text = "คุณประหยัดมาก น่าชื่นชม";
            }
        }
    }
}
