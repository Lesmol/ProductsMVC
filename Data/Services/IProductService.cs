using Microsoft.AspNetCore.Mvc;
using ProductsMVC.Models;

namespace ProductsMVC.Data.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product?> GetById(int id);
        Task<Product> GetProduct(int id);
        Task <IEnumerable<Product>> GetFirst8();
        Task AddProduct(Product product);
        Task DeleteProduct(Product product);
        Task EditProduct(Product product);
        bool ProductExists(int id);
    }
}
