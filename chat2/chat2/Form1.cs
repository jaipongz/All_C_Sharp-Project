using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "อาหารภาคเหนือ")
            {
                listBox1.Items.Clear();
                int[] a = new int[8];
                a[0] = listBox1.Items.Add("น้ำพริกหนุ่ม");
                a[1] = listBox1.Items.Add("น้ำพริกอ่อง");
                a[2] = listBox1.Items.Add("แคบหมู");
                a[3] = listBox1.Items.Add("ไส้อั่ว");
                a[4] = listBox1.Items.Add("แกงโฮะ");
                a[5] = listBox1.Items.Add("แกงฮังเล");
                a[6] = listBox1.Items.Add("ข้าวซอย");
                a[7] = listBox1.Items.Add("ขนมจีนน้ำเงี้ยว");
            }
            else if (comboBox1.Text == "อาหารภาคกลาง")
            {
                listBox1.Items.Clear();
                int[] a = new int[7];
                a[0] = listBox1.Items.Add("น้ำพริกลงเรือ");
                a[1] = listBox1.Items.Add("น้ำพริกกะปิ");
                a[1] = listBox1.Items.Add("ห่อหมก");
                a[2] = listBox1.Items.Add("ทอดมัน");
                a[3] = listBox1.Items.Add("ปูจ๋า");
                a[4] = listBox1.Items.Add("แกงจืด");
                a[5] = listBox1.Items.Add("แกงเผ็ด");
                a[6] = listBox1.Items.Add("แกงส้ม");
            }
            else if (comboBox1.Text == "อาหารอีสาน")
            {
                listBox1.Items.Clear();
                int[] a = new int[7];
                a[0] = listBox1.Items.Add("ซุปหน่อไม้");
                a[1] = listBox1.Items.Add("ต้มส้ม");
                a[2] = listBox1.Items.Add("แกงอ่อม");
                a[3] = listBox1.Items.Add("แกงเปรอะ");
                a[4] = listBox1.Items.Add("แกงเห็ด");
                a[5] = listBox1.Items.Add("ส้มตำ");
                a[6] = listBox1.Items.Add("แกงไข่มดแดง");
            }
            else
            {
                listBox1.Items.Clear();
                int[] a = new int[10];
                a[0] = listBox1.Items.Add("แกงไตปลา");
                a[1] = listBox1.Items.Add("แกงส้ม");
                a[2] = listBox1.Items.Add("แกงเหลือง");
                a[3] = listBox1.Items.Add("ไก่ต้มขมิ้น");
                a[4] = listBox1.Items.Add("ไก่กอแหละ");
                a[5] = listBox1.Items.Add("ปลากระบอกต้มส้ม");
                a[6] = listBox1.Items.Add("คั่วกลิ้ง");
                a[7] = listBox1.Items.Add("ผัดสะตอ");
                a[8] = listBox1.Items.Add("ยำน้ำบูดู");
                a[9] = listBox1.Items.Add("ผัดเผ็ดกบ");
            }
        }
    }
}
