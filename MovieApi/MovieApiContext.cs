using Microsoft.EntityFrameworkCore;
using MovieApi.Models;
namespace MovieApi
{
    public class MovieApiContext : DbContext
    {
        // Constructor
        public MovieApiContext(DbContextOptions<MovieApiContext> options) : base(options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; } //= default!; // From the pdf of EF-lecture 

        public DbSet<MovieDetails> MovieDetails { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Actor> Actors { get; set; }
    }
}
