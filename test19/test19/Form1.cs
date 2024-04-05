using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test19
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        string cn = "Data Source =.;Initial Catalog=Balance;UserID=sa;Password=123";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int t = int.Parse(label8.Text);
            int[] r = new int[5];
            int p;
            r[0] = 100;
            r[1] = 500;
            r[2] = 1000;
            r[3] = 2000;
            r[4] = 5000;
            Random x = new Random();
            p = x.Next(0, 5);
            int money = int.Parse(textBox1.Text);


            int l = int.Parse(label7.Text);
            l++;
            
            textBox2.Text = (r[p] + "");
            int s = money - r[p];




            if (s <= 0)
            {
                MessageBox.Show("ไม่สามราถทำรายการได้\nยอดเงินของคุณไม่เพียงพอ");
                textBox1.Text = ("ใส่จำนวนเงิน");
                label4.Text = ("-");
            }
            else if (l == 10)
            {
                label4.Text = (s - 100 + "");
                textBox1.Text = (s - 100 + "");
                label8.Text = t + r[p] + "";
                listBox1.Items.Add("ถอนครั้งที่ : " + l + " จำนวน" + (r[p] + 100));
                label7.Text = l + "";
                MessageBox.Show("คุณทำรายการครบ10ครั้ง\nหักค่าธรรเนียม 100 บาท" + "\nสรุปยอดถอน10รอบ :" + t + " บาท");
                label8.Text = "0";
            }
            else if (l == 20)
            {
                label4.Text = (s - 100 + "");
                textBox1.Text = (s - 100 + "");
                label8.Text = t + r[p] + "";
                listBox1.Items.Add("ถอนครั้งที่ : " + l + " จำนวน" + (r[p] + 100));
                label7.Text = l + "";
                MessageBox.Show("คุณทำรายการครบ10ครั้ง\nหักค่าธรรเนียม 100 บาท" + "\nสรุปยอดถอน10รอบ :" + t + " บาท");
                label8.Text = "0";
            }
            else if (l == 30)
            {
                label4.Text = (s - 100 + "");
                textBox1.Text = (s - 100 + "");
                label8.Text = t + r[p] + "";
                listBox1.Items.Add("ถอนครั้งที่ : " + l + " จำนวน" + (r[p] + 100));
                label7.Text = l + "";
                MessageBox.Show("คุณทำรายการครบ10ครั้ง\nหักค่าธรรเนียม 100 บาท" + "\nสรุปยอดถอน10รอบ :"+t+" บาท");
                label8.Text = "0";
            }
            else
            {

                label4.Text = (s + "");
                textBox1.Text = (s + "");
                label8.Text = t + r[p] + "";
                listBox1.Items.Add("ถอนครั้งที่ : " + l + " จำนวน" + r[p]);
                label7.Text = l + "";
            }
            
            




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //int[] o = new int[1];
           // o[0] = (textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Hide();
        }
    }
}
