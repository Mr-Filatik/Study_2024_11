using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for ElementsWindow.xaml
    /// </summary>
    public partial class ElementsWindow : Window
    {
        public ElementsWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleButtonClick(object sender, RoutedEventArgs e)
        {
            var toggle = sender as ToggleButton;
            if (toggle.IsChecked == true)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }

        private void RadioButtonCheck(object sender, RoutedEventArgs e)
        {
            var radio = sender as RadioButton;
            if (radio != null && radio.IsChecked == true)
            {
                MessageBox.Show(radio.Content.ToString());
            }
        }
    }
}
