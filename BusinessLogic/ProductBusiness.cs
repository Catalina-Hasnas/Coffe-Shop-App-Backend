using Amdaris_Backend.Data;
using Amdaris_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amdaris_Backend.BusinessLogic
{
    public class ProductBusiness: IProductBusiness
    {
        private readonly IProductsRepo _repository;

        public ProductBusiness(IProductsRepo repository)
        {
            _repository = repository;
        }

        public IList<Product> GetAllProducts()
        {
            return _repository.GetAllProducts().ToList();
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        
    }
}
