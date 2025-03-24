using System;
using System.Collections.Generic;
using System.Net;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public int AddressId { get; set; }
    public Address Address { get; set; }
    public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    public int DeliveryId { get; set; }
    public Delivery Delivery { get; set; }
}
