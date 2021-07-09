using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Wcanaam.CleanArchitectureBasic.Application.DTOs;
using Wcanaam.CleanArchitectureBasic.Application.Interfaces;

namespace Wcanaam.CleanArchitectureBasic.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase {

        private readonly IProductService _productService;

        public ProductController(IProductService productService) {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> GetAll() {

            return _productService.Products().Result;
        }

        [HttpGet("{id}")]
        public ProductDTO GetById(int id) {

            return _productService.GetById(id).Result;
        }

        [HttpGet("/GetByCategory")]
        public ProductDTO GetByCategory(int id) {

            return _productService.ProductsCategory(id).Result;
        }

        [HttpPost]
        public void Post(ProductDTO ProductDto) {

            _productService.Add(ProductDto);
        }

        [HttpPut("{id}")]
        public void Put(ProductDTO ProductDto) {

            _productService.Alter(ProductDto);
        }

        [HttpDelete("{id}")]
        public void Delete(int id) {

            _productService.Remove(id);
        }
    }
}
