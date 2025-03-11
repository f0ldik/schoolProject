using electronicStore.WPF;
using electronicStore.WPF.MVVM.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Abstractions;
using Store.Application.Services;
using Store.Data;
using System.Windows;

namespace electronicStore
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App()
        {
            var _serviceCollection = new ServiceCollection();
            _serviceCollection.AddDbContext<ShopContext>(e => e.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Shop;TrustServerCertificate=True;Encrypt=False;Integrated Security=True;"));
            _serviceCollection.AddSingleton<IPhonesService,PhonesService>();

            _serviceCollection.AddSingleton<CardDetailsViewModel>();
            _serviceCollection.AddTransient<CartItemViewModel>();
            _serviceCollection.AddSingleton<CartViewModel>();
            _serviceCollection.AddSingleton<HomeViewModel>();
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