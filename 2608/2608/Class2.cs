using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2608
{
    class Class2 : Class1
    {
        private string user;
        private int id;

        public void setUser(string us)
        {
            user = us;
        }
        public void setID(int ID)
        {
           id = ID;
        }
        public string getuser()
        {
           
            return user;
        }
        public int getID()
        {
            return id;
        }
        
        public string showPrivateDetail()
        {
            string pristr = "";
            pristr = "User : " +user+ "\nID : " +id;
            return pristr;
        }
        
    }
}
