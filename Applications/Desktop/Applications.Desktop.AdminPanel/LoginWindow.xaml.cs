using Applications.Desktop.AdminPanel.ViewModels.Abstract;
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
        public LoginWindow(IViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
            viewModel.MessageBoxYesNo += ShowMessageBoxYesNo;
        }

        private bool ShowMessageBoxYesNo(string message, string title)
        {
            var res = MessageBox.Show(message, title, MessageBoxButton.YesNo);
            return res == MessageBoxResult.Yes;
        }
    }
}
