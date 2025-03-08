using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API_DataAccessLayer.DBModel
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        public string? Bio { get; set; }
        public string? LinkedinURl { get; set; }

        
        // Foreign Key to User
        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; } 
    }
}


