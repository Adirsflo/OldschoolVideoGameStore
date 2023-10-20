using System.Windows;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for AddMediaWindow.xaml
    /// </summary>
    public partial class AddMediaWindow : Window
    {
        public AddMediaWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new();
            adminWindow.Show();
            Close();

            // TODO: Fixa till sen så att det är rätt  
            /*
            if (txtNewUsername.Text != "" || txtNewFirstName.Text != "" || txtNewLastName.Text != "" || txtNewAge.Text != "" || txtNewPassword.Password != "" || txtConfirmPassword.Password != "")
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to cancel?\n\nYour progress will not be saved!", "Warning", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    MainWindow mainWindow = new();
                    mainWindow.Show();
                    Close();
                }
            }
            else
            {
                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();
            }*/
        }
    }
}
