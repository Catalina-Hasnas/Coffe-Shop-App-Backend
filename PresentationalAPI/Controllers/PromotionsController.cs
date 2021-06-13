using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using MediatR;
using Application.Queries.ProductQueries;
using Application.DtoModels;
using Application.Commands.ProductCommands;
using Application.Queries.PromotionsQueries;

namespace PresentationalAPI.Controllers
{
    [Route("api/promotions")]
    [ApiController]
    public class PromotionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PromotionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PromotionDto>>> GetAllPromotions()
        {
            var input = new GetAllPromotionsQuery();
            var promotions = await _mediator.Send(input);
            return Ok(promotions);
        }

  

    }
}
