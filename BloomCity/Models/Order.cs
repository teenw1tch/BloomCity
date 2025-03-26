using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net;

public class Order
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }

    public DateTime OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public int AddressId { get; set; }

    [ForeignKey("AddressId")]
    public Address Address { get; set; }

    public int DeliveryId { get; set; }

    [ForeignKey("DeliveryId")]
    public Delivery Delivery { get; set; }

    public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
