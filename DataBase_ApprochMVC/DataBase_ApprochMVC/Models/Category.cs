using System;
using System.Collections.Generic;

namespace DataBase_ApprochMVC.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
