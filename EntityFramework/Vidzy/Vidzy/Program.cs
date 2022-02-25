using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    internal class Program
    {
        static void Main()
        {
            var dbcontext = new VidzyDbContext();
            dbcontext.AddVideo("Matrix 6", DateTime.Today, "Romance", "Gold");
        }
    }
}
