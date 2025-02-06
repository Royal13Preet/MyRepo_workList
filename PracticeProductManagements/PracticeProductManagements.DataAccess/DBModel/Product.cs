using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace PracticeProductManagements.DataAccess.DBModel
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="The Name is Required")]
        [StringLength(100, ErrorMessage = "String not exceed 100 letters")]
        public string Name { get; set; } = null!;
        
        [StringLength(500, ErrorMessage = "string not be exceed 500 letters")]
        public string? Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required]
        [MinLength(0, ErrorMessage = "Stock quantity must be greater than 0.")]
        public int StockQuantity { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public decimal TotalPrice { get; set; }


    }
}


