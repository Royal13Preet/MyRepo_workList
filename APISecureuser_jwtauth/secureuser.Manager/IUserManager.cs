using Secureuser.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secureuser.Manager
{
    public interface IUserManager
    {
        /// <summary>
        /// Taking the single username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool IsUsernameTaken(string username);
        /// <summary>
        /// Login of the user and admin
        /// </summary>
        /// <param name="loginUser"></param>
        /// <returns></returns>
        public UserCreatedto AuthenticateUser(Loginuserdto loginUser);

        /// <summary>
        /// Creating a new user
        /// </summary>
        /// <param name="userDto"></param>
        public void CreateUser(UserCreatedto userDto);

        /// <summary>
        /// Deleting a user
        /// </summary>
        /// <param name="username"></param>
        public void DeleteUser(string username);
        /// <summary>
        /// Getting all the user
        /// </summary>
        /// <returns></returns>
        public List<UserCreatedto> GetAllUsers();

        /// <summary>
        /// Generating the token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string GenerateJwtToken(UserCreatedto user);
    }
}
