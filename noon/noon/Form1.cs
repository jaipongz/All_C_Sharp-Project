using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int row = 1; row <= 7; row++)
            {
                for (int col = 1; col <= 9; col++)
                {
                    if (col == 2 && row <= 6)
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (col == 5 && row <= 5)
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (col == 8 && row <= 6)
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if ((row == 6 && col == 4) || (row == 6 && col == 6))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if ((row == 7 && col == 3) || (row == 7 && col == 7))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else
                    {
                        richTextBox1.AppendText("    ");
                    }
                }
                richTextBox1.AppendText("\n");
            }
        }
    }
}