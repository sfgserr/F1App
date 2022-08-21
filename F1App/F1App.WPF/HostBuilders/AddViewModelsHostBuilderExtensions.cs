using F1App.WPF.ViewModels;
using F1App.WPF.ViewModels.Factories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace F1App.WPF.HostBuilders
{
    public static class AddViewModelsHostBuilderExtensions
    {
        public static IHostBuilder AddViewModels(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                services.AddScoped<MainViewModel>();
                services.AddScoped<DriversViewModel>();
                services.AddScoped<WinnersViewModel>();
                services.AddScoped<GrandsPrixViewModel>();
                services.AddScoped<HomeViewModel>();
                services.AddScoped<IFactoryViewModel, FactoryViewModel>();
            });
            
            return host;
        }
    }
}
