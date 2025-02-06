using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "The Price must greater than 0")]
    public decimal Price { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "The stock quantity greater than 0")]
    public int StockQuantity { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}

