using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cholticha26
{
    class month
    {
        public string m;
        private string s;

        public void setm(string mon)
        {
            m = mon;
        }
        public void sets(string show)
        {
            s = show;
        }
        public string getm()
        {
            return m;
        }
        public string gets()
        {
            return s;
        }
        public string showDetail()
        {
            string str = "";
            str = "";
            if (m == "มกราคม")
            {
                str = "31";
            }
            else if (m == "กุมภาพันธ์")
            {
                str = "28,29";
            }
            else if (m == "มีนาคม")
            {
                str = "31";
            }
            else if (m == "เมษายน")
            {
                str = "30";
            }
            else if (m == "พฤษภาคม")
            {
                str = "31";
            }
            else if (m == "มิถุนายน")
            {
                str = "30";
            }
            else if (m == "กรกฎาคม")
            {
                str = "31";
            }
            else if (m == "สิงหาคม")
            {
                str = "31";
            }
            else if (m == "กันยายน")
            {
                str = "30";
            }
            else if (m == "ตุลาคม")
            {
                str = "31";
            }
            else if (m == "พฤศจิกายน")
            {
                str = "30";
            }
            else if (m == "ธันวาคม")
            {
                str = "31";
            }

            return str;
        }
    }
}
