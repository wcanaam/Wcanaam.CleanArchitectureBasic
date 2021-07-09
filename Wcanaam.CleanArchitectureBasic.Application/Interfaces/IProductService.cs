using System.Collections.Generic;
using System.Threading.Tasks;
using Wcanaam.CleanArchitectureBasic.Application.DTOs;

namespace Wcanaam.CleanArchitectureBasic.Application.Interfaces {
    public interface IProductService {

        Task<IEnumerable<ProductDTO>> Products();

        Task<ProductDTO> ProductsCategory(int? id);

        Task<ProductDTO> GetById(int? id);

        Task Add(ProductDTO ProductDto);

        Task Alter(ProductDTO ProductDto);

        Task Remove(int? id);
    }
}
