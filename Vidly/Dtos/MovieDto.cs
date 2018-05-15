using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a Movie Name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Please select a Genre.")]
        public byte GenreId { get; set; }

        [Required]
        public byte NumberInStock { get; set; }
    }
}