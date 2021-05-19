using Application.DtoModels;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public interface IProductsRepo
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        IQueryable<Product> Read();
        Task<Product> AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        Task<IEnumerable<Product>> GetAllProductsWithPromotion();
        Task Save();
    }
}
