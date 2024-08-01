using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class Email
    {
        public static bool ValidarEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}
