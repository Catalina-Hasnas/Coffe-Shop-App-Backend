using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class OrderRepo : IOrderRepo
    {
        protected readonly ECommerceDbContext _context;
        public OrderRepo(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddOrder(Order order)
        {
            await _context.Orders.AddAsync(order);
            return await _context.SaveChangesAsync();
        }

        public void DeleteOrder(Order order)
        {
            _context.Orders.Remove(order);
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
        }

        public Task SaveChanges()
        {
            return _context.SaveChangesAsync();
        }

        
    }
}
