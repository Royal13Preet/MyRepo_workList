using AutoMapper;
using DataAccess.DBModel;
using Manager_layer.Dto_s;

namespace Mvc_controller
{
    public class MyMappingProfile : Profile
    {
        public MyMappingProfile() 
        {
            CreateMap<Student, CreateStudentDto>().ReverseMap();
        
        }
    }
}
