using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IOrderRepo
    {
        public Task<int> AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        Task SaveChanges();
    }
}
