using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            // add item
            var course = new Course()
            {
                Name = "New Course 3",
                Description = "New description",
                FullPrice = 19f,
                Level = 1,
                AuthorId = 1
            };
            context.Courses.Add(course);

            // edit item
            var course2 = context.Courses.Find(1);
            course2.Description = "lalalla";

            // delete item
            var course3 = context.Courses.Find(2);
            context.Courses.Remove(course3);

            var entries = context.ChangeTracker.Entries();

            foreach (var entry in entries)
            {
                entry.Reload();
                Console.WriteLine($"{entry.Entity}: {entry.State}");
            }

            Console.ReadLine();
        }
    }
}
