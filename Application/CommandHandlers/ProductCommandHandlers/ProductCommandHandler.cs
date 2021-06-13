using Application.Commands.ProductCommands;
using Application.DtoModels;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandHandlers.ProductCommandHandlers
{
    class ProductCommandHandler : 
        IRequestHandler<AddProductCommand, ProductDto>,
        IRequestHandler<UpdateProductCommand, ProductDto>,
        IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductsRepo _productsRepository;
        private readonly ICategoriesRepo _categoriesRepository;

        public ProductCommandHandler(IProductsRepo productsRepository, ICategoriesRepo categoriesRepository)
        {
            _productsRepository = productsRepository;
            _categoriesRepository = categoriesRepository;
        }

        public async Task<ProductDto> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            
            var newProduct = new Product
            {
                Amount = request.Amount,
                Image = request.Image,
                Price = request.Price,
                Title = request.Title,
                CreatedAt = DateTime.Now,
                CategoryId = request.CategoryId,
                PromotionId = request.PromotionId,
            };

            await _productsRepository.AddProduct(newProduct);

            return ProductDto.From(newProduct);

        }

        public async Task<ProductDto> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {

        var product = await _productsRepository
                                            .Read()
                                            .Include(p => p.Category)
                                            .Include(p => p.Promotion)
                                            .SingleOrDefaultAsync(p => p.Id == request.Id);

            product.Amount = request.Amount;
            product.Image = request.Image;
            product.Price = request.Price;
            product.Title = request.Title;
            product.CategoryId = request.CategoryId;
            product.PromotionId = request.PromotionId;

            _productsRepository.UpdateProduct(product);

            await _productsRepository.Save();

            return ProductDto.From(product);
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productsRepository.Read().FirstOrDefaultAsync(p => p.Id == request.Id);

            if (product != null)
            {
                _productsRepository.DeleteProduct(product);
            }
            await _productsRepository.Save();

            return Unit.Value;
        }
    }

    
}

