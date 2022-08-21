using F1App.WPF.States.Installers;
using F1App.WPF.States.Navigators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace F1App.WPF.HostBuilders
{
    public static class AddStatesHostBuilderExtensions
    {
        public static IHostBuilder AddStates(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) => 
            {
                services.AddSingleton<INavigator, Navigator>();
                services.AddSingleton<IInstaller, Installer>();
            });

            return host;
        } 
    }
}
