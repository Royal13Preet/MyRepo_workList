using API_DataAccessLayer.DBModel;
using API_manager;
using API_manager.DTo_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Servicelayer
{
    public class SkillService : ISkillService
    {

        private readonly ISkillManager _skillManager;

        public SkillService(ISkillManager skillManager)
        {
            _skillManager = skillManager;
        }

        public bool AddSkill(AddSkill addSkill)
        {
          return _skillManager.AddSkill(addSkill);
        }

        public IEnumerable<Skill> GetAllSkills()
        {
            return _skillManager.GetAllSkills(); 
        }
    }
}
