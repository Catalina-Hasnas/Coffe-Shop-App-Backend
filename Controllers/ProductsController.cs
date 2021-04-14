using Amdaris_Backend.Data;
using Amdaris_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amdaris_Backend.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepo _repository;

        public ProductsController(IProductsRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllCommands()
        {
            var productItems = _repository.GetAppProducts();
            return Ok(productItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetCommandById(int id)
        {
            var productItem = _repository.GetProductById(id);
            return Ok(productItem);
        }
    }
}
