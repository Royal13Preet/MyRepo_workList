using AutoMapper;
using eFclass.DataAccess.Repository;
using eFclass.Models.DBModels;
using eFclass.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IRepository<User> _userRepository;

        private readonly IMapper _mapper;

        public UserManager(IRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        } 
        public UserDto GetUser(int id)
        {
            var user = _userRepository.GetSingleOrDefault(x => x.Id == id);
            if(user != null)
            {
                return _mapper.Map<UserDto>(user);
            }
            return null;
        }

        public UserDto GetUserByEmail(string email)
        {
            var user = _userRepository.GetSingleOrDefault(x => x.Email == email);
                
                if(user!= null)
                {
                    return _mapper.Map<UserDto>(user);
                }
                return null;
            
            
        }

        public List<UserDto> GetUsers()
        {
            var users = _userRepository.GetAll();
            return _mapper.Map<List<UserDto>>(users);
        }

        public bool SaveNewUser(UserDto user)
        {
            var dbuser = _mapper.Map<User>(user);
            _userRepository.Add(dbuser);
            return true;
        }
    }
}
