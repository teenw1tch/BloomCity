using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class Cart
{
    public List<OrderDetail> Items { get; set; } = new List<OrderDetail>();

    [NotMapped]
    public decimal Total => Items.Sum(i => i.SubTotal);
}