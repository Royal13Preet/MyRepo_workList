using System.ComponentModel.DataAnnotations;

namespace DataAccess.DBModel
{
    public class User
    {
        public int UserId { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; } 

        [Required]
        [RegularExpression("Admin|Viewer", ErrorMessage = "Role must be Admin or Viewer.")]
        public string Role { get; set; } 

       
    }
}
