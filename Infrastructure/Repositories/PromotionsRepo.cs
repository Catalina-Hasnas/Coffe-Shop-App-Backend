using Application;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Repositories
{
    public class PromotionsRepo : IPromotionsRepo
    {
        protected readonly ECommerceDbContext _context;
        public PromotionsRepo(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<Promotion> AddPromotion(Promotion promotion)
        {
            var newPromotion = await _context.Promotions.AddAsync(promotion);
            await _context.SaveChangesAsync();
            return newPromotion.Entity;
        }

        public void DeletePromotion(Promotion promotion)
        {
            _context.Promotions.Remove(promotion);
        }

        public async Task<IEnumerable<Promotion>> GetAllPromotions()
        {
            return await _context.Promotions.ToListAsync();
        }

        public IQueryable<Promotion> Read() => _context.Set<Promotion>();

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
