using OldschoolVideoGameStore.Managers;
using OldschoolVideoGameStore.Methods;
using System.Windows;
using System.Windows.Controls;

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


            //foreach (var costumer in UserManager.userList)
            //{
            //    if (costumerUsername == costumer.Username)
            //    {
            //        lblDisplayName.Content = costumer.FullName;
            //    }
            //}

            UpdateUi();
        }

        public void UpdateUi()
        {
            lstMyMedia.Items.Clear();

            // Uppdaterar Titelsida
            foreach (var costumer in UserManager.userList)
            {
                if (costumer.Username == costumerUsername)
                {
                    lblDisplayName.Content = costumer.FullName + "!";
                }
            }

            // Uppdaterar biblioteket

            // TODO: Du ska samla all media som är på ditt namn, i en lista. Du behöver se ifall Renter är på användarens namn
            // Ifall det är de så ska den in i listan och taggas

            foreach (var media in MediaManager.mediaList)
            {
                ListViewItem item = new();
                foreach (var user in UserManager.userList)
                {
                    if (user.Username == costumerUsername)
                    {
                        if (media.Renter == user)
                        {
                            item.Content = new
                            {
                                Title = media.Name,
                                Year = media.Year,
                                Genre = media.Genre,
                                isRRated = media.IsRRated,
                                Rating = media.Rating,
                                isAvailable = !media.IsRentedOut
                            };
                            item.Tag = media;

                            lstMyMedia.Items.Add(item);
                        }
                    }
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
            ListBoxItem selectedItem = (ListBoxItem)lstMyMedia.SelectedItem;

            if (selectedItem != null)
            {
                IMedia selectedMedia = (IMedia)selectedItem.Tag;

                ReviewWindow reviewWindow = new(selectedMedia, costumerUsername);
                reviewWindow.Show();
                Close();
            }

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

        private void lstMyMedia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstSelectedMedia.Clear();
            ListBoxItem selectedItem = (ListBoxItem)lstMyMedia.SelectedItem;

            if (selectedItem != null)
            {
                IMedia selectedMedia = (IMedia)selectedItem.Tag;

                lblTitle.Visibility = Visibility.Visible;
                lblTitle.Content = selectedMedia.Name;

                lstSelectedMedia.Text =
                    "Year: " + selectedMedia.Year +
                    "\nGenre: " + selectedMedia.Genre +
                    "\nR-Rated: " + selectedMedia.IsRRated +
                    "\nRating: " + selectedMedia.Rating +
                    "\n\nBio: " + selectedMedia.Bio;

                if (selectedMedia.GetType() == typeof(Game))
                {
                    lblMediaType.Visibility = Visibility.Visible;
                    lblMediaType.Content = "Game";
                }
                else
                {
                    lblMediaType.Visibility = Visibility.Visible;
                    lblMediaType.Content = "Movie";
                }


            }



        }
    }
}
