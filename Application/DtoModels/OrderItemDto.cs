using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DtoModels
{
    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }

        public static OrderItemDto From(OrderItem orderItem) => new()
        {
            ProductId = orderItem.ProductId,
            UnitPrice = orderItem.UnitPrice,
            Quantity = orderItem.Quantity,
        };

    }
}
