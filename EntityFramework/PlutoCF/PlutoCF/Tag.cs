using System.Collections.Generic;

namespace PlutoCF
{
    public class Tag 
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }

    }
}
