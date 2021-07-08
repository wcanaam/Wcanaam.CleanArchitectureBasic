using System.Collections.Generic;
using System.Threading.Tasks;
using Wcanaam.CleanArchitectureBasic.Domain.Entities;

namespace Wcanaam.CleanArchitectureBasic.Domain.Interfaces {
    public interface ICategoryRepository {

        Task <IEnumerable<Category>> CategoriesAsync();

        Task<Category> GetByIdAsync(int? id);

        Task<Category> CreateAsync(Category category);

        Task<Category> UpdateAsync(Category category);

        Task<Category> DeleteAsync(Category category);




    }
}
