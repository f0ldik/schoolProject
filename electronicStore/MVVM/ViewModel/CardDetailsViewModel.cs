using electronicStore.WPF.Core;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Abstractions;
using Store.Application.Models.Carts;
using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace electronicStore.WPF.MVVM.ViewModel
{
    internal class CardDetailsViewModel : ObservableObject
    {
        //public RelayCommand DeleteCommand { get; init; } = new RelayCommand(r =>
        //{
        //    var cartVM = serviceProvider.GetService<CartViewModel>();
        //    cartVM.Items = cartVM.Items.Where(f => f.Data.PhoneId != data.PhoneId).ToList();
        //});

    }
}