using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_DataAccessLayer.DBModel
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public string? Description { get; set; }

        // Foreign Key to User (CreatedBy)
        public int CreatedBy { get; set; }
        [JsonIgnore]
        public User CreatedByUser { get; set; }

        public ICollection<ProjectSkill> Skill { get; set; }

        //many to mnay user and project
        public ICollection<ProjectUser> ProjectUsers { get; set; }
    }
}




