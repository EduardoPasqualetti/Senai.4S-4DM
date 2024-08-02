using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class Livro
    {
        private static List<string> books = new List<string>();
         public static int GetBookQuantity()
        {
            return books.Count;
        }

        public static int AddBook(string book)
        {
            books.Add(book);
            return books.Count;
        }
    }
}
