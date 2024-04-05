using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arnon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ดอกทานตะวัน")
            {
                textBox1.Text = "สีเหลือง";
            }
            else if (comboBox1.Text == "ดอกกุหลาบ")
            {
                textBox1.Text = "สีแดง";
            }
            else if (comboBox1.Text == "ดอกซากุระ")
            {
                textBox1.Text = "สีชมพุ";
            }
            else if (comboBox1.Text == "ดอกชบา")
            {
                textBox1.Text = "สีแดง";
            }
            else if (comboBox1.Text == "ดอกลาเวนเดอร์")
            {
                textBox1.Text = "สีม่วง";
            }
            else if (comboBox1.Text == "ดอกเฟื่องฟ้า")
            {
                textBox1.Text = "สีชมพู";
            }
            else if (comboBox1.Text == "ดอกมะลิ")
            {
                textBox1.Text = "สีขาว";
            }
            else if (comboBox1.Text == "ดอกอัญชัน")
            {
                textBox1.Text = "สีน้ำเงิน";
            }
            else
            {
                MessageBox.Show("กรุณาเลือกดอกไม้");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
