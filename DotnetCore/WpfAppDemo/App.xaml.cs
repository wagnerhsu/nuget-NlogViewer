using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MeeHealth.NetStandard.NLogComponent;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WpfAppDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NLogService nLogService = new NLogService(Directory.GetCurrentDirectory());
            var host = nLogService.BuildHost(CreateHostBuilder);
            var mainWindow = host.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        public IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(configBuilder =>
                {
                    Configuration = configBuilder.Build();
                })
                .ConfigureServices(ConfigureServices);

        private static IConfiguration Configuration { get; set; }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(typeof(MainWindow));
        }
    }
}
