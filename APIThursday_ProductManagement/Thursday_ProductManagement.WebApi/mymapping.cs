using AutoMapper;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.Managers.DTO;

namespace Thursday_ProductManagement.WebApi
{
    public class Mymapping : Profile
    {
        public Mymapping() {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
