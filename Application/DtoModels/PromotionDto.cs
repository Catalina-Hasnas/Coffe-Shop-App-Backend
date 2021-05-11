using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DtoModels
{
    public class PromotionDto
    {
        public float Discount { get; set; }
        public string PromotionalText { get; set; }
        public virtual ProductDto Product { get; set; }
    }
}
