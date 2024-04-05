using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testpanadda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                int x = int.Parse(textBox11.Text); // จำนวนการสุ่ม
                int full = int.Parse(textBox12.Text); //ความจุ
                int f, l = 0;
                int t = 0;//ปริมานน้ำปัจจุบัน
                int[] water = new int[10];
                water[0] = int.Parse(textBox1.Text);
                water[1] = int.Parse(textBox2.Text);
                water[2] = int.Parse(textBox3.Text);
                water[3] = int.Parse(textBox4.Text);
                water[4] = int.Parse(textBox5.Text);
                water[5] = int.Parse(textBox6.Text);
                water[6] = int.Parse(textBox7.Text);
                water[7] = int.Parse(textBox8.Text);
                water[8] = int.Parse(textBox9.Text);
                water[9] = int.Parse(textBox10.Text);
                Random r = new Random();

                for (int i = 1; i <= x; i++)
                {




                    f = r.Next(0, 10);
                    t = t + water[f];
                    l++;
                    richTextBox1.AppendText("รอบที่ " + l + " เทจำนวน " + water[f] +
                        " ลิตร น้ำในถังมี " + t + " ลิตร จาก " + full + " ลิตร\n");


                    if (t == full)
                    {
                        MessageBox.Show("น้ำเต็ม รอบที่ " + l + " จำนวน " + full + " ลิตร");
                        break;
                    }
                    else if (t > full)
                    {
                        richTextBox1.AppendText("ปริมาณน้ำเกินเริ่มเทใหม่");
                        //MessageBox.Show("ปริมาณน้ำเกิน\nเริ่มเทใหม่");
                        break;
                    }
                    else
                    {

                        continue;

                    }
                }
                if (t < full)
                {
                    richTextBox1.AppendText("ปริมาณน้ำไม่เต็มเริ่มเทใหม่");
                    // MessageBox.Show("ปริมาณน้ำไม่เต็ม\nเริ่มเทใหม่");
                }
            }
            catch
            {
                MessageBox.Show("กรุณากรอกจำนวนน้ำเป็นตัวเลข\nและกรอกให้ครบด้วยค่ะ");
            }
            
           
            
            

        }
    }
}
