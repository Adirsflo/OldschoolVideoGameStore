using OldschoolVideoGameStore.Methods;
using System.Windows;
using System.Windows.Controls;

namespace OldschoolVideoGameStore
{
    /// <summary>
    /// Interaction logic for ReviewWindow.xaml
    /// </summary>
    public partial class ReviewWindow : Window
    {
        IMedia selectedMedia;
        string costumerUsername;
        bool m_bChkUpdating = false;
        bool m_bUnChkUpdating = false;
        public ReviewWindow(IMedia selectedMedia, string costumerUsername)
        {
            InitializeComponent();
            this.costumerUsername = costumerUsername;
            this.selectedMedia = selectedMedia;

            lblTitle.Content = selectedMedia.Name;
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (bxRate1.IsChecked == false)
            {
                MessageBox.Show("Please leave a rating from 1-5", "Warning");
            }
            else
            {
                if (txtReview.Text == "")
                {
                    MessageBoxResult result = MessageBox.Show("Are you sure you want to leave an empty rating?", "Warning", MessageBoxButton.YesNo);

                    if (result == MessageBoxResult.Yes)
                    {
                        CalculateNewRating();
                        MessageBox.Show("Thank you for leaving your rating!", "Rating submitted");
                        CostumerMediaWindow costumerMediaWindow = new(costumerUsername);
                        costumerMediaWindow.Show();
                        Close();
                    }
                }
                else
                {
                    CalculateNewRating();
                    MessageBox.Show("Thank you for leaving your rating!", "rating submitted");
                    CostumerMediaWindow costumerMediaWindow = new(costumerUsername);
                    costumerMediaWindow.Show();
                    Close();
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you don't want to leave a rating?", "Warning", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                CostumerMediaWindow costumerMediaWindow = new(costumerUsername);
                costumerMediaWindow.Show();
                Close();
            }
        }

        public void CalculateNewRating()
        {
            selectedMedia.NumRatings = CheckingRating();

            selectedMedia.NumRatingsCount++;

            selectedMedia.Rating = (selectedMedia.NumRatings / selectedMedia.NumRatingsCount);
        }

        public int CheckingRating()
        {

            if (bxRate1.IsChecked == true && bxRate2.IsChecked == false && bxRate3.IsChecked == false && bxRate4.IsChecked == false && bxRate5.IsChecked == false)
            {
                return 1;
            }
            else if (bxRate1.IsChecked == true && bxRate2.IsChecked == true && bxRate3.IsChecked == false && bxRate4.IsChecked == false && bxRate5.IsChecked == false)
            {
                return 2;
            }
            else if (bxRate1.IsChecked == true && bxRate2.IsChecked == true && bxRate3.IsChecked == true && bxRate4.IsChecked == false && bxRate5.IsChecked == false)
            {
                return 3;
            }
            else if (bxRate1.IsChecked == true && bxRate2.IsChecked == true && bxRate3.IsChecked == true && bxRate4.IsChecked == true && bxRate5.IsChecked == false)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        private void bxRate_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if (!m_bChkUpdating)
            {
                m_bChkUpdating = true;
                switch (chk.Name)
                {
                    case "bxRate1":
                        bxRate2.IsChecked = false;
                        bxRate3.IsChecked = false;
                        bxRate4.IsChecked = false;
                        bxRate5.IsChecked = false;
                        break;
                    case "bxRate2":
                        bxRate1.IsChecked = true;
                        bxRate3.IsChecked = false;
                        bxRate4.IsChecked = false;
                        bxRate5.IsChecked = false;
                        break;
                    case "bxRate3":
                        bxRate1.IsChecked = true;
                        bxRate2.IsChecked = true;
                        bxRate4.IsChecked = false;
                        bxRate5.IsChecked = false;
                        break;
                    case "bxRate4":
                        bxRate1.IsChecked = true;
                        bxRate2.IsChecked = true;
                        bxRate3.IsChecked = true;
                        bxRate5.IsChecked = false;
                        break;
                    case "bxRate5":
                        bxRate1.IsChecked = true;
                        bxRate2.IsChecked = true;
                        bxRate3.IsChecked = true;
                        bxRate4.IsChecked = true;
                        break;
                    default:
                        break;
                }
                m_bChkUpdating = false;
            }
        }

        private void bxRate_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (!m_bUnChkUpdating)
            {
                m_bUnChkUpdating = true;

                switch (chk.Name)
                {
                    case "bxRate1":
                        bxRate2.IsChecked = false;
                        bxRate3.IsChecked = false;
                        bxRate4.IsChecked = false;
                        bxRate5.IsChecked = false;
                        break;
                    case "bxRate2":
                        bxRate1.IsChecked = true;
                        bxRate3.IsChecked = false;
                        bxRate4.IsChecked = false;
                        bxRate5.IsChecked = false;
                        break;
                    case "bxRate3":
                        bxRate1.IsChecked = true;
                        bxRate2.IsChecked = true;
                        bxRate4.IsChecked = false;
                        bxRate5.IsChecked = false;
                        break;
                    case "bxRate4":
                        bxRate1.IsChecked = true;
                        bxRate2.IsChecked = true;
                        bxRate3.IsChecked = true;
                        bxRate5.IsChecked = false;
                        break;
                    case "bxRate5":
                        bxRate1.IsChecked = true;
                        bxRate2.IsChecked = true;
                        bxRate3.IsChecked = true;
                        bxRate4.IsChecked = true;
                        break;
                    default:
                        break;
                }

                m_bUnChkUpdating = false;
            }
        }

    }
}
