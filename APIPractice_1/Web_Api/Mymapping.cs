using AutoMapper;
using DataAccess.DBModel;
using Manager_Layer.Dto_s;

namespace Web_Api
{
    public class Mymapping : Profile
    {
        public Mymapping()
        {
            CreateMap<CreateProduct, Product>().ReverseMap();

     

            CreateMap<Product, ResponseDto>()
                .ForMember(dest => dest.ProductCategories, opt => opt.MapFrom(src => src.Categories.Select(pc => new CategoryDto
                {
                    CategoryId = pc.CategoryId,
                    CategoryName = pc.Category.Name
                }).ToList()));

            CreateMap<Category, CategoryDto>().ReverseMap();

        }


    }
}

