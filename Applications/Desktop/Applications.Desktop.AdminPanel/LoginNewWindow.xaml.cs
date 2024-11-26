using Applications.Desktop.AdminPanel.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for LoginNewWindow.xaml
    /// </summary>
    public partial class LoginNewWindow : Window
    {
        public LoginNewWindow(ILoginViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
            viewModel.MessageBoxYesNo += ShowMessageBoxYesNo;
        }

        private bool ShowMessageBoxYesNo(string message, string title)
        {
            var res = MessageBox.Show(message, title, MessageBoxButton.OKCancel);
            return res == MessageBoxResult.OK;
        }
    }
}
