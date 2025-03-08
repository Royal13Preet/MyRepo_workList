using API_DataAccessLayer.DBModel;
using API_manager.DTo_s;

namespace API_manager
{
    public interface IProfileManager
    {
        public Profile CreateProfile(UserProfileDto profile);

        public Profile GetUserProfile(int id);

        public Profile UpdateProfile(int id,UserProfileDto profile);
    }
}
