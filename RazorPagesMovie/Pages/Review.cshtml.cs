using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Add the following using clauses to make it data driven
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class ReviewsModel : PageModel
    {
            private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

            public ReviewsModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
            {
                _context = context;
            }

            public IList<Review> Review { get; set; }

            public async Task OnGetAsync()
            {
                Review = await _context.Review.ToListAsync();
            }

    }
}
