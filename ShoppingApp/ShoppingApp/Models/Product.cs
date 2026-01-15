using System;
using System.Collections.Generic;

namespace ShoppingApp.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Brand { get; set; }

    public decimal Price { get; set; }

    public int? StockQuantity { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
