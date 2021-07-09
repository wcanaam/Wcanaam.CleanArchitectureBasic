using AutoMapper;
using Wcanaam.CleanArchitectureBasic.Application.DTOs;
using Wcanaam.CleanArchitectureBasic.Domain.Entities;

namespace Wcanaam.CleanArchitectureBasic.Application.Mappings {
    public class DomainToDTIOMappingProfile : Profile {

        public DomainToDTIOMappingProfile() {

            CreateMap<Category, CategoryDTO>().ReverseMap();

            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
