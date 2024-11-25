using Applications.Desktop.AdminPanel.ViewModels;
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
        protected override void OnStartup(StartupEventArgs e)
        {
            LoginWindow window = new LoginWindow();
            window.DataContext = new LoginViewModel();
            window.Show();
        }
    }
}
