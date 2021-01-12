using System.Collections.Generic;

namespace MovieReviewWebApplication.Models.ViewModels
{
    public class MoviesListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
        public IEnumerable<string> MovieImages { get; set; }
    }
}
