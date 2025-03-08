﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DataAccessLayer.DBModel
{
    public class UserSkill
    {
        public int UserId {  get; set; }    
        public User User { get; set; } 

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}


