using System.ComponentModel.DataAnnotations;

namespace Manager_layer.DTo_s
{
    public class CreateProductDto
    {
        [Required]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [Range(1,double.MaxValue, ErrorMessage = "The Price must greater than 0")]
        public decimal Price { get; set; }


        [Range(1,int.MaxValue, ErrorMessage = "The stock quantity greater than 0")]
        public int StockQuantity { get; set; }


    }
}
