using AutoMapper;
using LinkTrackerTool.DataAccess.DBModel;
using LinkTrackerTool.Manager.Dto;

namespace LinkTrackerTool.WebApi
{
    public class MymappingProfile : Profile
    {

        public MymappingProfile()
        {
            CreateMap<Link, CreateShortUrlRequest>().ReverseMap(); 

            
        }
    }
}
