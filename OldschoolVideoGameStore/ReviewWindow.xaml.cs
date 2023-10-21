using OldschoolVideoGameStore.Managers;
using System.Windows;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for ReviewWindow.xaml
    /// </summary>
    public partial class ReviewWindow : Window
    {
        string costumerUsername;
        public ReviewWindow(string costumerUsername)
        {
            InitializeComponent();
            this.costumerUsername = costumerUsername;

            foreach (var costumer in UserManager.userList)
            {
                if (costumer.Username == costumerUsername)
                {
                    lblTitle.Content = costumerUsername;
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            CostumerMediaWindow costumerMediaWindow = new(costumerUsername);
            costumerMediaWindow.Show();
            Close();
        }
    }
}
