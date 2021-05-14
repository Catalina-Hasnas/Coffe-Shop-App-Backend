using Application.Commands.OrderCommands;
using Application.DtoModels;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandHandlers.CreateOrderCommandHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, OrderDto>

    {
        private readonly IOrderRepo _orderRepository;

        public CreateOrderCommandHandler(IOrderRepo orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<OrderDto> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var newOrder = new Order();

            newOrder.OrderItems = request.OrderItems.Select(o => new OrderItem
            {
                ProductId = o.ProductId,
                Quantity = o.Quantity,
                UnitPrice = o.UnitPrice,
            }).ToList();
            
            newOrder.TotalPrice = request.OrderItems.Sum(o => o.UnitPrice * o.Quantity);

            newOrder.CreatedAt = DateTime.Now;

            newOrder.Client = new Client();

            await _orderRepository.AddOrder(newOrder);

            return OrderDto.From(newOrder);

        }

       
    }
}
