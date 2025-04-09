using AtirAPI.DTOs;
using AtirAPI.Models;
using AutoMapper;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<ProductCreateDTO, Product>()
             .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
             .ForMember(dest => dest.Category, opt => opt.Ignore()); // Ignore Category since we only have the ID to map

        CreateMap<Product, ProductDTO>();
        CreateMap<Category, CategoryDTO>();
    }
}