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
    public class CategoryQueryHadler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<Category>>, IRequestHandler<GetCategoryByIdQuery, Category>
    {
        private readonly ICategoriesRepo _categoryRepository;

        public CategoryQueryHadler(ICategoriesRepo categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var result = _categoryRepository.GetAllCategories();
            return await Task.FromResult(result);
        }

        public async Task<Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _categoryRepository.GetCategoryById(request.Id);
            return await Task.FromResult(result);
        }
    }
}
