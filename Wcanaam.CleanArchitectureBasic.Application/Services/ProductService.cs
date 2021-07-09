using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wcanaam.CleanArchitectureBasic.Application.DTOs;
using Wcanaam.CleanArchitectureBasic.Application.Interfaces;
using Wcanaam.CleanArchitectureBasic.Domain.Entities;
using Wcanaam.CleanArchitectureBasic.Domain.Interfaces;

namespace Wcanaam.CleanArchitectureBasic.Application.Services {
    public class ProductService : IProductService {

        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IMapper mapper, IProductRepository productRepository) {

            _mapper = mapper;
            _productRepository = productRepository ?? throw new ArgumentException(nameof(productRepository));
        }


        public async Task Add(ProductDTO ProductDto) {

            var product = _mapper.Map<Product>(ProductDto);

            await _productRepository.CreateAsync(product);
        }

        public async Task Alter(ProductDTO ProductDto) {

            var product = _mapper.Map<Product>(ProductDto);

            await _productRepository.UpdateAsync(product);
        }

        public async Task<ProductDTO> GetById(int? id) {

            return _mapper.Map<ProductDTO>(await _productRepository.GetByIdAsync(id));
        }

        public async Task<IEnumerable<ProductDTO>> Products() {

            return _mapper.Map<IEnumerable<ProductDTO>>(await _productRepository.ProductsAsync());
        }

        public async Task<ProductDTO> ProductsCategory(int? id) {
            return _mapper.Map<ProductDTO>(await _productRepository.ProductsCategoryAsync(id));
        }

        public async Task Remove(int? id) {

            var categoryId = _productRepository.GetByIdAsync(id).Result;

            await _productRepository.DeleteAsync(categoryId);
        }
    }
}
