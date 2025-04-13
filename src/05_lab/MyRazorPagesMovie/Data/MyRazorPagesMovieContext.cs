using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyRazorPagesMovie.Models;

namespace MyRazorPagesMovie.Data
{
    public class MyRazorPagesMovieContext : DbContext
    {
        public MyRazorPagesMovieContext (DbContextOptions<MyRazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MyRazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
