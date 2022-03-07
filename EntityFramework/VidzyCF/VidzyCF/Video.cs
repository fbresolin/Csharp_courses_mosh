using System;
using System.Collections.Generic;

namespace VidzyCF
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleasedData { get; set; }
        public Genre Genre { get; set; }
        public Classification Classification { get; set; }
        public byte GenreId { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
