using API_DataAccessLayer.DBModel;

namespace API_DataAccessLayer.Repositories
{
    public interface IProfileRepo
    {
        public Profile CreateProfile(Profile profile);

        public Profile GetUserProfile(int id);

        public Profile UpdateProfile(Profile profile);
    }
}
