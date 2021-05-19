using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Application.DtoModels
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<ProductDto> Products { get; set; }

        public static CategoryDto From(Category category) => new()
        {
            Id = category.Id,
            Name = category.Name,
            Products = category.Products.Select(ProductDto.From).ToList()
        };
    }
}
