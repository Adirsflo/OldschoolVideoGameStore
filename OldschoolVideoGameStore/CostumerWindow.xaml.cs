using System.Windows;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for CostumerWindow.xaml
    /// </summary>
    public partial class CostumerWindow : Window
    {
        public CostumerWindow()
        {
            InitializeComponent();
        }



        private void blkMyMedia_Click(object sender, RoutedEventArgs e)
        {
            CostumerMediaWindow costumerMediaWindow = new();
            costumerMediaWindow.Show();
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
