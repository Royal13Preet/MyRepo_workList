using System.ComponentModel.DataAnnotations;

namespace Product_Managementmvc.DataAccess.DBModel
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
