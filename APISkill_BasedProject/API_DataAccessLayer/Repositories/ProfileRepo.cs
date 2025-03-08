using API_DataAccessLayer.DBModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DataAccessLayer.Repositories
{
    public class ProfileRepo : IProfileRepo
    {
        private readonly AppDbContext _dbContext;

        public ProfileRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Profile CreateProfile(Profile profile)
        {
            var profiles = _dbContext.Profiles.Add(profile);
            _dbContext.SaveChanges();
            return profiles.Entity;
        }

        public Profile GetUserProfile(int id)
        {
            var profile = _dbContext.Profiles.Include(u => u.User).
                FirstOrDefault(x => x.ProfileId == id);
            if (profile != null)
            {
                return profile;
            }
            return null!;
            
        }

        public Profile UpdateProfile(Profile profile)
        {
            var update = _dbContext.Profiles.Update(profile);
            _dbContext.SaveChanges();
            return update.Entity;
        }
    }
}
