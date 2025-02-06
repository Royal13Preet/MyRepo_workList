using eFclass.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.Services
{
    public interface IUserService
    {
        public List<UserDto> GetUsers();
        public UserDto GetUser(int id);

        public UserDto GetUserByEmail(string Email);

        public bool SaveNewUser(UserDto user);
    }
}
