using System.Windows;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for ReviewWindow.xaml
    /// </summary>
    public partial class ReviewWindow : Window
    {
        public ReviewWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            CostumerMediaWindow costumerMediaWindow = new();
            costumerMediaWindow.Show();
            Close();
        }
    }
}
