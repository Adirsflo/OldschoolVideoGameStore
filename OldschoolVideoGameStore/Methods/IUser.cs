namespace OldschoolVideoGameStore.Methods
{
    public interface IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public void LogIn();
        public void LogOut();
    }
}
