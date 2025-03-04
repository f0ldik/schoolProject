using electronicStore.WPF.Core;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Abstractions;
using Store.Core.Models.Carts;
using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace electronicStore.WPF.MVVM.ViewModel
{
    internal class CartItemViewModel(CartItem data, IServiceProvider serviceProvider) : ObservableObject
    {

        public CartItem Data { get; init; } = data;

        public RelayCommand DeleteCommand { get; init; } = new RelayCommand(r =>
        {
            var cartVM = serviceProvider.GetService<CartViewModel>();
            cartVM.Items = cartVM.Items.Where(f => f.Data.PhoneId != data.PhoneId).ToList();
        });

        public RelayCommand AddQuantityCommand { get; init; } = new RelayCommand(r =>
        {
            var cartVM = serviceProvider.GetService<CartViewModel>();
            var cartItem = cartVM.Items.Find(f => f.Data.PhoneId == data.PhoneId);
            cartItem.Data.Quantity++;

            cartItem.OnPropertyChanged("Data");
            cartVM.OnPropertyChanged("TotalPrice");
            cartVM.OnPropertyChanged("TotalQuantity");

        });

        public RelayCommand SubstrastQuantityCommand { get; init; } = new RelayCommand(r =>
        {
            var cartVM = serviceProvider.GetService<CartViewModel>();
            var cartItem = cartVM.Items.Find(f => f.Data.PhoneId == data.PhoneId);
            cartItem.Data.Quantity--;

            if (cartItem.Data.Quantity < 1 )
             cartItem.Data.Quantity = 1;

            cartItem.OnPropertyChanged("Data");
            cartVM.OnPropertyChanged("TotalPrice");
            cartVM.OnPropertyChanged("TotalQuantity");

        });


        


        //public void ProductListBox_PreviewKeyDown(object sender, KeyEventArgs e)
        //{
        //    // Allow control keys (Backspace, Delete, Tab, Enter, etc.)
        //    if (e.Key == Key.Back || e.Key == Key.Delete || e.Key == Key.Tab || e.Key == Key.Enter || e.Key == Key.Escape)
        //    {
        //        return;
        //    }

        //    // Check if the key is a number key
        //    if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)))
        //    {
        //        // If the key is not a number, mark the event as handled
        //        e.Handled = true;
        //    }
        //}

    }
}