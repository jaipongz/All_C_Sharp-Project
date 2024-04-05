using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cholticha4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "NVIDIA")
            {
                comboBox2.Items.Clear();
                int[] f = new int[5];
                f[0] = comboBox2.Items.Add("NVIDIA RTX 3060");
                f[1] = comboBox2.Items.Add("NVIDIA RTX 3060Ti");
                f[2] = comboBox2.Items.Add("NVIDIA RTX 3090");
                f[3] = comboBox2.Items.Add("NVIDIA RTX 3080");
                f[4] = comboBox2.Items.Add("NVIDIA Rtx 3070 TI");
            }
            else if (comboBox1.Text == "ASUS")
            {
                comboBox2.Items.Clear();
                int[] f = new int[5];
                f[0] = comboBox2.Items.Add("ASUS CERBERUS GTX1050Ti OC");
                f[1] = comboBox2.Items.Add("ASUS RTX 3060Ti KO Gaming OC");
                f[2] = comboBox2.Items.Add("ASUS RTX 3070 Dual OC");
                f[3] = comboBox2.Items.Add("ASUS GTX650 DCOG");
                f[4] = comboBox2.Items.Add("ASUS RTX 3090 Strix ROG");
            }
            else if (comboBox1.Text == "MSI")
            {
                comboBox2.Items.Clear();
                int[] f = new int[5];
                f[0] = comboBox2.Items.Add("MSI Radeon RX 570 8GT OC");
                f[1] = comboBox2.Items.Add("MSI GTX 1650 SUPER GAMING X");
                f[2] = comboBox2.Items.Add("MSI RTX 3060Ti Gaming X Trio");
                f[3] = comboBox2.Items.Add("MSI GTX 1660 VENTUS XS 6G OC");
                f[4] = comboBox2.Items.Add("MSI GTX 1650 VENTUS XS");
            }
            else 
            {
                comboBox2.Items.Clear();
                int[] f = new int[5];
                f[0] = comboBox2.Items.Add("GIGABYTE GTX 1660 Gaming OC");
                f[1] = comboBox2.Items.Add("GIGABYTE GTX 1650 OC");
                f[2] = comboBox2.Items.Add("GIGABYTE RTX 2060 SUPER GAMING OC");
                f[3] = comboBox2.Items.Add("GIGABYTE RTX 3060Ti Gaming OC");
                f[4] = comboBox2.Items.Add("GIGABYTE RTX 2060 OC");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "NVIDIA RTX 3060")
            {
                label1.Text = "ราคา 11,500 บาท";
            }
            else if (comboBox2.Text == "NVIDIA RTX 3060Ti")
            {
                label1.Text = "ราคา 12,500 บาท";
            }
            else if (comboBox2.Text == "NVIDIA RTX 3090")
            {
                label1.Text = "ราคา 52,800 บาท";
            }
            else if (comboBox2.Text == "NVIDIA RTX 3080")
            {
                label1.Text = "ราคา 24,600 บาท";
            }
            else if (comboBox2.Text == "NVIDIA Rtx 3070 TI")
            {
                label1.Text = "ราคา 20,900 บาท";
            }
            else if (comboBox2.Text == "ASUS CERBERUS GTX1050Ti OC")
            {
                label1.Text = "ราคา 6,700 บาท";
            }
            else if (comboBox2.Text == "ASUS RTX 3060Ti KO Gaming OC")
            {
                label1.Text = "ราคา 16,600 บาท";
            }
            else if (comboBox2.Text == "ASUS RTX 3070 Dual OC")
            {
                label1.Text = "ราคา 19,990 บาท";
            }
            else if (comboBox2.Text == "ASUS GTX650 DCOG")
            {
                label1.Text = "ราคา 4,200 บาท";
            }
            else if (comboBox2.Text == "ASUS RTX 3090 Strix ROG")
            {
                label1.Text = "ราคา 53,890 บาท";
            }
            else if (comboBox2.Text == "MSI Radeon RX 570 8GT OC")
            {
                label1.Text = "ราคา 4,990 บาท";
            }
            else if (comboBox2.Text == "MSI GTX 1650 SUPER GAMING X")
            {
                label1.Text = "ราคา 5,990 บาท";
            }
            else if (comboBox2.Text == "MSI RTX 3060Ti Gaming X Trio")
            {
                label1.Text = "ราคา 15,990 บาท";
            }
            else if (comboBox2.Text == "MSI GTX 1660 VENTUS XS 6G OC")
            {
                label1.Text = "ราคา 7,790 บาท";
            }
            else if (comboBox2.Text == "MSI GTX 1650 VENTUS XS")
            {
                label1.Text = "ราคา 4,690 บาท";
            }
            else if (comboBox2.Text == "GIGABYTE GTX 1660 Gaming OC")
            {
                label1.Text = "ราคา 7,690 บาท";
            }
            else if (comboBox2.Text == "GIGABYTE GTX 1650 OC")
            {
                label1.Text = "ราคา 4,390 บาท";
            }
            else if (comboBox2.Text == "GIGABYTE RTX 2060 SUPER GAMING OC")
            {
                label1.Text = "ราคา 14,500 บาท";
            }
            else if (comboBox2.Text == "GIGABYTE RTX 3060Ti Gaming OC")
            {
                label1.Text = "ราคา 14,900 บาท";
            }
            else if (comboBox2.Text == "GIGABYTE RTX 2060 OC")
            {
                label1.Text = "ราคา 12,790 บาท";
            }
            else
            {
                label1.Text = "กรุณาเลือกรายการ";
            }
        }
    }
}
