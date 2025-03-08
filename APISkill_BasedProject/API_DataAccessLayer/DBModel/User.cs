using API_DataAccessLayer.DBModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API_DataAccessLayer.DBModel
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string Password { get; set; }


        // One-to-One Relationship
        public Profile Profile { get; set; }

        //one to many
        public ICollection<Project> Projects { get; set; }

        //many to many
        public ICollection<UserSkill> UserSkills { get; set; }

        //many to many
        public ICollection<ProjectUser> ProjectUsers { get; set; } 
    }
    
}


