using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace benz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "สีเหลือง")
            {
                MessageBox.Show("สีเหลืองให้ความรู้สึก สว่าง สดใส ร่าเริง ศรัทธา มั่งคั่ง");
            }
            else if (comboBox1.Text == "สีฟ้า")
            {
                MessageBox.Show("สีฟ้าให้ความรู้สึกปลอดโปร่ง แจ่มใส กว้าง ปราดเปรื่อง");
            }
            else if (comboBox1.Text == "สีส้ม")
            {
                MessageBox.Show("สีส้มให้ความรู้สึกสดใส ร้อนแรง เจิดจ้า มีพลังและอำนาจ");
            }
            else if (comboBox1.Text == "สีแดง")
            {
                MessageBox.Show("สีแดงให้ความรู้สึกเร่าร้อน รุนแรง อันตราย ตื่นเต้น");
            }
            else if (comboBox1.Text == "สีชมพู")
            {
                MessageBox.Show("สีชมพูให้ความรู้สึกอ่อนหวาน อ่อนวัย มีความเป็นผู้หญิง");
            }
            else if (comboBox1.Text == "สีเขียว")
            {
                MessageBox.Show("สีเขียวให้ความรู้สึกสดใส สดชื่น เย็น ปลอดภัย สบายตา ผ่อนคลาย");
            }
            else if (comboBox1.Text == "สีม่วง")
            {
                MessageBox.Show("สีม่วงให้ความรู้สึกทรงพลัง ความมั่นใจในตนเอง");
            }
            else if (comboBox1.Text == "สีน้ำเงิน")
            {
                MessageBox.Show("สีน้ำเงินให้ความรู้สึกสงบ เงียบขรึม จริงจัง มีสมาธิ");
            }
            else if (comboBox1.Text == "สีขาว")
            {
                MessageBox.Show("สีขาวให้ความรู้สึกอ่อนโยนและไร้เดียงสา บริสุทธิ์ ว่างเปล่า");
            }
            else
            {
                MessageBox.Show("สีดำเป็นสีคลาสสิค ให้ความรู้สึกหนักแน่น เข้มแข็ง");
            }
        }
    }
}
