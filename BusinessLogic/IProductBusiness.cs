using Amdaris_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amdaris_Backend.BusinessLogic
{
    public interface IProductBusiness
    {
        IList<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
