using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int row = 1; row <= 15 ; row ++ )
            {
                for (int col = 1; col <= 8; col++)
                {
                    if (col == 1)
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (row == 1 && col <=6)
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (row==8 && col <= 6)
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (col == 8 && ((row > 2 && row <= 6) || (row > 9 && row <= 15)))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if ((row == 2 && col == 7) || (row == 7 && col == 7) || (row == 9 && col == 7))
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
