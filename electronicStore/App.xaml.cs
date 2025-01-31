using electronicStore.WPF;
using electronicStore.WPF.MVVM.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Abstractions;
using Store.Application.Services;
using System.Windows;

namespace electronicStore
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App()
        {
            var _serviceCollection = new ServiceCollection();
            _serviceCollection.AddSingleton<IPhonesService,PhonesService>();

            _serviceCollection.AddSingleton<HomeViewModel>();
            _serviceCollection.AddSingleton<CardDetailsViewModel>();
            _serviceCollection.AddSingleton<CartViewModel>();
            _serviceCollection.AddTransient<CartItemViewModel>();
            _serviceCollection.AddSingleton<MainViewModel>();
            _serviceCollection.AddSingleton<PhoneViewModel>();

            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWin = new MainWindow();
            mainWin.DataContext = _serviceProvider.GetRequiredService<MainViewModel>();
            mainWin.Show();

            base.OnStartup(e);
        }
    }
}