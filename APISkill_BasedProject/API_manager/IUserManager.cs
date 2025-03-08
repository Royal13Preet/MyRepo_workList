using API_DataAccessLayer.DBModel;
using API_manager.DTo_s;

namespace API_manager
{
    public interface IUserManager
    {
        public User Create(UserCreateDto user);

        public string Login(UserLogin loginuser);

        public User GetUserById(int id);
    }
}
