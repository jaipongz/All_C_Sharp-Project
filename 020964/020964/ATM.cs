using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020964
{
    class ATM
    {
        private double balance =  0;
        private double diposit;
        private double withdraw;
        private double total = 0;


        public void setBalance(double bal)
        {
            balance = bal;
        }
        public void setDiposit(double dip)
        {
            diposit = dip;
        }
        public void setWithdraw(double with)
        {
            withdraw = with;
        }
        public void setTotal(double tot)
        {
            total = tot;
        }
        public double getBalance()
        {
            return balance;
        }
        public double getDiposit()
        {
            
            return diposit;
        }
        public double getWithdraw()
        {
            
            return withdraw;
        }
        public double getWithTotal()
        {
            total = balance - withdraw;
            return total;
        }
        public double getDipTotal()
        {
            
            return total;
        }
        public double getTotal()
        {
            return total;
        }
        public string showTotal()
        {
            string str = "" ;
            str = getTotal() +"";
            return str;
        }
    }
}
