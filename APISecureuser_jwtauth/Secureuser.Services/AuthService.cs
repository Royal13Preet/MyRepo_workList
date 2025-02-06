//using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
//using Microsoft.Extensions.Caching.Memory;
//using Microsoft.IdentityModel.Tokens;
//using secureuser.Manager;
//using Secureuser.Models.ViewModel;
//using System;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;



//namespace Secureuser.Services
//{
//    public class AuthService : IAuthService
//    {
//        private readonly IUserManager _userManager;
//        private readonly IMemoryCache _cache;

//        public AuthService(IUserManager userManager, IMemoryCache cache)
//        {
//            _userManager = userManager;
//            _cache = cache;
//        }

//        public string Login(Loginuserdto loginUser)
//        {
//            var user = _userManager.AuthenticateUser(loginUser);
//            if (user == null)
//            {
//                return "Invalid username or password.";
//            }

//            return _userManager.GenerateJwtToken(user);
//        }

//        public string Register(UserCreatedto newUser)
//        {
//            if (_userManager.IsUsernameTaken(newUser.Username))
//            {
//                return "Username already exists.";
//            }

//            _userManager.CreateUser(newUser);
//            _cache.Remove("AllUsers"); 
//            return "User created successfully.";
//        }


//        //public string Register(UserCreatedto newUser)
//        //{
//        //    if (_userManager.IsUsernameTaken(newUser.Username))
//        //    {
//        //        return "Username already exists.";
//        //    }

//        //    var validRoles = new List<string> { "admin", "user" };


//        //    if (!validRoles.Contains(newUser.Role.ToLower()))
//        //    {
//        //        return "Invalid role. Please provide 'admin' or 'user' as the role.";
//        //    }

//        //    _userManager.CreateUser(newUser);
//        //    return "User created successfully.";


//        //}


//        public string DeleteUser(string usernameToDelete)
//        {
//            if (!_userManager.IsUsernameTaken(usernameToDelete))
//            {
//                return "User not found.";
//            }

//            _userManager.DeleteUser(usernameToDelete);
//            return "User deleted successfully.";
//        }

//        //public List<UserCreatedto> GetAllUsers()
//        //{
//        //    var users = _userManager.GetAllUsers();
//        //    return users;
//        //}
//        public List<UserCreatedto> GetAllUsers()
//        {
//            if (!_cache.TryGetValue("AllUsers", out List<UserCreatedto> users))
//            {
//                users = _userManager.GetAllUsers();
//                var cacheOptions = new MemoryCacheEntryOptions
//                {
//                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
//                    SlidingExpiration = TimeSpan.FromMinutes(2)
//                };


//                _cache.Set("AllUsers", users, cacheOptions);
//            }

//            return users;
//        }


//    }
//}

using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using secureuser.Manager;
using Secureuser.Models.ViewModel;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Secureuser.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserManager _userManager;
        private readonly IMemoryCache _cache;

        public AuthService(IUserManager userManager, IMemoryCache cache)
        {
            _userManager = userManager;
            _cache = cache;
        }

        public string Login(Loginuserdto loginUser)
        {
            if (_cache.TryGetValue($"JwtToken_{loginUser.Username}", out string cachedToken))
            {
                return cachedToken;
            }
            var user = _userManager.AuthenticateUser(loginUser);
            if (user == null)
            {
                return "Invalid username or password.";
            }
            var jwtToken = _userManager.GenerateJwtToken(user);
            var cacheOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(15)
            };
            _cache.Set($"JwtToken_{loginUser.Username}", jwtToken, cacheOptions);

            return jwtToken;
        }
        
        public string Register(UserCreatedto newUser)
        {
            
            if (_cache.TryGetValue($"UsernameExists_{newUser.Username}", out bool usernameExists) && usernameExists)
            {
                return "Username already exists.";
            }
            if (_userManager.IsUsernameTaken(newUser.Username))
            {
                
                _cache.Set($"UsernameExists_{newUser.Username}", true, TimeSpan.FromMinutes(10));
                return "Username already exists.";
            }
            _userManager.CreateUser(newUser);
            _cache.Remove("AllUsers");

           
            _cache.Set($"UserCreated_{newUser.Username}", "User created successfully.", TimeSpan.FromMinutes(5));

            return "User created successfully.";
        }

        public string DeleteUser(string usernameToDelete)
        {
          
            if (_cache.TryGetValue($"UserDeleted_{usernameToDelete}", out string deleteStatus))
            {
                return deleteStatus;
            }

            if (!_userManager.IsUsernameTaken(usernameToDelete))
            {
               
                _cache.Set($"UserDeleted_{usernameToDelete}", "User not found.", TimeSpan.FromMinutes(5));
                return "User not found.";
            }

            _userManager.DeleteUser(usernameToDelete);

           
            _cache.Set($"UserDeleted_{usernameToDelete}", "User deleted successfully.", TimeSpan.FromMinutes(5));

            return "User deleted successfully.";
        }

        public List<UserCreatedto> GetAllUsers()
        {
            if (!_cache.TryGetValue("AllUsers", out List<UserCreatedto> users))
            {
                users = _userManager.GetAllUsers();
                var cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
                    SlidingExpiration = TimeSpan.FromMinutes(2)
                };

                _cache.Set("CacheList", users, cacheOptions);
            }

            return users;
        }
    }
}



