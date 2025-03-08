using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DataAccessLayer.DBModel
{
    public class ProjectSkill
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; } 

        public int SkillId { get; set; }
        public Skill Skill { get; set; } 
    }
}
