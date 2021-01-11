using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlineProject
{
    public class AdminLogin
    {
        public static bool Login(string username,string password)
        {
            if(username.Equals("admin",StringComparison.OrdinalIgnoreCase) && password.Equals("adminpass"))
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