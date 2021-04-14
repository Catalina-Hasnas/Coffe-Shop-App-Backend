using Amdaris_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amdaris_Backend.Data
{
    public class MockProductsRepo : IProductsRepo
    {
        public IEnumerable<Product> GetAppProducts()
        {
            var products = new List<Product>
            {
            new Product { Id = 1, Amount = 5, Image = "https://via.placeholder.com/320x280", Price = 200, PriceFormatted = "200$", Title = "First Product" },
            new Product { Id = 2, Amount = 6, Image = "https://via.placeholder.com/320x280", Price = 210, PriceFormatted = "210$", Title = "Second Product" },
            new Product { Id = 3, Amount = 6, Image = "https://via.placeholder.com/320x280", Price = 220, PriceFormatted = "220$", Title = "Third Product" }
            };

            return products;
        }

        public Product GetProductById(int id)
        {
            return new Product { Id = 1, Amount = 5, Image = "https://via.placeholder.com/320x280", Price = 200, PriceFormatted = "200$", Title = "First Product" };

        }
    }
}
