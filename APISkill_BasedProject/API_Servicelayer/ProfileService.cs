using API_DataAccessLayer.DBModel;
using API_manager;
using API_manager.DTo_s;

namespace API_Servicelayer
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileManager _profileManager;

        public ProfileService(IProfileManager profileManager)
        {
            _profileManager = profileManager;
        }

        public Profile CreateProfile(UserProfileDto profile)
        {
            return _profileManager.CreateProfile(profile);
        }


        public Profile GetUserProfile(int id)
        {
            return _profileManager.GetUserProfile(id);
        }

        public Profile UpdateProfile(int id, UserProfileDto profile)
        {
           return _profileManager.UpdateProfile(id, profile);
        }
    }
}
