using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool isUserLoggedIn = false; // Static variable

        public MainWindow()
        {
            InitializeComponent();
            CheckLoginStatus();
        }

        private void CheckLoginStatus()
        {
            if (!isUserLoggedIn)
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();

                // Assuming LoginWindow sets a property or calls a method to indicate successful login
                if (isUserLoggedIn)
                {
                    // User successfully logged in, show the main window

                   
                }
                else
                {
                                       // Close the main window if the user fails to log in
                    this.Close();
                }
            }
        }
    }
}