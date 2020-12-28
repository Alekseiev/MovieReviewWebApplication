using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieReviewWebApplication.Models
{
    public class Genre
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();

        
    }
}
