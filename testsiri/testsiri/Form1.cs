using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testsiri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  b; //รับค่า random
            int l = 0, sh = 0, sud = 0,  f = 0; //จำนวนครั้งของการโยน
            int ls = 0, shs = 0, suds = 0; //คะแนน
            int lf = 0, shf = 0, sudf = 0; //ครั้งที่พลาด
            int[] p =new int[6]; //อาเรย์ของการ shoot
            int t = 0;// คะแนนที่ได้
            int c = 0;// คะแนนที่ควรจะได้


            for (int i = 1; i<=20; i ++) //โจทย์สั่งให้ชุ้ต 20 ครั้ง
            {
                p[0] = 3; //Long
                p[1] = 2; //short
                p[2] = 1; //sudden
                p[3] = 6; //Longfail
                p[4] = 5; //shortfail
                p[5] = 4; //suddenfail
                Random r = new Random(); //เรียใช้ random
                b = r.Next(0, 6); //ให้ตัวแปร b รับค่าของการสุม จาก 0-6

               //คำสั่งประมวลผล
                
                    if (p[b]== 3)//ถ้าอะเรย์ p ในตำแหน่งที่ b (random) = 3 คือค่า long
                    {
                        c = c + 3; //คะแนนที่ควรจะได้ + 3
                        l++; //การโยนแบบ long + 1
                        ls = ls + 3; //คะแนน long + 3

                    }
                    else if (p[b] == 2)//ถ้าอะเรย์ p ในตำแหน่งที่ b (random) = 2 คือค่า short
                {
                        c = c+2;
                        sh++;
                        shs = shs + 2;
                    }
                    else if(p[b]==1)//ถ้าอะเรย์ p ในตำแหน่งที่ b (random) = 1 คือค่า sudden
                {
                        c = c + 1;
                        sud++;
                        suds = suds + 1;
                    }
                
                    else if (p[b] == 6)//ถ้าอะเรย์ p ในตำแหน่งที่ b (random) = 6 คือค่า long fail
                {
                        c = c + 3;
                        l++;
                        lf++;

                    }
                    else if (p[b] == 5)//ถ้าอะเรย์ p ในตำแหน่งที่ b (random) = 5 คือค่า short fail
                {
                        c = c + 2;
                        sh++;
                        shf++;
                    }
                else//ถ้าอะเรย์ p ในตำแหน่งที่ b (random) = 4 คือค่า sudden fail
                {
                        c = c + 1;
                        sud++;
                        sudf++;
                    }
                t = ls + shs + suds; //คะแนนที่ได้ = long score + short score +sedden score
                richTextBox1.Text = ("ชู้ตจากระยะไกล จำนวน " + l + " ครั้ง พลาด " + lf + " ครั้ง ได้ " + ls + " คะแนน" + "\nชู้ตจากระยะใกล้ จำนวน " + sh + " ครั้ง พลาด " + shf + " ครั้ง ได้ " + shs + "" + "\nชู้ตลูกโทษ จำนวน " + sud + " ครั้ง พลาด " + sudf + " ครั้ง ได้ " + suds + ""+"\nรวมคะแนนทั้งสิ้น "+t+" คะแนน จาก "+c+" คะแนน");

            }
            

        }
    }
}
