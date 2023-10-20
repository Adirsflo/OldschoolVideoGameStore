using System.Windows;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            CreateCustomerWindow createCustomerWindow = new();
            createCustomerWindow.Show();
            Close();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (cbxAdminLogin.IsChecked == true)
            {
                if (txtUsername.Text == "admin" && txtPassword.Password == "password")
                {
                    AdminWindow adminWindow = new();
                    adminWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!", "Invalid login");
                }
            }
            else
            {
                if (txtUsername.Text == "username" && txtPassword.Password == "password")
                {
                    CostumerWindow costumerWindow = new();
                    costumerWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!", "Invalid login");
                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
