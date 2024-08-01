using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        [Fact]
        public void TestarMetodoSomar()
        {
            // Arrangw: Organizar
            var x1 = 4.2;
            var x2 = 7.8;
            var value = 12;

            // Act: Agir
            var soma = Calculo.Somar(x1, x2);


            // Assert:Provar
            Assert.Equal(value, soma);
        }

        [Fact]
        public void TestarMetodoSubtrair()
        {
            var x1 = 15;
            var x2 = 8;
            var value = 7;

            var subtracao = Calculo.Subtrair(x1, x2);

            Assert.Equal(value, subtracao);
        }

        [Fact]
        public void TestarMetodoMultiplicar()
        {
            var x1 = 3;
            var x2 = 4;
            var value = 12;

            var multiplicacao = Calculo.Multiplicar(x1, x2);

            Assert.Equal(value, multiplicacao);
        }

        [Fact]
        public void TestarMetodoDividir()
        {
            var x1 = 20;
            var x2 = 5;
            var value = 4;

            var divisao = Calculo.Dividir(x1, x2);

            Assert.Equal(value, divisao);
        }
    }
}
