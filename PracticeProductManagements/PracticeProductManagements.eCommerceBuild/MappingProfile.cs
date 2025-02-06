using AutoMapper;
using PracticeProductManagements.DataAccess.DBModel;
using PracticeProductManagements.Models.Dtos;

namespace PracticeProductManagements.eCommerceBuild
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            CreateMap<Product, ProductDetailsDto>();

            CreateMap<ProductDetailsDto, Product>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.Now));

        }
    }
}
