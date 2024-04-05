using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = 0;
            int c =  int.Parse(textBox1.Text);
            int sum = 0;
            if (comboBox2.Text == "กระเพราหมูสับ")
            {
                b = 50;
            }
            else if (comboBox2.Text == "กระเพราหมูกรอบ")
            {
                b = 50;
            }
            else if (comboBox2.Text == "กระเพรากุ้ง")
            {
                b = 60;
            }
            else if (comboBox2.Text == "กระเพราหมึก")
            {
                b = 60;
            }
            else if (comboBox2.Text == "กระเพราไก่")
            {
                b = 50;
            }
            else if (comboBox2.Text == "กระเพรารวม")
            {
                b = 60;
            }
            else if (comboBox2.Text == "ข้าวผัดกุ้ง")
            {
                b = 60;
            }
            else if (comboBox2.Text == "ก๋วยเตี๋ยวเนื้อน้ำตก")
            {
                b = 45;
            }
            else if (comboBox2.Text == "ก๋วยเตี๋ยวหมูน้ำตก")
            {
                b = 45;
            }
            else if (comboBox2.Text == "ก๋วยเตี๋ยวเนื้อน้ำใส")
            {
                b = 45;
            }
            else if (comboBox2.Text == "ก๋วยเตี๋ยวหมูน้ำใส")
            {
                b = 45;
            }
            else if (comboBox2.Text == "ก๋วยจั๊บ")
            {
                b = 45;
            }
            else if (comboBox2.Text == "ต้มเส้น")
            {
                b = 45;
            }
            else if (comboBox2.Text == "เกาเหลา")
            {
                b = 50;
            }
            else if (comboBox2.Text == "น้ำเปล่า")
            {
                b = 10;
            }
            else if (comboBox2.Text == "โค้ก")
            {
                b = 15;
            }
            else if (comboBox2.Text == "เป็ปซี่")
            {
                b = 15;
            }
            else if (comboBox2.Text == "ชาเย็น")
            {
                b = 20;
            }
            else if (comboBox2.Text == "กาแฟ")
            {
                b = 20;
            }
            else if (comboBox2.Text == "โอเลี้ยง")
            {
                b = 20;
            }
            else if (comboBox2.Text == "น้ำมะพร้าว")
            {
                b = 15;
            }
            else if (comboBox2.Text == "ขนมหม้อแกง")
            {
                b = 3;
            }
            else if (comboBox2.Text == "ขนมลูกชุบ")
            {
                b = 1;
            }
            else if (comboBox2.Text == "ขนมดอกจอก")
            {
                b = 2;
            }
            else if (comboBox2.Text == "ขนมเทียน")
            {
                b = 3;
            }
            else if (comboBox2.Text == "ขนมทองหยอด")
            {
                b = 1;
            }
            else if (comboBox2.Text == "ขนมจีบ")
            {
                b = 2;
            }
            else if (comboBox2.Text == "ซาลาเปา")
            {
                b = 5;

            }
            else
            {
                MessageBox.Show("กรุณาเลือกสินค้า");
            }
            sum = b * c;
            label1.Text = sum + "";
            label2.Text = b + "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "เมนูข้าว")
            {
                comboBox2.Items.Clear();
                int[] a = new int[7];
                a[0] = comboBox2.Items.Add("กระเพราหมูสับ");
                a[1] = comboBox2.Items.Add("กระเพราหมูกรอบ");
                a[2] = comboBox2.Items.Add("กระเพรากุ้ง");
                a[3] = comboBox2.Items.Add("กระเพราหมึก");
                a[4] = comboBox2.Items.Add("กระเพราไก่");
                a[5] = comboBox2.Items.Add("กระเพรารวม");
                a[6] = comboBox2.Items.Add("ข้าวผัดกุ้ง");
            }
            else if (comboBox1.Text == "เมนูเส้น")
            {
                comboBox2.Items.Clear();
                int[] a = new int[7];
                a[0] = comboBox2.Items.Add("ก๋วยเตี๋ยวเนื้อน้ำตก");
                a[1] = comboBox2.Items.Add("ก๋วยเตี๋ยวหมูน้ำตก");
                a[2] = comboBox2.Items.Add("ก๋วยเตี๋ยวเนื้อน้ำใส");
                a[3] = comboBox2.Items.Add("ก๋วยเตี๋ยวหมูน้ำใส");
                a[4] = comboBox2.Items.Add("ก๋วยจั๊บ");
                a[5] = comboBox2.Items.Add("ต้มเส้น");
                a[6] = comboBox2.Items.Add("เกาเหลา");
            }
            else if (comboBox1.Text == "เครื่องดื่ม")
            {
                comboBox2.Items.Clear();
                int[] a = new int[7];
                a[0] = comboBox2.Items.Add("น้ำเปล่า");
                a[1] = comboBox2.Items.Add("โค้ก");
                a[2] = comboBox2.Items.Add("เป็ปซี่");
                a[3] = comboBox2.Items.Add("ชาเย็น");
                a[4] = comboBox2.Items.Add("กาแฟ");
                a[5] = comboBox2.Items.Add("โอเลี้ยง");
                a[6] = comboBox2.Items.Add("น้ำมะพร้าว");
            }
            else if (comboBox1.Text == "ขนม")
            {
                comboBox2.Items.Clear();
                int[] a = new int[7];
                a[0] = comboBox2.Items.Add("ขนมหม้อแกง");
                a[1] = comboBox2.Items.Add("ขนมลูกชุบ");
                a[2] = comboBox2.Items.Add("ขนมดอกจอก");
                a[3] = comboBox2.Items.Add("ขนมเทียน");
                a[4] = comboBox2.Items.Add("ขนมทองหยอด");
                a[5] = comboBox2.Items.Add("ขนมจีบ");
                a[6] = comboBox2.Items.Add("ซาลาเปา");
            }
            else
            {
                MessageBox.Show("กรุณาเลือกสินค้า");
            }
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
