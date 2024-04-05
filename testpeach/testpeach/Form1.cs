using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testpeach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                int buy = int.Parse(textBox1.Text);
                int i = int.Parse(textBox2.Text);


                int l = 0;

                int reward = i * 400;
                Random r = new Random();
                if (buy <= 99)
                    
                {
                    for (int n = 1; n <= 10; n++)
                    {

                        int lot;
                        
                        lot = r.Next(0, 100);
                        if (buy == lot)
                        {
                            l++;
                            if (lot <= 9)
                            {
                                richTextBox1.AppendText("เลขท้าย2ตัวครั้งที่ " + l + " เลขที่ออก 0" + lot +
                                                            " คุณถูกรางวัล \nจำนวน " + i + " ใบ ได้เงินรางวัลจำนวน " + reward + " บาท\n");
                            }
                            else
                            {
                                richTextBox1.AppendText("เลขท้าย2ตัวครั้งที่ " + l + " เลขที่ออก " + lot +
                                " คุณถูกรางวัล \nจำนวน " + i + " ใบ ได้เงินรางวัลจำนวน " + reward + " บาท\n");
                            }

                        }

                        else
                        {
                            l++;
                            if (lot <= 9)
                            {
                                richTextBox1.AppendText("เลขท้าย2ตัวครั้งที่ " + l + " เลขที่ออก 0" + lot +
                                " คุณไม่ถูกรางวัล\n");
                            }
                            else
                            {
                                richTextBox1.AppendText("เลขท้าย2ตัวครั้งที่ " + l + " เลขที่ออก " + lot +
                                " คุณไม่ถูกรางวัล\n");
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("ซื้อได้เพียงเลขท้ายสองตัว");
                }
            }
            catch
            {
                MessageBox.Show("กรุณาใส่ตัวเลขเท่านั้น");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
