using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueryable<Course> a;
            var y = a.Where(c => c.Level == 1).OrderBy(c => c.Name);
        }
    }
}
