using System.ComponentModel.DataAnnotations;

namespace Thursday_ProductManagement.DataAccess
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Range(1, Double.MaxValue)]
        public decimal Price { get; set; }

    }
}
