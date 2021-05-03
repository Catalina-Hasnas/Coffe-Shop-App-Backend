using Application.DtoModels;
using Application.Queries.CategoriesQueries;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueriesHandlers.CategoryQueryHandlers
{
    public class CategoryQueryHadler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<CategoryDto>>, IRequestHandler<GetCategoryByIdQuery, Category>
    {
        private readonly ICategoriesRepo _categoryRepository;

        public CategoryQueryHadler(ICategoriesRepo categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<CategoryDto>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var result = await _categoryRepository.GetAllCategories();

            return result.Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name,
                Products = c.Products.Select(p => new ProductDto
                {
                    Id = p.Id,
                    Amount = p.Amount,
                    Image = p.Image,
                    Title = p.Title,
                    CreatedAt = p.CreatedAt,
                    Category = new CategoryDto{
                        Id = c.Id,
                        Name = c.Name
                    }
                }).ToList()
            }).ToList();
        }

        public async Task<Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _categoryRepository.GetCategoryById(request.Id);
            return await Task.FromResult(result);
        }
        
    }
}

