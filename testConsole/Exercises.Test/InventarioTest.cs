using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Test
{
    public class InventarioTest
    {
        [Fact]
        public static void TestMethodAddProduct()
        {
            string product = "Caneta";

            int firstQuantity = 10;
            Inventario.AddProduct(product, firstQuantity);

            int secondQuantity = 5;
            Inventario.AddProduct(product, secondQuantity);

            int totalQuantity = Inventario.GetProductsQuantity(product);

            Assert.Equal(firstQuantity + secondQuantity, totalQuantity);
        }
    }
}
