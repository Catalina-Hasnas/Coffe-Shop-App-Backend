using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DtoModels
{
    public class PromotionDto
    {
        public int Id { get; set; }
        public float Discount { get; set; }
        public string PromotionalText { get; set; }
        public static PromotionDto From(Promotion promotion) => new()
        {
            Discount = promotion.Discount,
            PromotionalText = promotion.PromotionalText,
            Id = promotion.Id
        };


    }
}
