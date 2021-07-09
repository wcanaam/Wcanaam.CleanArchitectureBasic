using System.Collections.Generic;
using System.Threading.Tasks;
using Wcanaam.CleanArchitectureBasic.Application.DTOs;

namespace Wcanaam.CleanArchitectureBasic.Application.Interfaces {
    public interface ICategoryService {

        //Retornando uma lista de categoryDTO | na implementação esse método será assíncrono
        Task<IEnumerable<CategoryDTO>> Categories();

        Task<CategoryDTO> GetById(int? id);

        Task Add(CategoryDTO categoryDto);

        Task Remove(int? id);

        Task Alter(CategoryDTO categoryId);




    }
}
