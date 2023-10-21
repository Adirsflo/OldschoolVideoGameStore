namespace OldschoolVideoGameStore.Methods
{
    public class Customer : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public Customer(string username, string password, string firstName, string lastName, int age)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void LogIn()
        {

        }
        public void LogOut()
        {

        }
        public void RentMedia()
        {

        }
        public void ReturnMedia()
        {

        }
        public void RateMedia()
        {

        }
    }
}
