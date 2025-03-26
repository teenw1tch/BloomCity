    using System;
    using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; }

    public string Phone { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    public bool IsAdmin { get; set; }

    public decimal TotalSpent { get; set; }

    public List<Address> Addresses { get; set; } = new List<Address>();
}