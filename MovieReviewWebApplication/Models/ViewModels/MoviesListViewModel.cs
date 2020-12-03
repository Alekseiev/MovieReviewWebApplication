using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieReviewWebApplication.Models;

namespace MovieReviewWebApplication.Models.ViewModels
{
    public class MoviesListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
