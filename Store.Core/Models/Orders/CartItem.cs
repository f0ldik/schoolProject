using System.ComponentModel;

namespace Store.Core.Models.Orders
{
    public class CartItem
    {
        public Guid PhoneId { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }


        public double Price { get; set; }
        public double TotalPrice => Price * Quantity;

        public int Quantity { get; set; }

        //private int quantity;
        //{
        //    get { return quantity; }
        //    set
        //    {
        //        if (quantity != value)
        //        {
        //            quantity = value;
        //            OnPropertyChanged(nameof(Quantity));
        //        }
        //    }
        //}
        //public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}



    }
}