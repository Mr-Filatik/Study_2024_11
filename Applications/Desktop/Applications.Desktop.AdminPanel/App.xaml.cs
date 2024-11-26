using Applications.Desktop.AdminPanel.Configuration;
using Applications.Desktop.AdminPanel.ViewModels;
using Applications.Desktop.AdminPanel.ViewModels.Abstract;
using Microsoft.Extensions.DependencyInjection;
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
            var services = new ServiceCollection();

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
