using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _110864
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "กลุ่มภาคตะวันออกเฉียงเหนือ")
            {
                listBox1.Items.Clear();
                int[] a = new int[12];
                a[0] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏอุดรธานี");
                a[1] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏมหาสารคาม");
                a[2] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏเลย");
                a[3] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏสกลนคร");
                a[4] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏนครราชสีมา");
                a[5] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏบุรีรัมย์");
                a[6] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏสุรินทร์");
                a[7] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏอุบลราชธานี");
                a[8] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏกาฬสินธุ์");
                a[9] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏชัยภูมิ");
                a[10] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏร้อยเอ็ด");
                a[11] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏศรีสะเกษ");
            }
            else if (comboBox1.Text == "กลุ่มภาคเหนือ")
            {
                listBox1.Items.Clear();
                int[] a = new int[8];
                a[0] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏเชียงใหม่");
                a[1] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏเชียงราย");
                a[2] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏลำปาง");
                a[3] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏอุตรดิตถ์");
                a[4] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏพิบูลสงคราม");
                a[5] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏกำแพงเพชร");
                a[6] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏนครสวรรค์");
                a[7] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏเพชรบูรณ์");
                
                
            }
            else if (comboBox1.Text == "กลุ่มภาคกลาง")
            {
                listBox1.Items.Clear();
                int[] a = new int[9];
                a[0] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏพระนครศรีอยุธยา");
                a[1] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏรำไพพรรณี");
                a[2] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏราชนครินทร์");
                a[3] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏเทพสตรี");
                a[4] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏวไลยอลงกรณ์ ในพระบรมราชูปถัมภ์");
                a[5] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏเพชรบุรี");
                a[6] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏกาญจนบุรี");
                a[7] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏนครปฐม");
                a[8] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏหมู่บ้านจอมบึง");

            }
            else if (comboBox1.Text == "กลุ่มภาคใต้")
            {
                listBox1.Items.Clear();
                int[] a = new int[5];
                a[0] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏสุราษฎร์ธานี");
                a[1] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏนครศรีธรรมราช");
                a[2] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏภูเก็ต");
                a[3] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏสงขลา");
                a[4] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏยะลา");
               

            }
            else
            {
                listBox1.Items.Clear();
                int[] a = new int[6];
                a[0] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏสวนสุนันทา");
                a[1] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏสวนดุสิต");
                a[2] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏจันทรเกษม");
                a[3] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏพระนคร");
                a[4] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏธนบุรี");
                a[5] = listBox1.Items.Add("มหาวิทยาลัยราชภัฏบ้านสมเด็จเจ้าพระยา");
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
