using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testnaruemol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox1.Text);
            int coe = 100;
            int en = 10;
            int t,tp,tn;

            int[] x = new int[2];

           

            int[] p = new int[10];
            

            int[] n = new int[10];
            int l = 0;
            Random rx = new Random();

            for (int i = 1;i <= 10; i++)
            {
                
                x[0] = 1;
                x[1] = 2;
                
                t = rx.Next(0, 2);
                int coep,enp,coen,enn;
                if (x[t] == 1)
                {
                    
                    p[0] = 1;
                    p[1] = 2;
                    p[2] = 3;
                    p[3] = 4;
                    p[4] = 5;
                    p[5] = 6;
                    p[6] = 7;
                    p[7] = 8;
                    p[8] = 9;
                    p[9] = 10;

                    Random rp = new Random();
                    tp = rp.Next(0, 10);

                    coep = coe + ((coe * p[tp]) / 100);
                    enp = en + ((en * p[tp]) / 100);
                    coe = coe + ((coe * p[tp]) / 100);
                    en = en + ((en * p[tp]) / 100);
                    l++;
                    money = money + (coep + enp);
                    richTextBox1.AppendText("เหรียญ COE: เทรดครั้งที่ "+l+" ที่ราคา "+coep+
                        " บาท \n(มูลค่าปัจจุบัน"+money+" บาท");
                    richTextBox1.AppendText("\nเหรียญ EN: เทรดครั้งที่ " + l + " ที่ราคา " + enp +
                        " บาท \n(มูลค่าปัจจุบัน" + money + " บาท\n");

                }
                else
                {
                    n[0] = 1;
                    n[1] = 2;
                    n[2] = 3;
                    n[3] = 4;
                    n[4] = 5;
                    n[5] = 6;
                    n[6] = 7;
                    n[7] = 8;
                    n[8] = 9;
                    n[9] = 10;

                    Random rn = new Random();
                    tn = rn.Next(0, 10);
                    coen = coe-((coe *p[tn]) / 100);
                    enn = en-((en * p[tn]) / 100);
                    coe = coe - ((coe * p[tn]) / 100);
                    en = en - ((en * p[tn]) / 100);
                    l++;
                    money = money - (coen + enn);
                    richTextBox1.AppendText("เหรียญ COE: เทรดครั้งที่ " + l + " ที่ราคา " + coen +
                        " บาท \n(มูลค่าปัจจุบัน" + money + " บาท");
                    richTextBox1.AppendText("\nเหรียญ EN: เทรดครั้งที่ " + l + " ที่ราคา " + enn +
                        " บาท \n(มูลค่าปัจจุบัน" + money + " บาท\n");
                }
                
            }
        }
    }
}
