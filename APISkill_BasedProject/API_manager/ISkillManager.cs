using API_DataAccessLayer.DBModel;
using API_manager.DTo_s;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_manager
{
    public interface ISkillManager
    {
        public bool AddSkill(AddSkill addSkill);

        public IEnumerable<Skill> GetAllSkills();
    }
}
