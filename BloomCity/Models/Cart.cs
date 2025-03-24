using System;
using System.Collections.Generic;

public class Cart
{
    public List<OrderDetail> Items { get; set; } = new List<OrderDetail>();
    public decimal Total => Items.Sum(i => i.SubTotal);
}