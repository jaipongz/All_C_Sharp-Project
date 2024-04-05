using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naruemol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Blackpink")
            {
                listBox1.Items.Clear();
                int[] a = new int[9];
                a[0] = listBox1.Items.Add("Jisoo");
                a[1] = listBox1.Items.Add("Jannie");
                a[2] = listBox1.Items.Add("Lisa");
                a[3] = listBox1.Items.Add("Rose");

            }
            else if (comboBox1.Text == "Red Velvet")
            {
                listBox1.Items.Clear();
                int[] a = new int[5];
                a[0] = listBox1.Items.Add("Irene");
                a[1] = listBox1.Items.Add("Seulgi");
                a[2] = listBox1.Items.Add("Vendy");
                a[3] = listBox1.Items.Add("Joy");
                a[4] = listBox1.Items.Add("Yeri");
                
            }
            else if (comboBox1.Text == "Twice")
            {
                listBox1.Items.Clear();
                int[] a = new int[9];
                a[0] = listBox1.Items.Add("Jihyo");
                a[1] = listBox1.Items.Add("Nayeon");
                a[2] = listBox1.Items.Add("Mina");
                a[3] = listBox1.Items.Add("Tzuyu");
                a[4] = listBox1.Items.Add("Dahyun");
                a[5] = listBox1.Items.Add("Sana");
                a[6] = listBox1.Items.Add("Jeongyeon");
                a[7] = listBox1.Items.Add("Momo");
                a[8] = listBox1.Items.Add("Chaeyoung");
            }
            else if (comboBox1.Text == "Itzy")
            {
                listBox1.Items.Clear();
                int[] a = new int[5];
                a[0] = listBox1.Items.Add("Ryujin");
                a[1] = listBox1.Items.Add("Lia");
                a[2] = listBox1.Items.Add("Chaeryeong");
                a[3] = listBox1.Items.Add("Yuna");
                a[4] = listBox1.Items.Add("Yeji");
                
            }
            else if (comboBox1.Text == "BTS")
            {
                listBox1.Items.Clear();
                int[] a = new int[7];
                a[0] = listBox1.Items.Add("RM");
                a[1] = listBox1.Items.Add("JIN");
                a[2] = listBox1.Items.Add("SUGA");
                a[3] = listBox1.Items.Add("Jung Ho Seok");
                a[4] = listBox1.Items.Add("Park Ji Min");
                a[5] = listBox1.Items.Add("V");
                a[6] = listBox1.Items.Add("Jeon Jung Kook");
            
            }
            else
            {
                listBox1.Items.Clear();
                int[] a = new int[9];
                a[0] = listBox1.Items.Add("Suho");
                a[1] = listBox1.Items.Add("Baekhyun");
                a[2] = listBox1.Items.Add("Kai");
                a[3] = listBox1.Items.Add("Chanyeol");
                a[4] = listBox1.Items.Add("D.O.");
                a[5] = listBox1.Items.Add("Se Hun");
                a[6] = listBox1.Items.Add("Lay");
                a[7] = listBox1.Items.Add("Xiumin");
                a[8] = listBox1.Items.Add("Chen");
            }
        }
    }
}
