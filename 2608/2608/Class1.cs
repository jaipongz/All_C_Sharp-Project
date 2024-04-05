using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2608
{
    class Class1
    {
        private int balance;
        private int withdraw;
        public int total;
        
        public void balanceSet(int bal)  // setBalance
        {
            balance = bal;
        }
        public void withdrawSet(int with)
        {
            withdraw = with;
        }
        public void totalSet(int tot)
        {
            total = tot;
            
            
        }
        public int balanceGet()
        {
            return balance;
        }
        public int withdrawGet()
        {
            return withdraw;
        }
        public int getTotal()
        {
            return total;
        }
        public int totalGet()
        {
            total = balance - withdraw;
            
            return total;


        }
        public string showDetail()
        {
           
            string str = "";
            str = "ยอดเงิน :" + balanceGet() + " บาท \n ถอนจำนวน " + 
                withdrawGet() + " บาท \n คงเหลือ " + totalGet() + " บาท";
           
            return str;
        }


    }
}
