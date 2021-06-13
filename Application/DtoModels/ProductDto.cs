using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DtoModels
{
    public class ProductDto
    {       
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public string Title { get; set; }       
        public DateTime CreatedAt { get; set; }
        public CategoryDto Category { get; set; }
        public PromotionDto Promotion { get; set; }

        public static ProductDto From(Product product) => new()
        {
            Id = product.Id,
            Title = product.Title,
            Amount = product.Amount,
            Image = product.Image,
            CreatedAt = product.CreatedAt,
            Price = product.Price,
            Promotion = product.Promotion != null ? PromotionDto.From(product.Promotion) : null
        };

    }
}
