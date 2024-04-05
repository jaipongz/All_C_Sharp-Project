using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int row = 1; row <= 10; row++)
            {
                for(int col = 1; col <= 7; col++)
                {
                    if(row==10)
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (col == 1 && (row>2&&row <=4))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (col == 7 && (row > 2 && row<= 4))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (row+col==11)
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if (row == 1 && (col>2 && col <=5))
                    {
                        richTextBox1.AppendText(" # ");
                    }
                    else if ((row==2&&col==2)||(row==2&&col==6))
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
