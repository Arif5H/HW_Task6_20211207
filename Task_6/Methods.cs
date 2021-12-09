using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
   internal class Methods
    {
        public string username;
        public string password;

        public string UserName
        {
            get
            {
                return username;
            }
            set
            {  
                username = value;
                if (username.Length < 5)
                {
                    throw new Exception($"Username {username} should consist at least of 5 symbols");
                    
                }
            }
        }public string Password
        {
            get
            {
                return username;
            }
            set
            {
                password = value;
                if (password.Length < 8)
                {
                    throw new Exception($"Password {password} should consist as least of 8 symbols");

                }
            }
        }

        public bool Login()
        {   
            if (username == "ArifHH" && password == "F14us4Ever" )
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
       

    }
}
