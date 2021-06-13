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
            return await _context.Products
                        .Include(p => p.Category)
                        .Include(p => p.Promotion)
                        .Where(p => p.Promotion != null)
                        .ToListAsync();
        }
    }
}

