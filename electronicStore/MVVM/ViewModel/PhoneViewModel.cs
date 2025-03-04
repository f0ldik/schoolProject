using electronicStore.WPF.Core;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Abstractions;
using Store.Core.Models.Phones;

namespace electronicStore.WPF.MVVM.ViewModel
{
    class PhoneViewModel : ObservableObject
    {
        private Phone _phone;

        private IPhonesService _phonesService;
        public RelayCommand AddToCartCommand { get; set; }
        public Phone Data
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        public PhoneViewModel(IServiceProvider serviceProvider)
        {
            _phonesService = serviceProvider.GetService<IPhonesService>();
            AddToCartCommand = new RelayCommand(f =>           
            {
                var cartViewModel = serviceProvider.GetRequiredService<CartViewModel>();
                cartViewModel.AddPhoneById(Guid.Parse(f.ToString()));

                var mainViewModel = serviceProvider.GetRequiredService<MainViewModel>();
                mainViewModel.CurrentView = cartViewModel;

            });

        }

        internal void SetPhoneId(Guid id)
        {
            Data = _phonesService.Get(id);
        }
    }
}