using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using electronicStore.WPF.Core;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Models;
using Store.Application.Models.Phones;
using Store.Application.Services;

namespace electronicStore.WPF.MVVM.ViewModel
{
    class ProductInListViewModel : ObservableObject
    {
        public ProductInListViewModel(Phone phone, IServiceProvider serviceProvider)
        {
            Data = phone;

            OpenProductCommand = new RelayCommand(f =>
            {
                var productViewModel = serviceProvider.GetService<PhoneViewModel>();
                productViewModel.Data = Data;

                var mainViewModel = serviceProvider.GetRequiredService<MainViewModel>();
                mainViewModel.CurrentView = productViewModel;
            });
        }


        public Phone Data { get; set; }
        public RelayCommand OpenProductCommand { get; set; }
    }
}