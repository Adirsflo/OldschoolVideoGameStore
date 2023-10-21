﻿namespace OldschoolVideoGameStore.Methods
{
    public class Game : GamesGenre, IMedia
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public int NumRatings { get; set; }
        public string Genre { get; set; }
        public Customer Renter { get; set; }
        public bool IsRentedOut { get; set; }
        public bool IsRRated { get; set; }

        public string GetInfo()
        {
            return "";
        }
    }
}
