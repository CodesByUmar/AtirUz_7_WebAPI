using AutoMapper;
using AtirAPI.Models;
using AtirAPI.DTOs;

namespace AtirAPI.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            // Mapping from Category to CategoryDTO for GET operations
            CreateMap<Category, CategoryDTO>();

            // Mapping from CategoryCreateDTO to Category for POST operation
            CreateMap<CategoryCreateDTO, Category>();
            CreateMap<CategoryUpdateDTO, Category>()
                   .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        }
    }
}