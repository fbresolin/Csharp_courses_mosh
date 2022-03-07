namespace CodeFirstExistingDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Course
    {
        public Course()
        {
            Tags = new HashSet<Tags>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public float FullPrice { get; set; }
        public int? Author_Id { get; set; }
        public virtual Author Authors { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
    }
}
