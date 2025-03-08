using AutoMapper;
using Secureuser.DataAccess.DBModels;
using Secureuser.Models.ViewModel;

namespace Secureuser.UserProject
{
    public class Mymappingprofile : Profile
    {
        public Mymappingprofile()
        {

            CreateMap<User, UserCreatedto>().ReverseMap();
        }
    }
}







