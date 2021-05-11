using Application.Commands.OrderCommands;
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
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>

    {
        private readonly IOrderRepo _orderRepository;

        public CreateOrderCommandHandler(IOrderRepo orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var newOrder = new Order();
            newOrder.OrderItems = request.OrderItems.Select(o => new OrderItem
            {
                Order = newOrder,
                ProductId = o.ProductId,
                Quantity = o.Quantity,
                UnitPrice = o.UnitPrice,
            }).ToList();
            newOrder.Client = new Client();

            return await _orderRepository.AddOrder(newOrder);
        }
    }
}
