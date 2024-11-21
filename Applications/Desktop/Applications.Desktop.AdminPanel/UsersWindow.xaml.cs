using Study_2024_11.Shared.Entities;
using System.Windows;

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        //User user = new User()
        //{
        //    Id = 1,
        //    FirstName = "Test",
        //    SecondName = "TestTest",
        //    Age = 20,
        //    Gender = null
        //};

        User[] users = new User[3]
        {
            new User()
            {
                Id = 1,
                FirstName = "Test1",
                SecondName = "TestTest1",
                Age = 20,
                Gender = null
            },
            new User()
            {
                Id = 2,
                FirstName = "Test2",
                SecondName = "TestTest2",
                Age = 22,
                Gender = true
            },
            new User()
            {
                Id = 3,
                FirstName = "Test3",
                SecondName = "TestTest3",
                Age = 24,
                Gender = false
            },
        };

        public UsersWindow()
        {
            InitializeComponent();

            usersDataGrid.ItemsSource = users;
            //this.DataContext = user;
        }

        private void GetUserDataClick(object sender, RoutedEventArgs e)
        {
            var user = usersDataGrid.SelectedItem as User;
            if (user != null)
            {
                MessageBox.Show($"Id:{user.Id},FirstName:{user.FirstName},SecondName:{user.SecondName}.");
            }
            //MessageBox.Show($"Id:{user.Id},FirstName:{user.FirstName},SecondName:{user.SecondName}.");
        }
    }
}
