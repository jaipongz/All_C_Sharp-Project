using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test23
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
            int b;//รับค่า random
            int[] p = new int[6]; //อาเรย์ของการโยน
            int l = 0, sh=0, sud=0, f=0;//ครั้งที่โยน
            int lf=0, shf=0, sudf=0;//ครั้งที่พลาด
            int ls = 0, shs = 0, suds = 0;//คะแนของการโยนแต่ละแบบ 
            int c = 0;//คะแนนที่ควรจะได้
            int t = 0;//total point
            
            
            
            for(int i =1; i <= 20; i++)
            {
                p[0] = 3; //long
                p[1] = 2; //short
                p[2] = 1; //sudden
                p[3] = 6; //long fail
                p[4] = 5; //short fail
                p[5] = 4; //suden fail

                Random r = new Random();
                b = r.Next(0, 6);

                //process
                if(p[b] == 3)
                {
                    c = c + 3;
                    l++;
                    ls = ls + 3;
                }
                else if (p[b] == 2)
                {
                    c = c + 2;
                    sh++;
                    shs = shs + 2;
                }
                else if (p[b] == 1)
                {
                    c = c + 1;
                    sud++;
                    suds = suds + 1;
                }
                else if (p[b] == 6)
                {
                    c = c + 3;
                    l++;
                    lf++;

                }
                else if (p[b] == 5)
                {
                    c = c + 2;
                    sh++;
                    shf++;
                }
                else
                {
                    c = c + 1;
                    sud++;
                    sudf++;
                }
                t = ls + shs + suds;//ผลรวมคะแนน
                richTextBox1.Text = ("ชู้ตจากระยะไกล จำนวน " + l + " ครั้ง พลาด " + lf + " ครั้ง ได้ " + ls + " คะแนน" + "\nชู้ตจากระยะใกล้ จำนวน " + sh + " ครั้ง พลาด " + shf + " ครั้ง ได้ " + shs + " คะแนน" + "\nชู้ตลูกโทษ จำนวน " + sud + " ครั้ง พลาด " + sudf + " ครั้ง ได้ " + suds + " คะแนน" + "\nรวมคะแนนทั้งสิ้น " + t + " จาก " + c + " คะแนน");
            }
            
            
        }
    }
}
