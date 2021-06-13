using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IPromotionsRepo
    {
        Task<IEnumerable<Promotion>> GetAllPromotions();
        IQueryable<Promotion> Read();
        Task<Promotion> AddPromotion(Promotion promotion);
        void DeletePromotion(Promotion promotion);
        Task Save();
    }
}
