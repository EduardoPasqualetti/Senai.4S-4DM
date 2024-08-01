using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Test
{
    public class TemperaturaTest
    {
        [Theory]
        [InlineData(0, 32)]
        [InlineData(100, 212)]
        [InlineData(-40, -40)]
        [InlineData(37, 98.6)]
        public void ConverterCelsiusParaFahrenheit_DeveConverterCorretamente(double celsius, double expectedFahrenheit)
        {
            double result = Temperatura.ConverterCelsiusParaFahrenheit(celsius);

            Assert.Equal(expectedFahrenheit, result, 1);
        }
    }
}
