using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hrcv = int.Parse(hrin1.Text);
            int mincv = int.Parse(minin.Text);
            int seccv = int.Parse(secin.Text);
            int hr = 0;
            int min = 0;
            int second = 0;
            float sum1 = 0;
            float sum2 = 0;
            float sum3 = 0;

            hr = hrcv / 3600;
            min = (hrcv % 3600) / 60;
            second = hrcv % 60;
            
            minout1.Text = hr + "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void minout1_TextChanged(object sender, EventArgs e)
        {
            minout1
        }
    }
}
