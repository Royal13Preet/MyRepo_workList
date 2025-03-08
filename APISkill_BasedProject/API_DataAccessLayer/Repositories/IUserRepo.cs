using API_DataAccessLayer.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DataAccessLayer.Repositories
{
    public interface IUserRepo
    {
        public User Create(User user);

        public User Login(string email, string password);

        public User GetUserById(int id);

    }
}
