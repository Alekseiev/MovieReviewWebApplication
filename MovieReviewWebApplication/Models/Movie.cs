using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieReviewWebApplication.Models
{
    public class Movie
    {
        public long MovieId { get; set; }



        [Required(ErrorMessage = "Please, enter a movie name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter a movie description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please, enter a movie genre")]
        public string Genre { get; set; }

        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Please, enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
    }
}
