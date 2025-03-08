using API_DataAccessLayer.DBModel;
using API_manager;
using API_manager.DTo_s;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API_Servicelayer
{
    public class UserService : IUserService
    {
        private readonly IUserManager _userManager;

        public UserService(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public User Create(UserCreateDto user)
        {
            return _userManager.Create(user);
        }

        public User GetUserById(int id)
        {
            var user = _userManager.GetUserById(id);
            if (user != null)
            {
                return user;
            }
            return null!;
        }

        public string Login(UserLogin userLogin)
        {
            return _userManager.Login(userLogin);
            
        }
    }   
}


