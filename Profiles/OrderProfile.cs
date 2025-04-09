using AtirAPI.DTOs;
using AtirAPI.Models;
using AutoMapper;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<OrderCreateDTO, Order>()
            .ForMember(dest => dest.Customer, opt => opt.Ignore())
            .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));

        CreateMap<OrderItemCreateDTO, OrderItem>()
            .ForMember(dest => dest.Order, opt => opt.Ignore())
            .ForMember(dest => dest.Product, opt => opt.Ignore());
    }
}