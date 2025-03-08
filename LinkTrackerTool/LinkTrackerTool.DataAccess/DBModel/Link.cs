using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkTrackerTool.DataAccess.DBModel
{
    public class Link
    {
        public Guid Id { get; set; }

        [Required]
        public string OriginalUrl { get; set; } = string.Empty;

        public string CustomAlias { get; set; } = string.Empty;

        public string ShortUrl { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        
    }
}
