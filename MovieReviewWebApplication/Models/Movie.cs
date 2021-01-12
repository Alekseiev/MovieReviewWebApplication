using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MovieReviewWebApplication.Models
{
    public class Movie
    {
        public long MovieId { get; set; }

        [Required(ErrorMessage = "Please, enter a movie name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter a movie description")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Please, enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [JsonIgnore]
        public List<Genre> Genres { get; set; } = new List<Genre>();

        public Movie()
        {
            this.CreatedDate = DateTime.Now;
        }

        [Required(ErrorMessage = "Please, enter a movie director")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please, enter a movie country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please, enter a movie release date")]
        public DateTime Year { get; set; }

        public string ImageName { get; set; }

        public int Rating { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
