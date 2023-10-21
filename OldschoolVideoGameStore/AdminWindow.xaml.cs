using OldschoolVideoGameStore.Managers;
using System.Windows;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        string adminUsername;
        public AdminWindow(string adminUsername)
        {
            InitializeComponent();
            this.adminUsername = adminUsername;

            // Jag vill Koppla samman användarnamnet till någon från listan

            foreach (var admin in UserManager.userList)
            {
                if (admin.Username == adminUsername)
                {
                    lblWelcome.Content += admin.FullName + "!";
                }
            }
        }

        private void btnAddMedia_Click(object sender, RoutedEventArgs e)
        {
            AddMediaWindow addMediaWindow = new(adminUsername);
            addMediaWindow.Show();
            Close();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to log out?", "Exit", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();
            }
        }
    }
}
