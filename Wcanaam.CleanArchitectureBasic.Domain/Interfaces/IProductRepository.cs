using System.Collections.Generic;
using System.Threading.Tasks;
using Wcanaam.CleanArchitectureBasic.Domain.Entities;

namespace Wcanaam.CleanArchitectureBasic.Domain.Interfaces {
    public interface IProductRepository {

        //Sufixo Async nas assinaturas dos métodos, pois é uma recomendação
        Task<IEnumerable<Product>> ProductsAsync();

        Task<Product> GetByIdAsync(int? id);

        Task<Product> CreateAsync(Product product);

        Task<Product> UpdateAsync(Product product);

        Task<Product> DeleteAsync(Product product);
    }
}
