using Microsoft.EntityFrameworkCore;
using ProductAPI.Domains;

namespace ProductAPI.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE12-SALA21\\SQLEXPRESS; Database=TestProductApi;User Id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
                base.OnConfiguring(optionsBuilder);
            }


        }

    }
}
