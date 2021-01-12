using System.Linq;

namespace MovieReviewWebApplication.Models
{
    public interface IGenreRepository
    {
        IQueryable<Genre> Genres { get; }
    }
}
