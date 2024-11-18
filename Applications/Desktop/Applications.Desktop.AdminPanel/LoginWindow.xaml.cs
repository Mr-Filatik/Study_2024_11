using System.Windows;

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Привет, мир!", "Приветсвенное окно", MessageBoxButton.YesNo, MessageBoxImage.Error);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Да", startButton.Content.ToString());
            }
            else
            {
                MessageBox.Show("Нет", startButton.Content.ToString());
            }

            //Ctrl + K, Ctrl + D - выравнивание кода по стилю
            //Ctrl + R, Ctrl + G - удаление и упорядочивание using'ов

            //Test comment
        }
    }
}
