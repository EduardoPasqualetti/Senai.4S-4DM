using System.Collections.Generic;

namespace Exercises
{
    public class Inventario
    {
        private static Dictionary<string, int> products = new Dictionary<string, int>();

        public static  void AddProduct(string name, int quantity)
        {
            if (products.ContainsKey(name))
            {
                products[name] += quantity;
            }
            else
            {
                products[name] = quantity;
            }
        }
        public static int GetProductsQuantity(string name)
        {
            return products.ContainsKey(name) ? products[name] : 0;
        }

    }
}
