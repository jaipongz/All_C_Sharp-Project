using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace atm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Balance");
        private void button1_Click(object sender, EventArgs e)
        {
            diposite dis = new diposite();
            this.Hide();
            dis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fast fas = new fast();
            this.Hide();
            fas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdraw wit = new withdraw();
            this.Hide();
            wit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stagement stage = new stagement();
            this.Hide();
            stage.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diposite dis = new diposite();
            

        }
    }
}
