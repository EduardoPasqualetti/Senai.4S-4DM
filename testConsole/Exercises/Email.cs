using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class Email
    {
        public static bool ValidateEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            return false;
        }
    }
}
