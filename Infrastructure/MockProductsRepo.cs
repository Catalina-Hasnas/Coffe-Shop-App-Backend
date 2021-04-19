using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure
{
    public class MockProductsRepo : IProductsRepo
    {
        private List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Amount = 5, Image = "https://via.placeholder.com/320x280", Price = 200, PriceFormatted = "200$", Title = "First Product", CreatedAt = DateTime.Now },
            new Product { Id = 2, Amount = 6, Image = "https://via.placeholder.com/320x280", Price = 210, PriceFormatted = "210$", Title = "Second Product", CreatedAt = DateTime.Now  },
            new Product { Id = 3, Amount = 6, Image = "https://via.placeholder.com/320x280", Price = 220, PriceFormatted = "220$", Title = "Third Product", CreatedAt = DateTime.Now  }
            };
    
        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}

        
