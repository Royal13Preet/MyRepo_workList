using System.ComponentModel.DataAnnotations;

namespace Thursday_ProductManagement.Managers.DTO
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; } = null!;

        [Range(1, Double.MaxValue)]
        public decimal Price { get; set; }
    }
}
