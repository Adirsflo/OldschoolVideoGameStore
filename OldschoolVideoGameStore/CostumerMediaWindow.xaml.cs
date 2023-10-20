using System.Windows;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for CostumerMediaWindow.xaml
    /// </summary>
    public partial class CostumerMediaWindow : Window
    {
        public CostumerMediaWindow()
        {
            InitializeComponent();
        }

        private void blkLibrary_Click(object sender, RoutedEventArgs e)
        {
            CostumerWindow costumerWindow = new();
            costumerWindow.Show();
            Close();
        }

        private void btnRateMedia_Click(object sender, RoutedEventArgs e)
        {
            ReviewWindow reviewWindow = new();
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
