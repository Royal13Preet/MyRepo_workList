using API_DataAccessLayer.DBModel;
using API_manager.DTo_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Servicelayer
{
    public interface ISkillService
    {
        public bool AddSkill(AddSkill addSkill);

        public IEnumerable<Skill> GetAllSkills();
    }
}
