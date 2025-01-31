using electronicStore.WPF.Core;
using electronicStore.WPF.Windows;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Enums;

namespace electronicStore.WPF.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public MainViewModel(IServiceProvider serviceProvider)
        {
            HomeVM = serviceProvider.GetRequiredService<HomeViewModel>();
            CurrentView = HomeVM;

            CategoryCommand = new RelayCommand(f =>
            {
                var m = (MainMenu)uint.Parse(f?.ToString());
                HomeVM.Category = m.ToString();
                CurrentView = HomeVM;
                if (m == MainMenu.Cart)
                {
                    //var window = new CartWindow();
                    //window.Show();

                    //var CartVM = serviceProvider.GetRequiredService<CartViewModel>();

                    //CurrentView = CartVM;
                }
                else
                {
                    CurrentView = HomeVM;
                }
            });
        }

        public HomeViewModel HomeVM { get; set; }
        public RelayCommand CategoryCommand { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }

        }
    }
}
