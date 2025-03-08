using API_DataAccessLayer.Repositories;
using API_manager.DTo_s;
using AutoMapper;
using Profile = API_DataAccessLayer.DBModel.Profile;

namespace API_manager
{
    public class ProfileManager : IProfileManager
    {
        private readonly IProfileRepo _profileRepo;
        private readonly IMapper _mapper;

        public ProfileManager(IProfileRepo profileRepo, IMapper mapper)
        {
            _profileRepo = profileRepo;
            _mapper = mapper;
        }

        public Profile CreateProfile(UserProfileDto profile)
        {
            var profiles = _mapper.Map<Profile>(profile);
            var product = _profileRepo.CreateProfile(profiles);
            return product;
            
        }

        public Profile GetUserProfile(int id)
        {
           var profileId =  _profileRepo.GetUserProfile(id);
            if (profileId == null) 
            {
                throw new Exception($"Profile with this Id {id} not found");
            }
            return profileId;
        }

        public Profile UpdateProfile(int id,UserProfileDto profile)
        {
            var get = _profileRepo.GetUserProfile(id);
            if (get == null) 
            {
                throw new Exception($"The USer of this {id} is not found");
            }

            var map = _mapper.Map(profile, get);

            return _profileRepo.UpdateProfile(map);
        }
    }
}
