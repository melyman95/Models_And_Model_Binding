using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models_And_Model_Binding.Models
{
    /// <summary>
    /// Represents an individual movie.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Movie's title.
        /// </summary>
        [Display(Name = "Title")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        
        /// <summary>
        /// Year the movie was released in theaters.
        /// </summary>
        [Display(Name = "Release Year")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Release year is required.")]
        public string ReleaseYear { get; set; }

        /// <summary>
        /// Movie genre (action, horror etc)
        /// </summary>
        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Genre is required.")]
        public string Genre { get; set; }

        /// <summary>
        /// Movie rating
        /// </summary>
        [Display(Name = "Rating")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Movie rating is required.")]
        public string Rating { get; set; }

        /// <summary>
        /// Movie's run time in minutes
        /// </summary>
        [Display(Name = "Length (minutes) ")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Run time is required.")]
        public string Length { get; set; }
    }
}
