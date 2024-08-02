using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Test
{
    public class EmailTest
    {
        [Theory]
        [InlineData("eduardo@gmail.com")]
        public void TestMethodValidateEmail(string email)
        {
            bool expected = true;
            bool result = Email.ValidateEmail(email);
            Assert.Equal(expected, result);
        }
    }
}
