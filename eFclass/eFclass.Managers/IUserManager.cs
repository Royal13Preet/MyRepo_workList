using eFclass.Models.DBModels;
using eFclass.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.Managers
{
    public interface IUserManager
    {
        public List<UserDto> GetUsers();

        public UserDto GetUser(int id);



        public UserDto GetUserByEmail(string email);

        public bool SaveNewUser(UserDto user);


    }
}
