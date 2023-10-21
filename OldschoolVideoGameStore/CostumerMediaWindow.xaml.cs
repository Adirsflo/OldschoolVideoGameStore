using OldschoolVideoGameStore.Managers;
using System.Windows;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for CostumerMediaWindow.xaml
    /// </summary>
    public partial class CostumerMediaWindow : Window
    {
        string costumerUsername;
        public CostumerMediaWindow(string costumerUsername)
        {
            InitializeComponent();
            this.costumerUsername = costumerUsername;


            foreach (var costumer in UserManager.userList)
            {
                if (costumerUsername == costumer.Username)
                {
                    lblDisplayName.Content = costumer.FullName;
                }
            }
        }

        private void blkLibrary_Click(object sender, RoutedEventArgs e)
        {
            CostumerWindow costumerWindow = new(costumerUsername);
            costumerWindow.Show();
            Close();
        }

        private void btnRateMedia_Click(object sender, RoutedEventArgs e)
        {
            ReviewWindow reviewWindow = new(costumerUsername);
            reviewWindow.Show();
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
