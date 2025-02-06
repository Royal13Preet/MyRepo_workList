using System;
using System.Collections.Generic;

namespace DataBase_ApprochMVC.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public int CategoryId { get; set; }

    public int BrandId { get; set; }

    public int Quantity { get; set; }

    public int Price { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category? Category { get; set; }
}