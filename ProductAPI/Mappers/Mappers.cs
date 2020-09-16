using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProductAPI.DTO;
using ProductAPI.Model;


namespace ProductAPI.Mappers
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Product, ProductDTO>()
                  .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.name))
                  .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.type))
                  .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.price))
                  .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.rating))
                  .ForMember(dest => dest.Users, opt => opt.MapFrom(src => src.users))
                  .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.description)).ReverseMap();

        }
    }
}
