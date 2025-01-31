using System;
using System.Collections.Generic;

namespace Store.Data;

public partial class Order
{
    public Guid Id { get; set; }

    public string UserName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? DeliveryAdress { get; set; }

    public string? Email { get; set; }

    public byte Status { get; set; }

    public string? Nov { get; set; }

    public double TotalPrice { get; set; }

    public DateTime Date { get; set; }
}
