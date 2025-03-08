using AutoMapper;

namespace Sample_Webapi
{
    public class MyMAppingProfile : Profile
    {
        public MyMAppingProfile()
        {
            CreateMap<Product, Createproductdto>().ReverseMap();
        }
    }
}
