using Application.DtoModels;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application
{
    public interface IOrderRepo
    {
        public Task<Order> AddOrder(Order order);
        //void UpdateOrder(OrderDto order);
        //void DeleteOrder(OrderDto order);
        
    }
}
