using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReviewWebApplication.Models
{
    public class Movie
    {
        public long MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
    }
}
