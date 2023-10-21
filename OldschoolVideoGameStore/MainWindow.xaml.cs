using OldschoolVideoGameStore.Managers;
using OldschoolVideoGameStore.Methods;
using System.Windows;

namespace OldschoolVideoGameStore
{
    public partial class MainWindow : Window
    {
        Admin _admin;
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
            if (cbxAdminLogin.IsChecked == true) // Inloggning för Admin
            {
                foreach (var admin in UserManager.userList)
                {
                    if (txtUsername.Text.ToLower() == admin.Username && txtPassword.Password.ToLower() == admin.Password)
                    {
                        string adminUsername = admin.Username;

                        AdminWindow adminWindow = new(adminUsername);
                        adminWindow.Show();
                        Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password!", "Invalid login");
                    }
                }
            }
            else // Inloggning för Customer
            {
                if (UserManager.userList.Count == 1)
                {
                    MessageBox.Show("There are no registered accounts at this moment.\nCreate an account to rent movies/games", "Warning");
                }
                else
                {
                    bool isSameInput = true;
                    foreach (var user in UserManager.userList)
                    {
                        if (txtUsername.Text.ToLower() == user.Username && txtPassword.Password.ToLower() == user.Password && txtUsername.Text.ToLower() != "admin")
                        {
                            string costumerUsername = user.Username;
                            CostumerWindow costumerWindow = new(costumerUsername);
                            costumerWindow.Show();
                            Close();
                            isSameInput = false;
                        }
                    }
                    if (isSameInput)
                    {
                        MessageBox.Show("Wrong username or password!", "Invalid login");
                    }
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
