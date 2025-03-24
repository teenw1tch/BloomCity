using System;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
    public decimal TotalSpent { get; set; }
    public List<Address> Addresses { get; set; } = new List<Address>();
}