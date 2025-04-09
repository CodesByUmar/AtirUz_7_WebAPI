using AutoMapper;
using AtirAPI.Models;
using AtirAPI.DTOs;

namespace AtirAPI.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerCreateDTO, Customer>();
            CreateMap<Customer, CustomerDTO>();
        }
    }
}