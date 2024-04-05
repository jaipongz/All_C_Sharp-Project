using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mark3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int row = 1; row<=11;row++)
            {
                for(int col = 1; col<=5; col++)
                {
                    if (col == 5 && (row > 1 && row <= 10))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (col == 1 && (row > 1 && row <= 6))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (row == 1 && (col > 1 && col <= 4))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (row == 7 && (col > 1 && col <= 4))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (row == 11 && (col > 1 && col <= 4))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (row == 10 && col == 1)
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
