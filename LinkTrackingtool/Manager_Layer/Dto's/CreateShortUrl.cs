using System.ComponentModel.DataAnnotations;

namespace Manager_Layer.Dto_s
{
    public class CreateShortUrl
    {
        [Required]
        [MaxLength(200)]
        public string OriginUrl { get; set; }
    }
}
