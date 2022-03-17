using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleasedDate { get; set; }
        [Display(Name = "Added Date")]
        public DateTime DateAdded { get; set; } = DateTime.Now;
        [Display(Name = "Items in stock")]
        [Range(1,20)]
        public int Stock { get; set; }
    }
}