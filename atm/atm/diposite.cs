using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class diposite : Form
    {
        public diposite()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 bal1 = new Class1();

            Form1 form = new Form1();
            int bal = 0;
            if (textBox1.Text == "" ||Convert.ToInt32(textBox1.Text) <= 0)
            {
                MessageBox.Show("กรุณาใสจำนวนเงินที่ต้องการฝาก");
            }
            else
            {
                try
                {

                    bal1 = int.Parse(textBox1.Text);
                    MessageBox.Show("ฦากเงินเรีบยร้อย");
                    form.Show();
                    this.Hide();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
