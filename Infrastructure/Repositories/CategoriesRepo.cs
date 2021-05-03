using Application;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CategoriesRepo : ICategoriesRepo
    {
        protected readonly ECommerceDbContext _context;
        public CategoriesRepo(ECommerceDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category Category)
        {
            _context.Add(Category);
        }

        public void DeleteCategory(Category Category)
        {
            _context.Remove(Category);
        }

        public void UpdateCategory(Category Category)
        {
            _context.Update(Category);
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _context.Categories
                        .Include((p) => p.Products)
                        .ToListAsync();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }


    }
}
