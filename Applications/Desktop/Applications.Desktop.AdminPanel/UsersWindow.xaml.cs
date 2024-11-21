using Study_2024_11.Shared.Entities;
using System.Windows;

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        User user = new User()
        {
            Id = 1,
            FirstName = "Test",
            SecondName = "TestTest",
            Age = 20,
            Gender = null
        };

        public UsersWindow()
        {
            InitializeComponent();

            this.DataContext = user;
        }

        private void GetUserDataClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Id:{user.Id},FirstName:{user.FirstName},SecondName:{user.SecondName}.");
        }
    }
}
