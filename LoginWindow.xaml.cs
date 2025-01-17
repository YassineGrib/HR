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

namespace HR
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            LoadUsernames();
        }

        private void LoadUsernames()
        {
            // Load usernames from the database and add them to the ComboBox
            // Example:
            // UsernameComboBox.ItemsSource = GetUsernamesFromDatabase();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedUsername = UsernameComboBox.Text;
            string password = PasswordBox.Password;

            // Perform login logic here
            // Example:
            // if (AuthenticateUser(selectedUsername, password))
            // {
            //     // Login successful
            // }
            // else
            // {
            //     MessageBox.Show("Invalid username or password");
            // }
        }
    }
}