using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arnon3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ดอกไม้สีแดง")
            {
                listBox1.Items.Clear();
                int[] r = new int[5];
                r[0] = listBox1.Items.Add("ดอกกุหลาบ");
                r[1] = listBox1.Items.Add("ดอกชบา");
                r[2] = listBox1.Items.Add("ดอกเข็ม");
                r[3] = listBox1.Items.Add("ดอกไก่แดง");
                r[4] = listBox1.Items.Add("ดอกบานเที่ยง");
            }
            else if (comboBox1.Text == "ดอกไม้สีเหลือง") 
            {
                listBox1.Items.Clear();
                int[] r = new int[5];
                r[0] = listBox1.Items.Add("ดอกทานตะวัน");
                r[1] = listBox1.Items.Add("ดอกดาวเรือง");
                r[2] = listBox1.Items.Add("ดอกเบญจมาศ");
                r[3] = listBox1.Items.Add("ดอกดารารัตน์");
                r[4] = listBox1.Items.Add("ดอกราชพฤกษ์");
            }
            else if (comboBox1.Text == "ดอกไม้สีน้ำเงิน")
            {
                listBox1.Items.Clear();
                int[] r = new int[5];
                r[0] = listBox1.Items.Add("ดอก Forget me not");
                r[1] = listBox1.Items.Add("ดอก Delphinium");
                r[2] = listBox1.Items.Add("ดอก Bluebell");
                r[3] = listBox1.Items.Add("ดอก Lupine");
                r[4] = listBox1.Items.Add("ดอกอัญชัน");
            }
            else if (comboBox1.Text == "ดอกไม้สีม่วง")
            {
                listBox1.Items.Clear();
                int[] r = new int[5];
                r[0] = listBox1.Items.Add("ดอกลาเวนเดอร์");
                r[1] = listBox1.Items.Add("ดอกเดซี่");
                r[2] = listBox1.Items.Add("ดอกบัว");
                r[3] = listBox1.Items.Add("ดอกคาร์เนชั่น");
                r[4] = listBox1.Items.Add("ดอกไฮยาซินธ์");
            }
            else if (comboBox1.Text == "ดอกไม้สีชมพู")
            {
                listBox1.Items.Clear();
                int[] r = new int[5];
                r[0] = listBox1.Items.Add("ดอกไฮเดรนเยีย");
                r[1] = listBox1.Items.Add("ดอกบัว");
                r[2] = listBox1.Items.Add("ดอกกล้วยไม้");
                r[3] = listBox1.Items.Add("ดอกแอสเตอร์");
                r[4] = listBox1.Items.Add("เยอร์บีร่า");
            }
            else if (comboBox1.Text == "ดอกไม้สีส้ม")
            {
                listBox1.Items.Clear();
                int[] r = new int[5];
                r[0] = listBox1.Items.Add("ดอกกาสะลองคำ");
                r[1] = listBox1.Items.Add("ดอกจาน");
                r[2] = listBox1.Items.Add("ดอกทองกวาว");
                r[3] = listBox1.Items.Add("ดอกพวงแสด");
                r[4] = listBox1.Items.Add("ดอกแคแสด");
            }
            else if (comboBox1.Text == "ดอกไม้สี")
            {
                listBox1.Items.Clear();
                int[] r = new int[5];
                r[0] = listBox1.Items.Add("ดอกมะลิ");
                r[1] = listBox1.Items.Add("ดอกกาหลง");
                r[2] = listBox1.Items.Add("ดอกลีลาวดี");
                r[3] = listBox1.Items.Add("ดอกนางแย้ม");
                r[4] = listBox1.Items.Add("ดอกแก้ว");
            }


        }
    }
}
