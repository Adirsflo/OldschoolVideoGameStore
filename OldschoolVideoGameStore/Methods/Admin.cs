namespace OldschoolVideoGameStore.Methods
{
    public class Admin
    {
        public string FirstName { get; set; } = "Admin";
        public string LastName { get; set; } = "Adminsson";
        public string FullName { get { return FirstName + " " + LastName; } }
        public string Username { get; set; } = "admin";
        public string Password { get; set; } = "password";
        public int Age { get; set; } = 20;

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
