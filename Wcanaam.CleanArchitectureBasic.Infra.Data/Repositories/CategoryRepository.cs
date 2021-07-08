using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wcanaam.CleanArchitectureBasic.Domain.Entities;
using Wcanaam.CleanArchitectureBasic.Domain.Interfaces;
using Wcanaam.CleanArchitectureBasic.Infra.Data.Context;

namespace Wcanaam.CleanArchitectureBasic.Infra.Data.Repositories {
    public class CategoryRepository : ICategoryRepository {

        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context) {
            _context = context;
        }

        public async Task<Category> CreateAsync(Category category) {

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> DeleteAsync(Category category) {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateAsync(Category category) {

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<Category>> CategoriesAsync() {

            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int? id) {

            return await _context.Categories.FindAsync(id);
        }

    }
}
