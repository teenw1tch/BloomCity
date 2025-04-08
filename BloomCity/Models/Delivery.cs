using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Delivery
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string CourierName { get; set; }

    [Required]
    public string Status { get; set; }

    public DateTime EstimatedDeliveryDate { get; set; }

    public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
