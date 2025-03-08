using AutoMapper;
using LinkTrackingTool.DataAccess.DBModel;
using Manager_Layer.Dto_s;

namespace LinkTrackingtool.WebAPi
{
    public class MyMappingProfile : Profile
    {
        public MyMappingProfile() 
        {
            CreateMap<Link, CreateShortUrl>().ReverseMap();
        
        }
    }
}
