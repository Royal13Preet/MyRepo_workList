using API_DataAccessLayer.DBModel;
using API_manager.DTo_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Servicelayer
{
    public interface IUserService
    {

        public User Create(UserCreateDto user);

        public string Login(UserLogin userLogin);

        public User GetUserById(int id);
    }
}
