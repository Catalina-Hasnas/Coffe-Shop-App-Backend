using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DtoModels;
using Domain;

namespace Application
{
    public interface IOrderItemRepo
    {
        void AddOrderItem(OrderItem order);

    }
}
