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
        public void AdicionarLivro()
        {
          
            Livro.LimparLivros();
            string livro = "Dom Quixote";

            Livro.AdicionarLivro(livro);
            List<string> livros = Livro.ObterLivros();

            Assert.Contains(livro, livros);
        }
    }
}
