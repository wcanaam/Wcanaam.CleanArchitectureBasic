using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Wcanaam.CleanArchitectureBasic.Application.DTOs;
using Wcanaam.CleanArchitectureBasic.Application.Interfaces;

namespace Wcanaam.CleanArchitectureBasic.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase {

        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService) {

            _categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<CategoryDTO> GetAll() {

            return _categoryService.Categories().Result;

        }

        [HttpGet("{id}")]
        public CategoryDTO GetById(int id) {

            var result = _categoryService.GetById(id).Result;
            return result;
        }

        [HttpPost]
        public void Post([FromBody] CategoryDTO categoryDto) {

            _categoryService.Add(categoryDto);
        }

        [HttpPut]
        public void Put([FromBody] CategoryDTO categoryDto) {

            _categoryService.Alter(categoryDto);
        }

        [HttpDelete("{id}")]
        public void Delete(int id) {
            _categoryService.Remove(id);


        }

    }
}
