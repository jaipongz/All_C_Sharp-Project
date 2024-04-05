using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pretest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string name, sex;
            long id, mobile;
            name = textBox1.Text;
            id = long.Parse(textBox2.Text);
            mobile = long.Parse(textBox3.Text);
            if (radioButton1.Checked == true)
            {
                sex = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                sex = radioButton2.Text;
            }
            else
            {
                sex = radioButton3.Text;
            }

            string[] n = new string[10];
            string[] s = new string[10];
            long[] d = new long[10];
            long[] m = new long[10];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = name;
                s[i] = sex;
                d[i] = id;
                m[i] = mobile;
                richTextBox1.Text = ("Name :" + n[i] + "\nID :" + d[i] + "\nGender :" + s[i] + "\nMobile :" + m[i]);

            }


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            





        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Random r = new Random();
            // int number = Random.next

            //label4.ForeColor = Color.Red;
            int c;
            Random r = new Random();
            c = r.Next(0, 5);
            if (c==0)
            {
                label4.ForeColor = Color.Green;
            }
            else if (c == 1)
            {
                label4.ForeColor = Color.Red;
            }
            else if (c == 2)
            {
                label4.ForeColor = Color.Blue;
            }
            else if (c == 3)
            {
                label4.ForeColor = Color.Yellow;
            }
            else if (c == 4)
            {
                label4.ForeColor = Color.Pink;
            }
            else
            {
                label4.ForeColor = Color.Purple;
            }
            //richTextBox1.Text = (Array.);
        }
    }
}
