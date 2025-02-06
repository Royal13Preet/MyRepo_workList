using AutoMapper;
using DataAccess;
using Manager_layer.DTo_s;

namespace Web_api
{
    public class Mymapping : Profile
    {
        public Mymapping() 
        {
            CreateMap<Product, CreateProductDto>();

            CreateMap<CreateProductDto, Product>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.Now)).ReverseMap();  
        }
    }
}
