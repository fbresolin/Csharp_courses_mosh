using System;
using System.Data.Entity;
using System.Linq;


namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            var videos = context.Videos.Include("Genre");

            foreach (var video in videos)
            {
                Console.WriteLine($"Video name: {video.Name}, Genre Name: {video.Genre.Name}");
            }
            Console.ReadLine(); 
        }
    }
}
