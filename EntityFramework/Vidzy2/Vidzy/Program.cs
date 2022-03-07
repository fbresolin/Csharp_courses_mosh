

using System.Linq;
using System;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            Console.WriteLine("Action movies sorted by name");
            var videos = context.Videos
                .Where(v => v.Genre.Name == "Action")
                .OrderBy(v => v.Name);
            foreach (var video in videos)
                Console.WriteLine(video.Name);
            Console.WriteLine(" ");

            Console.WriteLine("Gold drama movies sorted by release date (newest first)");
            videos = context.Videos
                .Where(v => v.Genre.Name == "Drama")
                .Where(v => v.Classification == Classification.Gold)
                .OrderByDescending(v => v.ReleaseDate);
            foreach (var video in videos)
                Console.WriteLine(video.Name);
            Console.WriteLine(" ");

            Console.WriteLine("All movies projected into an anonymous type with two properties: MovieName and Genre");
            var videos2 = context.Videos
                .Select(v => new
                {
                    MovieName = v.Name,
                    Genre = v.Genre.Name
                });
            foreach (var video in videos2)
            {
                Console.WriteLine($"{video.MovieName} - {video.Genre}");
            }
            Console.WriteLine(" ");

            Console.WriteLine("All movies grouped by their classification");
            var groups = context.Videos
                .GroupBy(v => v.Classification)
                .Select(g => new
                {
                    Classification = g.Key,
                    Videos = g.OrderBy(v => v.Name)
                });
            foreach (var group in groups)
            {
                Console.WriteLine(group.Classification);
                foreach (var video in group.Videos)
                {
                    Console.WriteLine($"\t{video.Name}");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("List of classifications sorted alphabetically and count of videos in them");
            var groups2 = context.Videos
                .GroupBy(v => v.Classification)
                .Select(g => new
                {
                    Classification = g.Key,
                    Counter = g.Count()
                })
                .OrderBy(g => g.Classification.ToString());
            foreach (var group in groups2)
            {
                Console.WriteLine($"{group.Classification} ({group.Counter})");
            }
            Console.WriteLine(" ");

            Console.WriteLine("List of genres and number of videos they include, sorted by the number of videos");
            var groups3 = context.Genres
                .Select(g => new
                {
                    Genre = g.Name,
                    Counters = g.Videos.Count()
                })
                .OrderByDescending(g => g.Counters);
            foreach (var group in groups3)
            {
                Console.WriteLine($"{group.Genre} ({group.Counters})");
            }
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
