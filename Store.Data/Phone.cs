using System;
using System.Collections.Generic;

namespace Store.Data;

public partial class Phone
{
    public Guid Id { get; set; }

    public double Price { get; set; }

    public string Model { get; set; } = null!;

    public string Procesor { get; set; } = null!;

    public byte Color { get; set; }
}
