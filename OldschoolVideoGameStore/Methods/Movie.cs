namespace OldschoolVideoGameStore.Methods
{
    public class Movie : MovieGenre, IMedia
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }
        public int NumRatings { get; set; }
        public string Genre { get; set; }
        public Customer Renter { get; set; }
        public bool IsRentedOut { get; set; }
        public bool IsRRated { get; set; }

        public string Bio { get; set; }

        public Movie(string name, int year, double rating, int numRatings, string genre, Customer renter, bool isRentedOut, bool isRRated, string bio)
        {
            Name = name;
            Year = year;
            Rating = rating;
            NumRatings = numRatings;
            Genre = genre;
            Renter = renter;
            IsRentedOut = isRentedOut;
            IsRRated = isRRated;
            Bio = bio;
        }
        public string GetInfo()
        {
            return "";
        }
    }
}
