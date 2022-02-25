using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    public enum ClassesLevelC
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3,
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new PlutoDbContext();

            var blibli = dbContext.GetAuthorCourses(1);
            
            var courses = dbContext.GetCourses();
            foreach(var course in courses)
            {
                Console.WriteLine(course);
            }

            var ccourse = new Course();
        }
    }
}
