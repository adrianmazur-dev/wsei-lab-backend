﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorPagesMovie.Data;
using MyRazorPagesMovie.Models;

namespace MyRazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MyRazorPagesMovie.Data.MyRazorPagesMovieContext _context;

        public IndexModel(MyRazorPagesMovie.Data.MyRazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
