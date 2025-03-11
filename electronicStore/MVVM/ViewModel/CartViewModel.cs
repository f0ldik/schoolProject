using electronicStore.WPF.Core;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Abstractions;
using Store.Core.Models.Orders;
using Store.Core.Models.Phones;

namespace electronicStore.WPF.MVVM.ViewModel
{
    class CartViewModel : ObservableObject
    {
        private readonly IPhonesService _phonesService;
        private readonly IServiceProvider _serviceProvider;

        public RelayCommand OrderCommand { get; set; }

        public List<CartItemViewModel> _items = [];
        public List<CartItemViewModel> Items
        {
            get => _items;
            set
            {

                _items = value;
                OnPropertyChanged();
            }
        }

        public double TotalPrice => Items.Sum(f => f.Data.TotalPrice);
        public int TotalQuantity => Items.Sum(f => f.Data.Quantity);

        public Phone Data;
        public CartViewModel(IServiceProvider serviceProvider)
        {
            _phonesService = serviceProvider.GetRequiredService<IPhonesService>();
            _serviceProvider = serviceProvider;


            OrderCommand = new RelayCommand(r =>
            {
                var cardDetailsViewModel = serviceProvider.GetService<CardDetailsViewModel>();

                var mainViewModel = serviceProvider.GetRequiredService<MainViewModel>();
                mainViewModel.CurrentView = cardDetailsViewModel;
            });
        }

        private string _category = "Cart";
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (string.Equals(value, _category, StringComparison.CurrentCulture))
                {
                    return;
                }
                _category = value;

                OnPropertyChanged();
            }
        }

        internal void AddPhoneById(Guid id)
        {
            var phone = _phonesService.Get(id);
            Items.Add(new CartItemViewModel(new CartItem
            {
                Quantity = 1,
                Price = phone.Price,
                PhoneId = id,
                Model = phone.Model,
                Image = phone.Image,
            }, _serviceProvider));
        }
    }
}