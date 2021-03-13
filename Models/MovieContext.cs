using Microsoft.EntityFrameworkCore;

namespace Homework6_Solution.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie {get; set;}
    }
}