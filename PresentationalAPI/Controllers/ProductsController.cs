using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using MediatR;
using Application.Queries.ProductQueries;
using Application.DtoModels;
using Application.Commands.ProductCommands;

namespace PresentationalAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
        {
            var input = new GetAllProductsQuery();
            var productItems = await _mediator.Send(input);
            return Ok(productItems);
        }

        [HttpGet]
        [Route("promotions")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProductsWithPromotion()
        {
            var input = new GetAllProductsWithPromotionQuery();
            var productItems = await _mediator.Send(input);
            return Ok(productItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var input = new GetProductByIdQuery
            {
                Id = id
            };
            var productItem = await _mediator.Send(input);
            if (productItem == null)
            {
                return NotFound();
            }
            return Ok(productItem);
        }
        [HttpPost]
        public async Task<ActionResult<ProductDto>> AddProduct([FromBody] AddProductCommand command)
        {
            var product = await _mediator.Send(command);
            return Ok(product);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<ProductDto>> UpdateProduct(int id, [FromBody] UpdateProductCommand command)
        {
            command.Id = id;

            var product = await _mediator.Send(command);

            return Ok(product);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id, [FromBody] DeleteProductCommand command)
        {
            command.Id = id;

            var product = await _mediator.Send(command);

            return Ok(product);
        }

    }
}
