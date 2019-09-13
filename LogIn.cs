using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advisor
{
    static class LogIn
    {
        static public List<User> users = new List<User>();
        //patikrina ar suvesti duomenys teisingi
        public static bool Confirmation(string email, string password)
        {
            foreach( var User in users)
            {
                if (User.Email.Equals(email) && User.Password.Equals(password)) return true;
            }
            return false;

        }
    }
}
