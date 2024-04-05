using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testchatwimol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int s;
            int l = 0;
             Random r = new Random();
            
            for (int i = 0; i <= 13; i++)
            {
               
                
                s = r.Next(1, 100);
                
                if (s % 2 == 0)
                {
                    richTextBox1.AppendText(s + "  \n");
                }
                else
                {
                    if ((s % 2 == 0 || s % 3 == 0 || s % 5 == 0 || s % 7 == 0) &&
                    (s != 2 && s != 3 && s != 5 && s != 7))
                    {
                        continue;

                    }

                    richTextBox1.AppendText(s + "  จำนวนเฉพาะ\n");
                    l++;
                }

                
            }
            
            MessageBox.Show("พบจำนวนเฉพาะ " + l + " จำนวน ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
