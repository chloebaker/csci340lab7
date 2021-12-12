using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GreatAnimeMovies.Models;

namespace GreatAnimeMovies.Data
{
    public class GreatAnimeMoviesContext : DbContext
    {
        public GreatAnimeMoviesContext (DbContextOptions<GreatAnimeMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<GreatAnimeMovies.Models.Movie> Movie { get; set; }
    }
}
