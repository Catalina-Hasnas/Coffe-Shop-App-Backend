﻿using Application;
using Application.DtoModels;
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

        public async Task<Order> AddOrder(Order order)
        {
            var newOrder = await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return newOrder.Entity;
        }

        //public void DeleteOrder(Order order)
        //{
        //    _context.Orders.Remove(order);
        //}

        //public void UpdateOrder(Order order)
        //{
        //    _context.Orders.Update(order);
        //}

    }
}
