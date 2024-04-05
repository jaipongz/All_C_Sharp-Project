using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2608
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 cal = new Class1();
            cal.balanceSet(int.Parse(textBox1.Text));
            cal.withdrawSet(int.Parse(comboBox1.Text));
            
            richTextBox1.AppendText(cal.showDetail());
            textBox1.Text = cal.getTotal() +"";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Class2 cl = new Class2();
                cl.setUser(tbxuse.Text);
                cl.setID(int.Parse(tbxid.Text));

                MessageBox.Show(cl.showPrivateDetail());

                
            }
            catch
            {
                MessageBox.Show("รหัสผ่านกำหนดเป็นตัวเลขเท่านั้น");
            }
            

        }
    }
}
