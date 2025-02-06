using AutoMapper;
using Product_Managementmvc.DataAccess.DBModel;
using Product_Managementmvc.Managers.ProductDto;

namespace Product_Managementmvc.MvcView
{
    public class Mymapping : Profile
    {
        public Mymapping()
        {
            CreateMap<Product, ProductCreateDto>().ReverseMap();
        }
    }
}
