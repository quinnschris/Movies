using System;
using System.Linq;

namespace Movies.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MoviesDbContext _context;

        public EFMovieRepository(MoviesDbContext context)
        {
            _context = context;
        }

        public IQueryable<Movie> Movies => _context.Movies; 
    }
}
