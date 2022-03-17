using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Genre")]
        public int? GenreId { get; set; }
        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleasedDate { get; set; }
        [Display(Name = "Added Date")]
        public DateTime DateAdded { get; set; } = DateTime.Now;
        [Display(Name = "Items in stock")]
        [Range(1, 20)]
        [Required]
        public int? Stock { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public string Title { get
            {
                if (Id == 0)
                    return "New Movie";
                return "Edit Movie";
            }
        }
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            Stock = movie.Stock;
            GenreId = movie.GenreId;
        }
    }
}