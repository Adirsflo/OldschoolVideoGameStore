using System.Windows;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void btnAddMedia_Click(object sender, RoutedEventArgs e)
        {
            AddMediaWindow addMediaWindow = new();
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
