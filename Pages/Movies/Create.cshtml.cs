using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Homework6_Solution.Models;

namespace Homework6_Solution.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly MovieContext _context;
        private readonly ILogger<CreateModel> _logger;
        [BindProperty]
        public Movie Movie {get; set;}

        public CreateModel(MovieContext context, ILogger<CreateModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {

        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}