using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Test
{
    public class EmailTest
    {
        [Theory]
        [InlineData("teste@dominio.com", true)]
        [InlineData("teste@dominio", false)]
        [InlineData("testedominiocom", false)]
        [InlineData("teste@dominio.com.br", true)]
        public void ValidarEmail_DeveRetornarSeEmailEhValido(string email, bool expected)
        {    
            bool result = Email.ValidarEmail(email);
            Assert.Equal(expected, result);
        }
    }
}
