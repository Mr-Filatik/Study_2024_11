using Applications.Desktop.AdminPanel.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            
        }
        public LoginWindow(ViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
            viewModel.MessageBoxShow += MessageBoxShow;
        }

        private bool MessageBoxShow(string message, string title)
        {
            var res = MessageBox.Show(message, title, MessageBoxButton.YesNo, MessageBoxImage.Question);
            return res == MessageBoxResult.Yes;
        }
    }
}
