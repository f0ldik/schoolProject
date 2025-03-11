using System.ComponentModel;

namespace Store.Core.Models.Orders
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid PhoneId { get; set; }
        public Guid OrderId { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
    }
}