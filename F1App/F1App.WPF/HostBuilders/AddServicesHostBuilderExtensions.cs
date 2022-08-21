using F1App.Models.Services;
using F1App.Models.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace F1App.WPF.HostBuilders
{
    public static class AddServicesHostBuilderExtensions
    {
        public static IHostBuilder AddServices(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                services.AddSingleton<ITeamService, TeamService>();
                services.AddScoped<IDriverService, DriverService>();
                services.AddSingleton<IWinnerService, WinnerService>();
                services.AddSingleton<IGrandPrixService, GrandPrixService>();
            });

            return host;
        }
    }
}
