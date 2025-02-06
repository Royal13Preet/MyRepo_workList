using AutoMapper;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.Managers.DTO;

namespace Thursday_ProductManagement.WebApi
{
    public class mymapping : Profile
    {
        public mymapping() {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
