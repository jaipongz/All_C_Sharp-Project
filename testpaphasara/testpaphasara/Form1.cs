using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testpaphasara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] t = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int l = 0;
            int c = 0;
            int ran;
            Random x = new Random();

            for(int i = 1; i<= 10; i++)
            {

                ran = x.Next(0, 27);
                l++;
                if (ran == 2)
                {
                    textBox1.Text = "C";
                    textBox16.Text = l + "";
                    
                }
                else if (ran == 14)
                {
                    textBox2.Text = "O";
                    textBox15.Text = l + "";
                   
                }
                else if (ran == 12)
                {
                    textBox3.Text = "M";
                    textBox14.Text = l + "";
                    
                }
                else if (ran == 15)
                {
                    textBox4.Text = "P";
                    textBox13.Text = l + "";
                    
                }
                else if (ran == 20)
                {
                    textBox5.Text = "U";
                    textBox12.Text = l + "";
                    
                }
                else if (ran == 19)
                {
                    textBox6.Text = "T";
                    textBox11.Text = l + "";
                   
                }
                else if (ran == 4)
                {
                    textBox7.Text = "E";
                    textBox10.Text = l + "";
                    
                }
                else if (ran == 17)
                {
                    textBox8.Text = "R";
                    textBox9.Text = l + "";
                    
                }
                else
                {
                    continue;
                }
            }
            
         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
