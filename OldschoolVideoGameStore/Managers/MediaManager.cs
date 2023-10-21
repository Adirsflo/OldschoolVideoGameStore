using OldschoolVideoGameStore.Methods;
using System.Collections.Generic;

namespace OldschoolVideoGameStore.Managers
{
    public static class MediaManager
    {
        public static List<IMedia> mediaList = new()
        {
            // Games
            new Movie("God of War", 2018, 8.9, 0, "Action", null, false, false, "\"God of War\" (2018) is an acclaimed action-adventure video game that reimagines the iconic series. Developed by Santa Monica Studio and exclusively available on PlayStation 4 and PlayStation 5, it marks a significant shift in tone and gameplay for the series. Players follow Kratos, the former Greek god of war, as he embarks on a journey with his young son, Atreus, through the realms of Norse mythology.\r\n\r\nWith its breathtaking visuals, deep storytelling, and intense combat, \"God of War\" earned widespread critical acclaim, including numerous Game of the Year awards. It's rated M (Mature) due to its graphic violence and themes, making it suitable for adult gamers. Dive into a mythic and emotionally charged adventure in the world of Norse gods with \"God of War.\""),
            new Movie("Assassin's Creed", 2007, 7.9, 0, "Action", null, false, false, "\"Assassin's Creed,\" first released in 2007, is a renowned action-adventure and stealth video game series that has left an indelible mark on the gaming world. Developed by Ubisoft, the series weaves a complex narrative across various historical settings, featuring the eternal conflict between Assassins and Templars."),
            new Movie("Far Cry 5", 2018, 8.0, 0, "FPS", null, false, false, "\"Far Cry 5,\" released in 2018, is a first-person shooter and open-world adventure game that takes players to the fictional Hope County, Montana. Developed by Ubisoft, this installment in the Far Cry series immerses players in a captivating and chaotic world controlled by a dangerous cult known as the Project at Eden's Gate."),

            // Movies
            new Movie("Shutter Island", 2010, 8.1, 0, "Mystery", null, false, true, "\"Shutter Island\" is a 2010 mystery thriller directed by Martin Scorsese, featuring an initial rating of 8.1. Starring Leonardo DiCaprio, the film follows U.S. Marshal Teddy Daniels as he investigates the disappearance of a patient from a mental institution on a remote island. With its intense mystery and psychological intrigue, it's a compelling R-rated movie. Rent it and share your thoughts!"),
            new Movie("Inception", 2010, 8.8, 0, "Action", null, false, false, "Christopher Nolan's 2010 sci-fi masterpiece, \"Inception,\" holds an impressive 8.8 rating. It's a mind-bending exploration of dreams and reality, led by a stellar cast including Leonardo DiCaprio. With its action-packed plot and imaginative storytelling, \"Inception\" is a must-see for any film enthusiast. This PG-13 rated film offers a thrilling journey through the world of subconsciousness. Dive into your dreams with \"Inception.\""),
            new Movie("Star Wars: Episode IV - A New Hope", 1977, 8.6, 0, "ScienceFiction", null, false, false, "\"Star Wars: Episode IV - A New Hope,\" released in 1977, is a sci-fi and adventure classic with an impressive 8.6 rating. Directed by George Lucas, this iconic film introduced audiences to the epic Star Wars saga. It's a family-friendly adventure set in a galaxy far, far away, where a young farm boy, Luke Skywalker, embarks on a journey to save the galaxy from the evil Empire. With its timeless story and memorable characters, \"A New Hope\" is a beloved, PG-rated masterpiece that continues to captivate generations of fans. May the Force be with you!"),
        };
    }
}
selectedMovieselectedMovieselectedMovieselectedMovieselectedMovieselect