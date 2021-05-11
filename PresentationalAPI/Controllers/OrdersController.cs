using Application.Commands.OrderCommands;
using Application.DtoModels;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(List<OrderItemDto> orderItems)
        {
            var input = new CreateOrderCommand()
            {
                OrderItems = orderItems
            };
            var productItem = await _mediator.Send(input);
            return Ok(productItem);
        }
    }
}
