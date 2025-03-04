using electronicStore.WPF.Core;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Abstractions;

namespace electronicStore.WPF.MVVM.ViewModel
{
    class HomeViewModel : ObservableObject
    {
        public HomeViewModel(IServiceProvider serviceProvider)
        {
            var phonesService = serviceProvider.GetRequiredService<IPhonesService>();
            Products = phonesService.GetAll()
                .Select(f => new ProductInListViewModel(f, serviceProvider))
                .ToList();
        }

        private string _category = "Home";
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

        private List<ProductInListViewModel> _products = [];
        public List<ProductInListViewModel> Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;

                OnPropertyChanged();
            }
        }
    }
}