using Application;
using Domain;
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

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }


    }
}
