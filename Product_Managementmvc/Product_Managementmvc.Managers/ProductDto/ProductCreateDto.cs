using System.ComponentModel.DataAnnotations;

namespace Product_Managementmvc.Managers.ProductDto
{
    public class ProductCreateDto
    {
        [Required]
        public string Name { get; set; } = null!;

        [Range(1, Double.MaxValue)]
        public decimal Price { get; set; }
    }
}
