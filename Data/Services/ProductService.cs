using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsMVC.Data;
using ProductsMVC.Models;

namespace ProductsMVC.Data.Services
{
    public class ProductService : IProductService
    {

        private readonly ProductsContext _context;

        public ProductService(ProductsContext context)
        {
            _context = context;
        }

        public async Task DeleteProduct(Product product)
        {
            _context
                .Products
                .Remove(product);

            await _context
                .SaveChangesAsync();
        }

        public async Task EditProduct(Product product)
        {
            _context
                .Update(product);

            await _context
                .SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var result = await _context
                .Products
                .ToListAsync();

            return result;
        }

        public async Task<Product?> GetById(int id)
        {
            var result = await _context
                .Products
                .FirstOrDefaultAsync(m => m.Id == id);

            return result;
        }

        public async Task<IEnumerable<Product>> GetFirst8()
        {
            var products = await _context
                .Products
                .Take(8)
                .ToListAsync();

			return products;
        }

        public async Task AddProduct(Product product)
        {
            _context
                .Add(product);

            await _context
                .SaveChangesAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context
                .Products
                .FindAsync(id);

            return product!;
        }

        public bool ProductExists(int id)
        {
            return _context
                .Products
                .Any(e => e.Id == id);
        }
    }
}
