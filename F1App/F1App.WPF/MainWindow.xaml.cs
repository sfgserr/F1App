using F1App.WPF.ViewModels;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using F1App.WPF.HostBuilders;

namespace F1App.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IHost _host;

        public MainWindow()
        {
            _host = CreateHostBuilder().Build();

            DataContext = _host.Services.GetRequiredService<MainViewModel>();
            InitializeComponent();
        }
        private IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                       .AddViewModels()
                       .AddServices()
                       .AddBuilders()
                       .AddStates()
                       .AddParsers();
        }
    }
}
