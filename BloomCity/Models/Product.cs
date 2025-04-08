using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public bool InStock { get; set; }

    public int CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    public Category Category { get; set; }

    public string ImagePath { get; set; }

    public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}