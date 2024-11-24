using Applications.Desktop.AdminPanel.Configuration;
using Applications.Desktop.AdminPanel.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Hour)
                .CreateLogger();

            serviceCollection.AddSerilog();
            serviceCollection.AddLogging(opt => opt.AddSerilog(Log.Logger));

            var logger = new SerilogLoggerProvider(Log.Logger).CreateLogger($"{nameof(App)}.Services.Configuration");

            logger.LogWarning("Register is OK!");

            serviceCollection.RegisterViews();
            serviceCollection.RegisterViewModels();

            
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var window = _serviceProvider.GetRequiredService<LoginWindow>();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }

        /// <summary>
        /// Generics method to open window with link to viewmodel
        /// </summary>
        /// <param name="closeWindow">Action to close the window (default null)</param>
        //public void OpenWindow<TWindow, TViewModel>(Action? closeWindow = null)
        //    where TWindow : Window, new()
        //    where TViewModel : ViewModel, new()
        //{
        //    TWindow window = new TWindow();
        //    TViewModel viewModel = new TViewModel();
        //    viewModel.CloseWindow = new Action(window.Close);
        //    window.DataContext = viewModel;
        //    window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        //    window.Show();
        //    closeWindow?.Invoke();
        //}
    }
}
