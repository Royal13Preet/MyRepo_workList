using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProductManagements.Models.Dtos
{
    public class ProductDetailsDto
    {

        [Required]
        [StringLength(100, ErrorMessage = "String not exceed 100 letters")]
        public string Name { get; set; } = null!;


        [StringLength(500, ErrorMessage = "string not be exceed 500 letters")]
        public string? Description { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Stock quantity must be greater than 0.")]
        public int StockQuantity { get; set; }



    }
}
