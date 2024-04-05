using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "MAZDA")
            {
                comboBox2.Items.Clear();
                int[] a = new int[5];
                a[0] = comboBox2.Items.Add("MAZDA 2");
                a[1] = comboBox2.Items.Add("MAZDA 3");
                a[2] = comboBox2.Items.Add("MAZDA CX-3");
                a[3] = comboBox2.Items.Add("MAZDA CX-5");
                a[4] = comboBox2.Items.Add("MAZDA CX-30");
            }
            else if (comboBox1.Text == "TOYOTA") 
            {
                comboBox2.Items.Clear();
                int[] a = new int[5];
                a[0] = comboBox2.Items.Add("TOYOTA CAMRY");
                a[1] = comboBox2.Items.Add("TOYOTA YARIS");
                a[2] = comboBox2.Items.Add("TOYOTA ALTIS");
                a[3] = comboBox2.Items.Add("TOYOTA VIOS");
                a[4] = comboBox2.Items.Add("TOYOTA HILUX REVO ROCCO");
            }
            else if (comboBox1.Text == "HONDA") 
            {
                comboBox2.Items.Clear();
                int[] a = new int[5];
                a[0] = comboBox2.Items.Add("HONDA Accord");
                a[1] = comboBox2.Items.Add("HONDA City");
                a[2] = comboBox2.Items.Add("HONDA Civic");
                a[3] = comboBox2.Items.Add("HONDA Jazz");
                a[4] = comboBox2.Items.Add("HONDA CR-V");
            }
            else
            {
                comboBox2.Items.Clear();
                int[] a = new int[5];
                a[0] = comboBox2.Items.Add("ISUZU D-Max X Series");
                a[1] = comboBox2.Items.Add("ISUZU D-Max V-Cross");
                a[2] = comboBox2.Items.Add("ISUZU D-Max Hi-Lander");
                a[3] = comboBox2.Items.Add("ISUZU D-Max Spark");
                a[4] = comboBox2.Items.Add("ISUZU Mu-X");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text == "TOYOTA CAMRY")
            {
                label1.Text = "ราคา 1,455,000 บาท";
            }
            else if (comboBox2.Text == "TOYOTA YARIS")
            {
                label1.Text = "ราคา 549,000 บาท";
            }
            else if (comboBox2.Text == "TOYOTA ALTIS")
            {
                label1.Text = "ราคา 839,000 บาท";
            }
            else if (comboBox2.Text == "TOYOTA VIOS")
            {
                label1.Text = "ราคา 609,000 บาท";
            }
            else if (comboBox2.Text == "TOYOTA HILUX REVO ROCCO")
            {
                label1.Text = "ราคา 949,000 บาท";
            }
            else if (comboBox2.Text == "MAZDA 2")
            {
                label1.Text = "ราคา 546,000 บาท";
            }
            else if (comboBox2.Text == "MAZDA 3")
            {
                label1.Text = "ราคา 969,000 บาท";
            }
            else if (comboBox2.Text == "MAZDA CX-3")
            {
                label1.Text = "ราคา 769,000 บาท";
            }
            else if (comboBox2.Text == "MAZDA CX-5")
            {
                label1.Text = "ราคา 1,399,000 บาท";
            }
            else if (comboBox2.Text == "MAZDA CX-30")
            {
                label1.Text = "ราคา 989,000 บาท";
            }
            else if (comboBox2.Text == "HONDA Accord")
            {
                label1.Text = "ราคา 1,799,000 บาท";
            }
            else if (comboBox2.Text == "HONDA City")
            {
                label1.Text = "ราคา 849,000 บาท";
            }
            else if (comboBox2.Text == "HONDA Civic")
            {
                label1.Text = "ราคา 1,219,0000 บาท";
            }
            else if (comboBox2.Text == "HONDA Jazz")
            {
                label1.Text = "ราคา 754,000 บาท";
            }
            else if (comboBox2.Text == "HONDA CR-V")
            {
                label1.Text = "ราคา 1,759,000 บาท";
            }
            else if (comboBox2.Text == "ISUZU D-Max X Series")
            {
                label1.Text = "ราคา 838,000 บาท";
            }
            else if (comboBox2.Text == "ISUZU D-Max V-Cross")
            {
                label1.Text = "ราคา 1,164,000 บาท";
            }
            else if (comboBox2.Text == "ISUZU D-Max Hi-Lander")
            {
                label1.Text = "ราคา 885,000 บาท";
            }
            else if (comboBox2.Text == "ISUZU D-Max Spark")
            {
                label1.Text = "ราคา 519,000 บาท";
            }
            else if (comboBox2.Text == "ISUZU Mu-X")
            {
                label1.Text = "ราคา 1,254,000 บาท";
            }
            else
            {
                label1.Text = "กรุณาเลือกรายการ";
            }




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
