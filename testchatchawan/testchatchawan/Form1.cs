using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testchatchawan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l = 0;
            int th = 1;
            int sword;
            Random s = new Random();
            int cost = l * 100;
            while (th == 1)
            {
                sword = s.Next(1, 51);
                l++;
                richTextBox1.AppendText("สุ่มครั้งที่ "+l+" [ดาบ LV. "+sword+" ]\n");
                if (sword == 50)
                {
                    
                    int shield;
                    Random sh = new Random();
                    
                    while (th == 1)
                    {
                        shield = sh.Next(1, 46);
                        l++;
                        richTextBox1.AppendText("สุ่มครั้งที่ " + l +
                            " [ดาบ LV. " + sword + " ]"+"[โล่ LV. " + shield + "]\n");
                        if (shield == 45)
                        {
                            int armor;
                            Random a = new Random();
                            
                            while (th == 1)
                            {
                                armor = a.Next(1, 41);
                                l++;
                                richTextBox1.AppendText("สุ่มครั้งที่ " + l +
                            " [ดาบ LV. " + sword + " ]" + "[โล่ LV. " + 
                            shield + "]"+"[ชุดเกราะ LV. " +
                            armor + "]\n");
                                if (armor == 40)
                                {
                                    int boots;
                                    Random b = new Random();
                                    
                                    while (th == 1)
                                    {
                                        boots = b.Next(1, 36);
                                        l++;
                                        richTextBox1.AppendText("สุ่มครั้งที่ " + l +
                            " [ดาบ LV. " + sword + " ]" + "[โล่ LV. " +
                            shield + "]" + "[ชุดเกราะ LV. " +
                            armor + "]" + "[รองเท้า LV. " +
                            boots + "]\n");
                                        if (boots == 35)
                                        {
                                            richTextBox1.AppendText("ใช้เงินไปทั้งสิ้น " + l * 100 + " บาท");
                                            /*richTextBox1.AppendText("สุ่มครั้งที่ " + l +
                            " [ดาบ LV. " + sword + " ]" + "[โล่ LV. " +
                            shield + "]" + "[ชุดเกราะ LV. " +
                            armor + "]" + "[รองเท้า LV. " +
                            boots + "]\n"+" ใช้เงินไปทั้งสิ้น "+l*100+" บาท");*/
                                            //MessageBox.Show("ใช้เงินไปทั้งสิ้น " + l * 100 + " บาท");
                                            th++;
                                        }
                                    }
                                    
                                }
                            }
                            
                        }
                        
                    }
                    
                }
            }
            
        }
    }
}
