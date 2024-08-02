using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Test
{
    public class LivroTest
    {
        [Fact]
        public void TestMethodCheckBook()
        {
            var book = "pequeno principe";
            var quantityOfBook = Livro.GetBookQuantity();
            var expectedBooks = quantityOfBook + 1;
            var quantityAfterAdd = Livro.AddBook(book);

            Assert.Equal(expectedBooks, quantityAfterAdd);
        }
    }
}
