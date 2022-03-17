
using System;
using System.Linq;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            // first
            AddVideo("Terminator 1", "Action", "26/10/1984", Classification.Silver);

            // second
            AddTag("Classics");
            AddTag("Drama");

            // third
            AddTag("Classics");
            AddTag("Drama");
            AddTag("Comedy");
            AddTagVideo(1, "Classics");
            AddTagVideo(1, "Drama");
            AddTagVideo(1, "Comedy");

            // fourth
            RemoveTagVideo(1, "Comedy");

            // fifth
            RemoveVideo(1);

            // sixth
            RemoveVideoGenre("Action");
        }

        public static void AddVideo(
            string name, 
            string genre, 
            string releasedDate, 
            Classification classification)
        {
            using (var context = new VidzyContext())
            {
                if (context.Videos.SingleOrDefault(v => v.Name == name) != null)
                {
                    Console.WriteLine("Title already  in database");
                    return;
                }
                Video video = new Video();
                video.Name = name;
                video.ReleaseDate = DateTime.Parse(releasedDate);
                video.Classification = classification;
                Genre genreObj = context.Genres.SingleOrDefault(g => g.Name == genre);
                if (genreObj != null)
                {
                    video.Genre = genreObj;
                    context.Videos.Add(video);
                    context.SaveChanges();
                }
            }
        }
        public static Tag AddTag(string tagName)
        {
            using (var context = new VidzyContext())
            {
                Tag tagObj = context.Tags.SingleOrDefault(t => t.Name == tagName);
                if (tagObj != null)
                {
                    Console.WriteLine("Tag already is in database");
                    return tagObj;
                }
                tagObj = new Tag();
                tagObj.Name = tagName;
                context.Tags.Add(tagObj);
                context.SaveChanges();
                return tagObj;
            }
        }

        public static void AddTagVideo(int videoId, string tagName)
        {
            using (var context = new VidzyContext())
            {
                var video = context.Videos.Find(videoId);
                if (video == null)
                {
                    Console.WriteLine("Video id does not exist");
                    return;
                }
                var tagObj = context.Tags.FirstOrDefault(t => t.Name == tagName);
                if (tagObj == null)
                    throw new ArgumentNullException(tagName,"tagName does not exist");
                video.AddTag(tagObj);
                context.SaveChanges();
            }
        }

        public static void RemoveTagVideo(int videoId, string tagName)
        {
            using(var context = new VidzyContext())
            {
                var video = context.Videos.Find(videoId);
                if (video == null)
                {
                    Console.WriteLine("Video id does not exist");
                    return;
                }
                var tagObj = context.Tags.FirstOrDefault(t => t.Name == tagName);
                video.RemoveTag(tagObj.Name);
                context.SaveChanges();
            }
        }

        public static void RemoveVideo(int videoId)
        {
            using(var context = new VidzyContext())
            {
                var video = context.Videos.Find(videoId);
                if (video == null)
                {
                    Console.WriteLine("Video id does not exist");
                    return;
                }
                context.Videos.Remove(video);
                context.SaveChanges();
            }
        }

        public static void RemoveVideoGenre(string genre)
        {
            using (var context = new VidzyContext())
            {
                var genreObj = context.Genres.FirstOrDefault(g => g.Name == genre);
                if (genreObj == null)
                {
                    Console.WriteLine("Genre does not exist");
                    return;
                }
                context.Videos.RemoveRange(genreObj.Videos);
                context.Genres.Remove(genreObj);
                context.SaveChanges();
            }
        }
    }
}
