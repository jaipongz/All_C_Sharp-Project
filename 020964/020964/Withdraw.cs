﻿using System;
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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void btnwith_Click(object sender, EventArgs e)
        {
            ATM atm = new ATM();
            atm.setWithdraw(double.Parse(txwith.Text));
            MessageBox.Show("ฝากเงินเรียบร้อย");
        }
    }
}