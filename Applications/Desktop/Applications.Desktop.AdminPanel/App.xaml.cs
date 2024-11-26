using Applications.Desktop.AdminPanel.Configuration;
using Applications.Desktop.AdminPanel.ViewModels;
using Applications.Desktop.AdminPanel.ViewModels.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System.Windows;

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Hour, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            var services = new ServiceCollection();

            services.AddSerilog(Log.Logger);
            services.AddLogging(opt => opt.AddSerilog(Log.Logger));

            services.RegisterViews();
            services.RegisterViewModels();

            services.AddSingleton<ApplicationUser>();

            _serviceProvider = services.BuildServiceProvider();

            var window = _serviceProvider.GetRequiredService<LoginWindow>();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }

        public void OpenUserWindow()
        {
            _serviceProvider.GetRequiredService<UsersWindow>().Show();
        }
    }

    public class ApplicationUser
    {
        public string Name { get; set; } = Guid.NewGuid().ToString();
    }
}
