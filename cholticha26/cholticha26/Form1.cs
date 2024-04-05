using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cholticha26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            month mn = new month();
            mn.setm(comboBox1.Text);
            label2.Text = mn.showDetail() + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            season s = new season();
            s.setm(comboBox1.Text);
            //label2.Text = s.showDetail() + "";
            MessageBox.Show(comboBox1.Text+"\n" + s.showSeasons());
        }
    }
}
