using API_DataAccessLayer.DBModel;
using API_manager.DTo_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Servicelayer
{
    public interface IProfileService
    {
        public Profile CreateProfile(UserProfileDto profile);

        public Profile GetUserProfile(int id);

        public Profile UpdateProfile(int id,UserProfileDto profile);
    }
}
