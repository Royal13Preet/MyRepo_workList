using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using secureuser.Manager;
using Secureuser.DataAccess.DBModels;
using Secureuser.DataAccess.Repositories;
using Secureuser.Models.ViewModel;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Secureuser.Manager
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        private const string SecretKey = "YourLongerSecureSecretKeyHere12345";
        private readonly IMapper _mapper;

        public UserManager(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserCreatedto AuthenticateUser(Loginuserdto loginUser)
        {
            var user = _userRepository.GetUserByUsernameAndPassword(loginUser.Username, loginUser.Password);
            return _mapper.Map<UserCreatedto>(user);
        }

        public bool IsUsernameTaken(string username)
        {
            return _userRepository.GetUserByUsername(username) != null;
        }
        
        public void CreateUser(UserCreatedto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            _userRepository.AddUser(user);
            _userRepository.Save();
        }

        public void DeleteUser(string username)
        {
            var user = _userRepository.GetUserByUsername(username);
            if (user != null)
            {
                _userRepository.RemoveUser(user);
                _userRepository.Save();
            }
        }

        public List<UserCreatedto> GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            var UserDtos = _mapper.Map<List<UserCreatedto>>(users);
            UserDtos.ForEach(u => u.Password = "*****");
            return UserDtos;
        }

        public string GenerateJwtToken(UserCreatedto user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "YourIssuer",
                audience: "YourAudience",
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }



    }
}
