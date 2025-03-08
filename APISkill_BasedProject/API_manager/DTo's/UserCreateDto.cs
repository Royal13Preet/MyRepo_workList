using System.ComponentModel.DataAnnotations;

namespace API_manager.DTo_s
{
    public class UserCreateDto
    {
        public string Name { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

    }
}
