using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.DBModel
{
    public class Student
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Course { get; set; }

        public bool IsActive { get; set; } = true;

        public string? ProfilePicture { get; set; } // Store file path in DB

        [NotMapped]
        public IFormFile? ProfileImageFile { get; set; } // File upload



    }
}


