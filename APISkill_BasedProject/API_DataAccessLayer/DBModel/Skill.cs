using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DataAccessLayer.DBModel
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }

        public string SkillName { get; set; } 

        //many to many with user
        public ICollection<UserSkill> UserSkills { get; set; }

        //many to many with product
        public ICollection<ProjectSkill> ProjectSkills { get; set; } 
    }
}

