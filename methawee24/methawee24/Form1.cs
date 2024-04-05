using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methawee24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input
            richTextBox1.Clear();
            int colin = int.Parse(textBox6.Text); //รับค่าแถว
            int rowin = int.Parse(textBox7.Text); //รับค่าหลัก
            int p; //รับค่าแรนด้อม
            char[] t = new char[5]; //อะเรย์รับค่าจาก textbox
            t[0] = char.Parse(textBox1.Text);
            t[1] = char.Parse(textBox2.Text);
            t[2] = char.Parse(textBox3.Text);
            t[3] = char.Parse(textBox4.Text);
            t[4] = char.Parse(textBox5.Text);

            Random r = new Random(); //เรียกใช้แรนด้อม
            p = r.Next(0, 5);

            //process

            if(colin == rowin && (colin % 2) != 0 && (rowin % 2) != 0) //เงื่อนไขเมื่อโจทย์ถูกต้อง
            {
                for(int c = 1; c <= colin ; c++)//คำสั่งวาดแถว
                {
                    for(int z =1;z <= rowin; z++) //คำสั่งวาดหลัก
                    {
                        if (c == 1 || c == colin) //เงื่อนไขการวาดแถว
                        {
                            richTextBox1.AppendText(t[p] + "   "); // t[p] คือ อะเรย์ t ในตำแน่งที่ p
                        }
                        else if(z == 1 || z == rowin) //เงื่อนไขการวาดหลัก
                        {
                            richTextBox1.AppendText(t[p] + "   ");
                        }
                        else //เงื่อนไขการวาดช่องว่าง
                        {
                            richTextBox1.AppendText("     ");
                        }
                    }
                    richTextBox1.AppendText("\n"); //เว้นบรรทัด
                }
            }
            else //เมื่อเงื่อนไขไม่ถูกต้อง
            {
                MessageBox.Show("ไม่ตรงตามเงื่อนไข");
            }
        }
    }
}
