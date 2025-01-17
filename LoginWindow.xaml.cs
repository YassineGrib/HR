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
using HR.Classes;



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
            using (var context = new AppDbContext())
            {
                var usernames = context.Users.Select(u => u.Username).ToList();
                UsernameComboBox.ItemsSource = usernames;
            }
        }

        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            PasswordTextBox.Text = PasswordBox.Password;
            PasswordBox.Visibility = Visibility.Collapsed;
            PasswordTextBox.Visibility = Visibility.Visible;
        }

        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = PasswordTextBox.Text;
            PasswordBox.Visibility = Visibility.Visible;
            PasswordTextBox.Visibility = Visibility.Collapsed;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Visibility == Visibility.Visible)
            {
                PasswordTextBox.Text = PasswordBox.Password;
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedUsername = UsernameComboBox.SelectedItem as string;
            string password = PasswordBox.Password;

            if (string.IsNullOrEmpty(selectedUsername) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == selectedUsername);

                if (user == null)
                {
                    MessageBox.Show("Invalid username.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (user.Password != password)
                {
                    MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                // Proceed to the next window or main application
            }
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
