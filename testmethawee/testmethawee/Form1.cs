using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testmethawee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int p;
            int colin = int.Parse(textBox6.Text); //จำนวนแถว
            int rowin = int.Parse(textBox7.Text); //จำนวนหลัก
            char[] t = new char[5]; //อะเรย์เก็บค่าอักษร
            t[0] = char.Parse(textBox1.Text);
            t[1] = char.Parse(textBox2.Text);
            t[2] = char.Parse(textBox3.Text);
            t[3] = char.Parse(textBox4.Text);
            t[4] = char.Parse(textBox5.Text);

            Random r = new Random();
            p = r.Next(0,5);

            if (colin == rowin && (colin % 2) != 0 && (rowin % 2) != 0) //คำสั่งให้ลูปทำเมื่อแถวและหลักไม่ใช่เลขคี่
            {
                for(int l = 1; l <= colin && l <= rowin; l++) //จำนวนลูป
                {
                    for (int row = 1; row <= 5; row++) //ลูปให้วาดอักษรแนวตั้ง
                    {
                        

                        for (int col = 1; col <= 5; col++) //ลูปวาดตัวอักษรแนวนอน
                        {
                            if (col == 1 || col == 5)
                            {
                                richTextBox1.AppendText(t[p] + " ");
                            }
                            else if (row == 1 || row == 5)
                            {
                                richTextBox1.AppendText(t[p] + " ");
                            }

                            else
                            {
                                richTextBox1.AppendText("   ");
                            }
                            
                        }
                        richTextBox1.AppendText("\n");
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("ไม่ตรงตามเงื่อนไข");
            }
            
        }
    }
}
