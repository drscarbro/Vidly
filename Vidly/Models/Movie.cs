using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a Movie Name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added to Inventory")]
        public DateTime DateAdded { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Please select a Genre.")]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }
    }
}