using System.Windows;
using System.Windows.Controls;

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

            //< Button Grid.Column = "0" Grid.Row = "3" Margin = "10" > ЗАБЫЛИ ПАРОЛЬ ?</ Button >
            //< Button Grid.Column = "1" Grid.Row = "3" Margin = "10" > РЕГИСТРАЦИЯ </ Button >

            var buttonOne = new Button()
            {
                Content = "ЗАБЫЛИ ПАРОЛЬ?",
                Margin = new Thickness(10),
            };
            var buttonTwo = new Button()
            {
                Content = "РЕГИСТРАЦИЯ",
                Margin = new Thickness(10),
            };
            mainGrid.Children.Add(buttonOne);
            Grid.SetColumn(buttonOne, 0);
            Grid.SetRow(buttonOne, 3);
            mainGrid.Children.Add(buttonTwo);
            Grid.SetColumn(buttonTwo, 1);
            Grid.SetRow(buttonTwo, 3);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var window = new ElementsWindow();
            window.Title = "ПРИВЕТ ЮЗЕР";
            window.Owner = this;
            window.Show();
            //Close(); // Закрытие текущего окна

            //var result = MessageBox.Show("Привет, мир!", "Приветсвенное окно", MessageBoxButton.YesNo, MessageBoxImage.Error);
            //if (result == MessageBoxResult.Yes)
            //{
            //    MessageBox.Show("Да", startButton.Content.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Нет", startButton.Content.ToString());
            //}

            //Ctrl + K, Ctrl + D - выравнивание кода по стилю
            //Ctrl + R, Ctrl + G - удаление и упорядочивание using'ов

            //Test comment
        }
    }
}
