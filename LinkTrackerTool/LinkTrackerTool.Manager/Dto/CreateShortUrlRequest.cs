using System.ComponentModel.DataAnnotations;

namespace LinkTrackerTool.Manager.Dto
{
    public class CreateShortUrlRequest
    {
        [Required]
        public string OriginalUrl { get; set; } = string.Empty;

        public string CustomAlias { get; set; } = string.Empty;
    }
}
