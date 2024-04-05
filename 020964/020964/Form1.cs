using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020964
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndiposit_Click(object sender, EventArgs e)
        {
            Dipsit dis = new Dipsit();
            this.Hide();
            dis.Show();
        }

        private void btnfast_Click(object sender, EventArgs e)
        {
            fast f = new fast();
            this.Hide();
            f.Show();
        }

        private void btnwit_Click(object sender, EventArgs e)
        {
            Withdraw with = new Withdraw();
            this.Hide();
            with.Show();
        }

        private void btnstage_Click(object sender, EventArgs e)
        {
            ATM atm = new ATM();
            label1.Text = atm.getTotal() + "";
        }
    }
}
