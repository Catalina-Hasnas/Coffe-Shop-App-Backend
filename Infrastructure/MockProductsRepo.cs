using Application;
using Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure
{
    public class MockProductsRepo : IProductsRepo
    {
        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>
            {
            new Product { Id = 1, Amount = 5, Image = "https://via.placeholder.com/320x280", Price = 200, PriceFormatted = "200$", Title = "First Product", CreatedAt = DateTime.Now },
            new Product { Id = 2, Amount = 6, Image = "https://via.placeholder.com/320x280", Price = 210, PriceFormatted = "210$", Title = "Second Product", CreatedAt = DateTime.Now  },
            new Product { Id = 3, Amount = 6, Image = "https://via.placeholder.com/320x280", Price = 220, PriceFormatted = "220$", Title = "Third Product", CreatedAt = DateTime.Now  }
            };

            return products;
        }

        public Product GetProductById(int id)
        {
            // to implement
            // extension method singleOrDefault
            return new Product { Id = 1, Amount = 5, Image = "https://via.placeholder.com/320x280", Price = 200, PriceFormatted = "200$", Title = "First Product", CreatedAt = DateTime.Now };
        }
    }
}

        
