using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DtoModels
{
    public class OrderDto
    {
        public int Id { get; set; }
        public virtual List<OrderItemDto> OrderItems { get; set; }
        public DateTime CreatedAt { get; set; }
        public float TotalPrice { get; set; }

		public static OrderDto From(Order order) => new()
		{
			Id = order.Id,
			OrderItems = order.OrderItems.Select(OrderItemDto.From).ToList(),
			TotalPrice = order.TotalPrice,
			CreatedAt = order.CreatedAt,
		};


	}
}
