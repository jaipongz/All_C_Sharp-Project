using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peach26
{
    class flower
    {
        public string flow;
        private string s;

        public void setflow(string f)
        {
            flow = f;
        }
        public void sets(string show)
        {
            s = show;
        }
        public string getflow()
        {
            return flow;
        }
        public string gets()
        {
            return s;
        }
        public string showDetail()
        {
            string str = "";
            
            if (flow == "ดอกทานตะวัน")
            {
                str = "สีเหลือง";
            }
            else if (flow == "ดอกกุหลาบ")
            {
                str = "สีแดง";
            }
            else if (flow == "ดอกซากุระ")
            {
                str = "สีชมพุ";
            }
            else if (flow == "ดอกชบา")
            {
               str = "สีแดง";
            }
            else if (flow == "ดอกลาเวนเดอร์")
            {
                str = "สีม่วง";
            }
            else if (flow == "ดอกเฟื่องฟ้า")
            {
                str = "สีชมพู";
            }
            else if (flow == "ดอกมะลิ")
            {
                str = "สีขาว";
            }
            else if (flow == "ดอกอัญชัน")
            {
                str = "สีน้ำเงิน";
            }
            else
            {
                str = ("กรุณาเลือกดอกไม้");
            }
            return str;
        }
    }
}
