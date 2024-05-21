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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductName = "Sofa",
                    ProductDescription = "A comfortable leather sofa.",
                    ProductCategory = "Furniture",
                    ProductPrice = 77799,
                    Stock = 20,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmIBbr4w8OezGJUO4RNdSHAlCcpb5oOWaGWmOSl_hiXxVqexb66Cn96MbuIeeJuOhilbg&usqp=CAU"
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Dining Table",
                    ProductDescription = "A large wooden dining table.",
                    ProductCategory = "Furniture",
                    ProductPrice = 14499,
                    Stock = 15,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBFP2r7X9qypxSQAYEdg-ix2PhJQ0RZssSRjVcJfPEVQ&s"
                },
                new Product
                {
                    Id = 3,
                    ProductName = "Bed Frame",
                    ProductDescription = "A king-size bed frame with storage.",
                    ProductCategory = "Furniture",
                    ProductPrice = 7299,
                    Stock = 10,
                    ImageUrl = "https://images.ctfassets.net/5de70he6op10/5GwtnJTWNaVv6t7kD57WTI/85db8cf22797709a8a4184236c699b1c/581937399-furniture_gateway_ls_01_d.jpg"
                },
                new Product
                {
                    Id = 4,
                    ProductName = "Bookshelf",
                    ProductDescription = "A tall wooden bookshelf.",
                    ProductCategory = "Furniture",
                    ProductPrice = 1999,
                    Stock = 30,
                    ImageUrl = "https://m.media-amazon.com/images/I/71lmFBWhE-L.jpg"
                },
                new Product
                {
                    Id = 5,
                    ProductName = "Coffee Table",
                    ProductDescription = "A modern glass coffee table.",
                    ProductCategory = "Furniture",
                    ProductPrice = 15999,
                    Stock = 25,
                    ImageUrl = "https://contentgrid.homedepot-static.com/hdus/en_US/DTCCOMNEW/Articles/best-furniture-for-your-home-2022-section-1.jpg"
                }
            );
        }
    }
}
