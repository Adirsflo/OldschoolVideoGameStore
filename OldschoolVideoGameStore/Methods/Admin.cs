namespace OldschoolVideoGameStore.Methods
{
    public class Admin : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public Admin(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }

        public void LogIn()
        {

        }
        public void LogOut()
        {

        }
        public void AddMedia()
        {

        }
        public void RemoveMedia()
        {

        }
    }
}
