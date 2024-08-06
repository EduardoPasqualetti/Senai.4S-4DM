using Moq;
using ProductAPI.Domains;
using ProductAPI.Interfaces;

namespace testApi
{
    public class ProductsTest
    {
        //Indica que o metodo e de teste de unidade
        [Fact]
        public void Get()
        {
            //Arranger : Organizar

            var products = new List<Products>
            {
                new Products {IdProduct = Guid.NewGuid() , Name = "Produto 1", Price= 10},
                new Products {IdProduct = Guid.NewGuid() , Name = "Produto 2", Price= 20},
                new Products {IdProduct = Guid.NewGuid() , Name = "Produto 3", Price= 30},
                new Products {IdProduct = Guid.NewGuid() , Name = "Produto 4", Price= 40},
            };

            //Cria um obj de simulacao do tipo IProductRepository
            var mockRepository = new Mock<IProductRepository>();

            //Configura o metodo Get para retornar a lista de produtos "mock"
            mockRepository.Setup(x => x.GetProducts()).Returns(products);

            //Act : Agir

            //Ele chama o metodo Get() e armazena o resultado em result
            var result = mockRepository.Object.GetProducts();

            //Assert : Provar

            //Prova se o resultado esperado e igual ao resultado obtido atraves da busca
            Assert.Equal(4, result.Count);
        }

        public void Post()
        {

            var productList = new List<Products>();

            Products newProduct = new Products { IdProduct = Guid.NewGuid(), Name = "Produto Novo", Price = 25 };

            var mockRepository = new Mock<IProductRepository>();

            mockRepository.Setup(x => x.AddProduct(It.IsAny<Products>())).Callback<Products>(p => productList.Add(p));

            mockRepository.Object.AddProduct(newProduct);

            Assert.Contains(newProduct, productList);

        }

        [Fact]
        public void Delete()
        {
            var productIdToDelete = Guid.NewGuid();
            var productList = new List<Products>
            {
                new Products {IdProduct = productIdToDelete, Name = "Produto 1", Price = 30},
            };

            var mockRepository = new Mock<IProductRepository>();

            var prod = productList.FirstOrDefault(x => x.IdProduct == productIdToDelete);

            mockRepository.Setup(x => x.Delete(It.IsAny<Guid>())).Callback<Guid>(id => productList.Remove(prod!));

            mockRepository.Object.Delete(productIdToDelete);

            Assert.DoesNotContain(prod, productList);
        }

        [Fact]
        public void GetById()
        {
            var productIdToGet = Guid.NewGuid();
            var productList = new List<Products>
            {
                new Products {IdProduct = productIdToGet, Name = "Produto 1", Price = 30},
            };

            var mockRepository = new Mock<IProductRepository>();

            mockRepository.Setup(x => x.GetById(It.IsAny<Guid>())).Returns<Guid>(id => productList.FirstOrDefault(p => p.IdProduct == id));

            var result = mockRepository.Object.GetById(productIdToGet);

            Assert.NotNull(result);
            Assert.Equal(productIdToGet, result!.IdProduct);
            Assert.Equal("Produto 1", result.Name);
            Assert.Equal(30, result.Price);
        }
    }
}