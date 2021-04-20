using Application.Queries.ProductQueries;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueriesHandlers.ProductQueryHandlers
{
    public class ProductQueryHadler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>, IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductsRepo _productRepository;

        public ProductQueryHadler(IProductsRepo productRepository) 
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var result = _productRepository.GetAllProducts();
            return await Task.FromResult(result); 
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _productRepository.GetProductById(request.Id);
            return await Task.FromResult(result);
        }
    }
}
