using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wcanaam.CleanArchitectureBasic.Application.DTOs;
using Wcanaam.CleanArchitectureBasic.Application.Interfaces;
using Wcanaam.CleanArchitectureBasic.Domain.Entities;
using Wcanaam.CleanArchitectureBasic.Domain.Interfaces;

namespace Wcanaam.CleanArchitectureBasic.Application.Services {

    public class CategoryService : ICategoryService {

        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository) {

            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task Add(CategoryDTO categoryDto) {

            var category = _mapper.Map<Category>(categoryDto);

            await _categoryRepository.CreateAsync(category);
        }

        public async Task Alter(CategoryDTO categoryDto) {

            var category = _mapper.Map<Category>(categoryDto);

            await _categoryRepository.UpdateAsync(category);

        }

        public async Task Remove(int? id) {

            var categoryId = _categoryRepository.GetByIdAsync(id).Result;

            await _categoryRepository.DeleteAsync(categoryId);
            
        }

        public async Task<IEnumerable<CategoryDTO>> Categories() {

            var categories = await _categoryRepository.CategoriesAsync();

            return _mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }

        public async Task<CategoryDTO> GetById(int? id) {

            var category = await _categoryRepository.GetByIdAsync(id);

            return _mapper.Map<CategoryDTO>(category);
        }

    }
}
