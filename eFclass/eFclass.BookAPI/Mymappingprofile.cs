using AutoMapper;
using eFclass.Models.DBModels;
using eFclass.Models.ViewModels;

namespace eFclass.BookAPI
{
    public class Mymappingprofile : Profile
    {
        public Mymappingprofile() {
           
                //DB to VM
                CreateMap<Book, BookDto>()
                    .ForMember(x => x.AuthorName, x => x.MapFrom(y => y.author.AuthorName))
                    .ReverseMap();

            CreateMap<User, UserDto>().ReverseMap(); ;

            }
    }
}
