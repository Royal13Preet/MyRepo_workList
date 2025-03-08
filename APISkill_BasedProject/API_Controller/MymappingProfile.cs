using API_DataAccessLayer.DBModel;
using API_manager.DTo_s;
using AutoMapper;
using Profile = API_DataAccessLayer.DBModel.Profile;

namespace API_Controller
{
    public class MymappingProfile : AutoMapper.Profile
    {
        public MymappingProfile()
        {
            CreateMap<User, UserCreateDto>();

            CreateMap<UserCreateDto, User>();

            CreateMap<User, UserLogin>().ReverseMap();


            CreateMap<Profile, UserProfileDto>();

            CreateMap<UserProfileDto, Profile>();


            CreateMap<Skill, AddSkill>();
            CreateMap<AddSkill, Skill>();

            CreateMap<Project, CreateProject>();
            CreateMap<CreateProject, Project>();
        }

    }
}
