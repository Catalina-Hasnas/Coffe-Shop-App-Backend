using Application;
using Application.DtoModels;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductsRepo: IProductsRepo
    {
        protected readonly ECommerceDbContext _context;
        public ProductsRepo(ECommerceDbContext context)
        {
            _context = context;
        }

        public IQueryable<Product> Read() => _context.Set<Product>();

        public async Task<Product> AddProduct(Product product)
        {
            var newProduct = await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return newProduct.Entity;
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
        }

        public void UpdateProduct(Product product)
        {
             _context.Products.Update(product);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products
                        .Include( p => p.Category )
                        .Include( p => p.Promotion)
                        .DefaultIfEmpty()
                        .ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products
                        .Include(p => p.Category)
                        .Include(p => p.Promotion)
                        .DefaultIfEmpty()
                        .FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsWithPromotion()
        {
            //var categoryInfo = _context.Products
            //            .Include(p => p.Category)
            //            .Include(p => p.Promotion)
            //            .GroupBy(x => x.CategoryId)
            //            .Select(x => new
            //            {
            //                Name = x.Key,
            //                AveragePrice = x.Average(y => y.Price),
            //                ProductCount = x.Count()
            //            })
            //            .Where(x => x.ProductCount >= 1)
            //            .ToList();

            //Console.WriteLine(categoryInfo);

            //var categoryInfo2 = _context.Categories
            //            .Include(c => c.Products)
            //            .ToList()
            //            .GroupJoin(
            //                _context.Products,
            //                c => c.Id,
            //                p => p.CategoryId,
            //                (category, products) => new
            //                {
            //                    Name = category.Name,
            //                    AveragePrice = products.Average(x => x.Price),
            //                    ProductCount = products.Count(),
            //                    ProductNames = products.Select(p => p.Title).ToList()
            //                }
            //              ).ToList();

            //Console.WriteLine(categoryInfo2);

            //var categoryInfo3 = _context.Categories
            //                .Include(c => c.Products)
            //                .Where(c => c.Products.All(p => p.Promotion == null))
            //                .ToList();
            //Console.WriteLine(categoryInfo3);

            //var categoryInfo4 = _context.Categories
            //                .Include(c => c.Products)
            //                .Where(c => c.Products.Any(p => p.Promotion != null))
            //                .ToList();
            //Console.WriteLine(categoryInfo4);

            //var productPriceInfo5 = _context.Products
            //                .Include(p => p.Promotion)
            //                .Select(p => new
            //                {
            //                    OriginalPrice = p.Price,
            //                    RealPrice = p.Promotion == null ? p.Price : p.Price - p.Promotion.Discount,
            //                    ProductId = p.Id

            //                })
            //                .ToList();

            //Console.WriteLine(productPriceInfo5);


            return await _context.Products
                        .Include(p => p.Category)
                        .Include(p => p.Promotion)
                        .Where(p => p.Promotion != null)
                        .ToListAsync();
        }
    }
}

