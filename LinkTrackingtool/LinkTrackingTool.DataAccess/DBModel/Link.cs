using System.ComponentModel.DataAnnotations;

namespace LinkTrackingTool.DataAccess.DBModel
{
    public class Link
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string OriginUrl { get; set; }

        [Required]
        [MaxLength(50)]
        public string ShortUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}






