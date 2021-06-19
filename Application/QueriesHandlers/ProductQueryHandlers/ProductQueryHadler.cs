using Application.DtoModels;
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
    public class ProductQueryHadler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductDto>>, 
                                      IRequestHandler<GetProductByIdQuery, ProductDto>,
                                      IRequestHandler<GetAllProductsWithPromotionQuery, IEnumerable<ProductDto>>
    {
        private readonly IProductsRepo _productRepository;

        public ProductQueryHadler(IProductsRepo productRepository) 
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetAllProducts();
            
            return result.Select(p => new ProductDto
                         {
                            Id = p.Id,
                            Amount = p.Amount,
                            Image = p.Image,
                            Price = p.Price,
                            Title = p.Title,
                            CreatedAt = p.CreatedAt,
                            Category = new CategoryDto 
                            {
                                Id = p.Category.Id,
                                Name = p.Category.Name
                            },
                            Promotion = p.Promotion == null ? null : new PromotionDto
                            {
                                Discount = p.Promotion.Discount,
                                PromotionalText = p.Promotion.PromotionalText
                            }
                        }).ToList();
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetProductById(request.Id);

            return result == null ? null : new ProductDto {
                Id = result.Id,
                Amount = result.Amount,
                Image = result.Image,
                Price = result.Price,
                Title = result.Title,
                CreatedAt = result.CreatedAt,
                Category = new CategoryDto
                {
                    Id = result.Category.Id,
                    Name = result.Category.Name
                },
                Promotion = result.Promotion == null ? null : new PromotionDto
                {
                    Id = result.Promotion.Id,
                    Discount = result.Promotion.Discount,
                    PromotionalText = result.Promotion.PromotionalText
                }
            };
        }
        public async Task<IEnumerable<ProductDto>> Handle(GetAllProductsWithPromotionQuery request, CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetAllProductsWithPromotion();

            return result.Select(p => new ProductDto
            {
                Id = p.Id,
                Amount = p.Amount,
                Image = p.Image,
                Price = p.Price,
                Title = p.Title,
                CreatedAt = p.CreatedAt,
                Category = new CategoryDto
                {
                    Id = p.Category.Id,
                    Name = p.Category.Name
                },
                Promotion = new PromotionDto
                {
                    Discount = p.Promotion.Discount,
                    PromotionalText = p.Promotion.PromotionalText
                }

            }).ToList();
        }
    }
}
