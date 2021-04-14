using Amdaris_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amdaris_Backend.Data
{
    public interface IProductsRepo
    {
        IEnumerable<Product> GetAppProducts();
        Product GetProductById(int id);
    }
}
