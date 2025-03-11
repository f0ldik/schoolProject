using Store.Core.Enums;

namespace Store.Core.Models.Orders;

public partial class Order
{
    public Guid Id { get; set; }

    public string UserName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? DeliveryAdress { get; set; }

    public string? Email { get; set; }

    public OrderStatus Status { get; set; } = OrderStatus.New;

    public string? Nov { get; set; }

    public double TotalPrice { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;
    public virtual ICollection<OrderItem> Items { get; set; }
}