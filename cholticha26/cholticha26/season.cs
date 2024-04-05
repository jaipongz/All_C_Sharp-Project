using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cholticha26
{
    class season : month
    {
        private int ss;

        public string showSeasons()
        {
            string ses = "";
            ses = "";
            if (m == "มกราคม")
            {
                ses = "ฤดูหนาว";
            }
            else if (m == "กุมภาพันธ์")
            {
                ses = "ฤดูหนาว";
            }
            else if (m == "มีนาคม")
            {
                ses = "ฤดูร้อน";
            }
            else if (m == "เมษายน")
            {
                ses = "ฤดูร้อน";
            }
            else if (m == "พฤษภาคม")
            {
                ses = "ฤดูร้อน";
            }
            else if (m == "มิถุนายน")
            {
                ses = "ฤดูฝน";
            }
            else if (m == "กรกฎาคม")
            {
                ses = "ฤดูฝน";
            }
            else if (m == "สิงหาคม")
            {
                ses = "ฤดูฝน";
            }
            else if (m == "กันยายน")
            {
                ses = "ฤดูฝน";
            }
            else if (m == "ตุลาคม")
            {
                ses = "ฤดูหนาว";
            }
            else if (m == "พฤศจิกายน")
            {
                ses = "ฤดูหนาว";
            }
            else if (m == "ธันวาคม")
            {
                ses = "ฤดูหนาว";
            }

            return ses;

        }

    }
}
