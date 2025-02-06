using eFclass.Managers;
using eFclass.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.Services
{
    public class UserService : IUserService
    {
        private IUserManager _usermanager;

       

        public UserService(IUserManager usermanager)
        {
            _usermanager = usermanager;
        }
        public UserDto GetUser(int id)
        {
           return _usermanager.GetUser(id);
        }

        public UserDto GetUserByEmail(string Email)
        {
            return _usermanager.GetUserByEmail(Email);
        }

        public List<UserDto> GetUsers()
        {
            return _usermanager.GetUsers();
        }

       public bool SaveNewUser(UserDto user)
        {
            return _usermanager.SaveNewUser(user);
        }

   
    }
}
