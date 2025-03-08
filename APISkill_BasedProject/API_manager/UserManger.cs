using API_DataAccessLayer.DBModel;
using API_DataAccessLayer.Repositories;
using API_manager.DTo_s;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API_manager
{
    public class UserManger : IUserManager
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;
        private readonly string _jwtSecretKey = "3W2xNlkFj+GZk5K3Rsb0Qp/YmMTJcWd2F/2lNA==";

        public UserManger(IUserRepo userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public User Create(UserCreateDto user)
        {
            var create = _mapper.Map<User>(user);
            create.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            return _userRepo.Create(create);
        }

        public User GetUserById(int id)
        {
            var user = _userRepo.GetUserById(id);
            if (user != null)
            {
                return user;
            }
            return null!;
        }

        public string Login(UserLogin loginuser)
        {

            var login = _userRepo.Login(loginuser.Email, loginuser.Password);
            if (login != null && BCrypt.Net.BCrypt.Verify(loginuser.Password, login.Password))
            {
                var token = GenerateJwtToken(login);
                return token;
            }
            return null!;

        }

        private string GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "your_issuer", // Ideally, use a proper issuer
                audience: "your_audience", // And a proper audience
                claims: claims,
                expires: DateTime.Now.AddDays(1), // Set the token expiration
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}




