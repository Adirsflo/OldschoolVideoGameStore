using OldschoolVideoGameStore.Managers;
using OldschoolVideoGameStore.Methods;
using System.Windows;
using System.Windows.Controls;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for CostumerWindow.xaml
    /// </summary>
    public partial class CostumerWindow : Window
    {
        string costumerUsername;
        public CostumerWindow(string costumerUsername)
        {
            InitializeComponent();
            this.costumerUsername = costumerUsername;

            UpdateUi();
        }

        public void UpdateUi()
        {
            lstGameLibrary.Items.Clear();
            lstMovieLibrary.Items.Clear();

            // Uppdaterar Titelsida
            foreach (var costumer in UserManager.userList)
            {
                if (costumer.Username == costumerUsername)
                {
                    lblWelcome.Content += costumer.FullName + "!";
                }
            }

            // Uppdaterar biblioteket
            foreach (var media in MediaManager.mediaList)
            {
                if (media.GetType() == typeof(Movie))
                {
                    ListViewItem movieItem = new();

                    movieItem.Content = new
                    {
                        Title = media.Name,
                        Year = media.Year,
                        Genre = media.Genre,
                        isRRated = media.IsRRated,
                        Rating = media.Rating,
                        isAvailable = !media.IsRentedOut
                    };
                    movieItem.Tag = MediaManager.mediaList;

                    lstMovieLibrary.Items.Add(movieItem);
                }
                else if (media.GetType() == typeof(Game))
                {
                    ListViewItem gameItem = new();
                    gameItem.Content = new
                    {
                        Title = media.Name,
                        Year = media.Year,
                        Genre = media.Genre,
                        isRRated = media.IsRRated,
                        Rating = media.Rating,
                        isAvailable = !media.IsRentedOut
                    };

                    lstGameLibrary.Items.Add(gameItem);
                }
            }
        }

        private void blkMyMedia_Click(object sender, RoutedEventArgs e)
        {
            CostumerMediaWindow costumerMediaWindow = new(costumerUsername);
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

        private void lstMovieLibrary_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ListBoxItem selectedMovieItem = (ListBoxItem)lstMovieLibrary.SelectedItem;

            if (selectedMovieItem != null)
            {
                btnRentMovie.IsEnabled = true;
            }
        }

        private void lstGameLibrary_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ListBoxItem selectedGameItem = (ListBoxItem)lstGameLibrary.SelectedItem;

            if (selectedGameItem != null)
            {
                btnRentGame.IsEnabled = true;
            }
        }

        private void btnRentMovie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRentGame_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selectedGameItem = (ListBoxItem)lstGameLibrary.SelectedItem;
            Game selectedGame = (Game)selectedGameItem.Tag;
            ListViewItem userItem = new();

            if (selectedGame != null)
            {
                if (selectedGame.IsRentedOut == false)
                {
                    RentGame(selectedGame);

                    MessageBox.Show("Game rented!");

                    UpdateUi();

                    // Lägg till spelet hos användaren
                }
                else
                {
                    MessageBox.Show("This game is not available", "Out of stock");
                }
            }
        }

        public void RentGame(Game selectedGame)
        {
            // Ändra från available till unavailable på spelet
            foreach (var game in MediaManager.mediaList)
            {
                if (game == selectedGame)
                {
                    foreach (var user in UserManager.userList)
                    {
                        if (user.Username == costumerUsername)
                        {
                            Customer userGame = (Customer)user;
                            game.Renter = userGame;
                        }
                    }
                }
            }
        }
    }
}
