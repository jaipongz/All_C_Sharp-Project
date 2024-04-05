using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace benz4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "จิตวิทยาสี")
            {
                comboBox2.Items.Clear();
                int[] a = new int[10];
                a[0] = comboBox2.Items.Add("สีเหลือง");
                a[1] = comboBox2.Items.Add("สีฟ้า");
                a[2] = comboBox2.Items.Add("สีส้ม");
                a[3] = comboBox2.Items.Add("สีแดง");
                a[4] = comboBox2.Items.Add("สีชมพู");
                a[5] = comboBox2.Items.Add("สีเขียว");
                a[6] = comboBox2.Items.Add("สีม่วง");
                a[7] = comboBox2.Items.Add("สีน้ำเงิน");
                a[8] = comboBox2.Items.Add("สีขาว");
                a[9] = comboBox2.Items.Add("สีดำ");
            }
            else
            {
                comboBox2.Items.Clear();
                int[] a = new int[9];
                a[0] = comboBox2.Items.Add("1");
                a[1] = comboBox2.Items.Add("2");
                a[2] = comboBox2.Items.Add("3");
                a[3] = comboBox2.Items.Add("4");
                a[4] = comboBox2.Items.Add("5");
                a[5] = comboBox2.Items.Add("6");
                a[6] = comboBox2.Items.Add("7");
                a[7] = comboBox2.Items.Add("8");
                a[8] = comboBox2.Items.Add("9");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "สีเหลือง")
            {
                MessageBox.Show("สีเหลืองให้ความรู้สึก สว่าง สดใส ร่าเริง ศรัทธา มั่งคั่ง");
            }
            else if (comboBox2.Text == "สีฟ้า")
            {
                MessageBox.Show("สีฟ้าให้ความรู้สึกปลอดโปร่ง แจ่มใส กว้าง ปราดเปรื่อง");
            }
            else if (comboBox2.Text == "สีส้ม")
            {
                MessageBox.Show("สีส้มให้ความรู้สึกสดใส ร้อนแรง เจิดจ้า มีพลังและอำนาจ");
            }
            else if (comboBox2.Text == "สีแดง")
            {
                MessageBox.Show("สีแดงให้ความรู้สึกเร่าร้อน รุนแรง อันตราย ตื่นเต้น");
            }
            else if (comboBox2.Text == "สีชมพู")
            {
                MessageBox.Show("สีชมพูให้ความรู้สึกอ่อนหวาน อ่อนวัย มีความเป็นผู้หญิง");
            }
            else if (comboBox2.Text == "สีเขียว")
            {
                MessageBox.Show("สีเขียวให้ความรู้สึกสดใส สดชื่น เย็น ปลอดภัย สบายตา ผ่อนคลาย");
            }
            else if (comboBox2.Text == "สีม่วง")
            {
                MessageBox.Show("สีม่วงให้ความรู้สึกทรงพลัง ความมั่นใจในตนเอง");
            }
            else if (comboBox2.Text == "สีน้ำเงิน")
            {
                MessageBox.Show("สีน้ำเงินให้ความรู้สึกสงบ เงียบขรึม จริงจัง มีสมาธิ");
            }
            else if (comboBox2.Text == "สีขาว")
            {
                MessageBox.Show("สีขาวให้ความรู้สึกอ่อนโยนและไร้เดียงสา บริสุทธิ์ ว่างเปล่า");
            }
            else if (comboBox2.Text == "สีดำ")
            {
                MessageBox.Show("สีดำเป็นสีคลาสสิค ให้ความรู้สึกหนักแน่น เข้มแข็ง");
            }
            else if (comboBox2.Text == "1")
            {
                MessageBox.Show("คุณเป็นคนมีความเชื่อมั่นในตนเองสูง มีคุณธรรมและเมตตาธรรม จิตใจดี มีความรับผิดชอบสูง ชอบช่วยเหลือผู้อื่น เฉลียวฉลาด ปราดเปรื่อง");
            }
            else if (comboBox2.Text == "2")
            {
                MessageBox.Show("เป็นคนอ่อนหวาน นุ่มนวล กิริยามารยาทเรียบร้อย มีความประนีประนอมสูง รักสันติ อ่อนน้อมถ่อมตน");
            }
            else if (comboBox2.Text == "3")
            {
                MessageBox.Show("เป็นคนมนุษย์สัมพันธ์ดี มีความประนีประนอมสูง ปรับตัวเก่ง ช่างเอาอกเอาใจ และแคร์ความรู้สึกของคนใกล้ชิด");
            }
                else if (comboBox2.Text == "4")
            {
                MessageBox.Show("เป็นคนเก็บเนื้อเก็บตัว พูดน้อย ชอบทำอะไรเงียบ ๆ คนเดียว โดดเดี่ยว และรักอิสระ เป็นคนฉลาดคิดและฉลาดทำ");
            }
            else if (comboBox2.Text == "5")
            {
                MessageBox.Show("เป็นคนที่ทำอะไรรวดเร็ว กระตือรือร้น และไม่ชอบหยุดนิ่งอยู่กับที่ เสาะแสวงหาสิ่งแปลกใหม่อยู่ร่ำไป ร่าเริงแจ่มใส");
            }
            else if (comboBox2.Text == "6")
            {
                MessageBox.Show(" เป็นคนสุภาพเรียบร้อย กิริยามารยาทนุ่มนวล อ่อนช้อย พูดจาไพเราะ มักมีอุดมการณ์และทัศนคติส่วนตัวที่ไม่เหมือนใคร");
            }
            else if (comboBox2.Text == "7")
            {
                MessageBox.Show("เป็นคนอ่อนน้อมถ่อมตัว พูดน้อย พูดจริง ไม่ชอบการคุยโม้โอ้อวด หรือการยกตนข่มท่าน สติปัญญาดี มีความเจริญก้างหน้าในการศึกษาและอาชีพ");
            }
            else if (comboBox2.Text == "8")
            {
                MessageBox.Show("เป็นคนที่ใช้เหตุผลมากกว่าอารมณ์ ตรงไปตรงมา กล้าในสิ่งที่ควรกล้า และเป็นคนที่กล้าทำก็กล้ารับหนักแน่น และอดทน");
            }
            else if (comboBox2.Text == "9")
            {
                MessageBox.Show("เป็นคนหัวโบราณ เคร่งครัดต่อกฎเกณฑ์และประเพณีนิยม ซื่อสัตย์ และมีความยุติธรรมประจำหัวใจ");
            }
            else
            {
                MessageBox.Show("กรุณาเลือกเลขหรือสีที่ชอบค่ะ");
            }
        }
    }
}
