using OldschoolVideoGameStore.Managers;
using OldschoolVideoGameStore.Methods;
using System;
using System.Windows;

namespace OldschoolVideoGameStore
{
    public partial class CreateCustomerWindow : Window
    {
        public CreateCustomerWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (txtNewUsername.Text != "" || txtNewFirstName.Text != "" || txtNewLastName.Text != "" || txtNewAge.Text != "" || txtNewPassword.Password != "" || txtConfirmPassword.Password != "")
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to cancel?\n\nYour progress will not be saved!", "Warning", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    MainWindow mainWindow = new();
                    mainWindow.Show();
                    Close();
                }
            }
            else
            {
                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();
            }
        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            // Samla variabler
            string username = txtNewUsername.Text.ToLower();
            string firstName = txtNewFirstName.Text;
            string lastName = txtNewLastName.Text;
            string ageString = txtNewAge.Text;
            string newPassword = txtNewPassword.Password;
            string confirmPassword = txtConfirmPassword.Password;

            // Kolla så att Username inte redan finns, och att man inte gör ett username med Admin
            bool isAvailableAccount = CheckingAvailableUsername(username);

            if (isAvailableAccount)
            {
                // Kolla om ålder inte är i bokstäver
                if (!CheckingValidFormat(ageString))
                {
                    MessageBox.Show("Invalid age-input. Please write numbers", "Invalid age");
                }
                else
                {
                    int age = ConvertingAgeToInt(ageString);

                    // Kolla så att lösenordet passar varandra
                    if (newPassword != confirmPassword)
                    {
                        MessageBox.Show("Password doesn't match! Please try again!", "Invalid password");
                    }
                    else
                    {
                        // Om allt stämmer, Lägg till användaren i UserManager listan

                        Customer newCustomer = new(username, newPassword, firstName, lastName, age);

                        newCustomer.FirstName = firstName;
                        newCustomer.LastName = lastName;
                        newCustomer.Age = age;

                        UserManager.userList.Add(new Customer(username, newPassword, firstName, lastName, age));

                        // Skicka ett meddelande till användaren "Account created! Welcome!"

                        MessageBox.Show("Successfully registered new user! Welcome!", "New account created");

                        // Stäng fönstret och öppna MainWindow
                        MainWindow mainWindow = new();
                        mainWindow.Show();
                        Close();
                    }
                }
            }
            else
            {
                // Ifall det finns ... "The username is already in use" varning
                MessageBox.Show("The username is already in use", "Invalid username");
            }
        }

        private bool CheckingAvailableUsername(string username)
        {
            // Kolla så att Username inte redan finns, och att man inte gör ett username med Admin

            foreach (var user in UserManager.userList)
            {
                if (username == user.Username || username == "admin")
                {
                    return false;
                }
            }
            return true;
        }

        private int ConvertingAgeToInt(string ageString)
        {
            int age = Convert.ToInt32(ageString);
            return age;
        }

        private bool CheckingValidFormat(string age)
        {
            bool isInt = int.TryParse(age, out int number);

            return isInt;
        }
    }
}
