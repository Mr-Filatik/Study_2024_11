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
            //base.OnStartup(e);
            //OpenWindow<LoginWindow, LoginViewModel>();
            LoginViewModel viewModel = new LoginViewModel();
            LoginWindow window = new LoginWindow(viewModel);
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
