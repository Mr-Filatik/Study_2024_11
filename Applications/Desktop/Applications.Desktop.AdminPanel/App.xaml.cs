using Applications.Desktop.AdminPanel.ViewModels;
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
            //LoginNewWindow window = new LoginNewWindow(new LoginViewModel());
            //LoginWindow window = new LoginWindow(new LoginViewModel());
            LoginWindow window = new LoginWindow(new LoginNewViewModel());
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }
}
