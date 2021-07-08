using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wcanaam.CleanArchitectureBasic.Domain.Entities;
using Wcanaam.CleanArchitectureBasic.Domain.Interfaces;
using Wcanaam.CleanArchitectureBasic.Infra.Data.Context;

namespace Wcanaam.CleanArchitectureBasic.Infra.Data.Repositories {
    public class ProductRepository : IProductRepository {

        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context) {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product product) {

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> DeleteAsync(Product product) {

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsync(Product product) {

            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> ProductsCategoryAsync(int? id) {

            return await _context.Products.Include(c => c.Category).SingleOrDefaultAsync(p => p.Id == id); 
                
        }

        public async Task<IEnumerable<Product>> ProductsAsync() {

            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int? id) {

            return await _context.Products.FindAsync(id);
        }
    }
}
