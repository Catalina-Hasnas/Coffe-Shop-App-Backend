using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public interface IProductsRepo
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
    }
}
