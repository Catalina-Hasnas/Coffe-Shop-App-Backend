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
            new Product { Id = 1, Amount = 5, Image = "https://i.ibb.co/6bgccSg/212.jpg", Price = 200, PriceFormatted = "200$", Title = "First Product", CreatedAt = DateTime.Now },
                new Product { Id = 2, Amount = 6, Image = "https://i.ibb.co/KyQwzHG/21133206.jpg", Price = 210, PriceFormatted = "210$", Title = "Second Product", CreatedAt = DateTime.Now  },
                new Product { Id = 3, Amount = 6, Image = "https://i.ibb.co/kmctC6G/21256508.jpg", Price = 220, PriceFormatted = "220$", Title = "Third Product", CreatedAt = DateTime.Now  },
                new Product { Id = 4, Amount = 6, Image = "https://i.ibb.co/KNFCs43/cosmetic-40.jpg", Price = 220, PriceFormatted = "220$", Title = "Third Product", CreatedAt = DateTime.Now  },
                new Product { Id = 5, Amount = 6, Image = "https://i.ibb.co/r6N7p8M/jar-03.jpg", Price = 220, PriceFormatted = "220$", Title = "Third Product", CreatedAt = DateTime.Now  },
                new Product { Id = 6, Amount = 6, Image = "https://i.ibb.co/X2gYjMN/jar-13.jpg", Price = 220, PriceFormatted = "220$", Title = "Third Product", CreatedAt = DateTime.Now  },
                new Product { Id = 7, Amount = 6, Image = "https://i.ibb.co/hcRbLBg/jar-24.jpg", Price = 220, PriceFormatted = "220$", Title = "Third Product", CreatedAt = DateTime.Now  },
                new Product { Id = 8, Amount = 6, Image = "https://i.ibb.co/mCMyJHD/jar-25.jpg", Price = 220, PriceFormatted = "220$", Title = "Third Product", CreatedAt = DateTime.Now  },
                new Product { Id = 9, Amount = 6, Image = "https://i.ibb.co/qJVPFxJ/jar-36.jpg", Price = 220, PriceFormatted = "220$", Title = "Third Product", CreatedAt = DateTime.Now  },
        };

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

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

        
