using Microsoft.EntityFrameworkCore;
using ProductsMVC.Models;

namespace ProductsMVC.Data
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
