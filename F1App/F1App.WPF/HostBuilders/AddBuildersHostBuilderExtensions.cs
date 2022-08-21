using F1App.Models.Builders;
using F1App.Models.Builders.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace F1App.WPF.HostBuilders
{
    public static class AddBuildersHostBuilderExtensions
    {
        public static IHostBuilder AddBuilders(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                services.AddSingleton<IDriverBuilder, DriverBuilder>();
                services.AddSingleton<IWinnerBuilder, WinnerBuilder>();
                services.AddSingleton<IGrandPrixBuilder, GrandPrixBuilder>();
                services.AddSingleton<ITeamBuilder, TeamBuilder>();
            });

            return host;
        }
    }
}
