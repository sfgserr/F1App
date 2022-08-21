using F1App.Models.Formatters;
using F1App.Models.Parsers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace F1App.WPF.HostBuilders
{
    public static class AddParsersHostBuilderExtensions
    {
        public static IHostBuilder AddParsers(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                services.AddSingleton<IHtmlParser, HtmlParser>();
                services.AddSingleton<IDriverParser, DriverParser>();

                services.AddSingleton<IFormatter, Formatter>();
            });
            
            return host;
        }
    }
}
