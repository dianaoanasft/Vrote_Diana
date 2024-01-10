using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vrote_Diana.Data;
using Vrote_Diana.Models;

namespace Vrote_Diana.Pages.Homes
{
    public class DetailsModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public DetailsModel(Vrote_Diana.Data.Vrote_DianaContext context)
        {
            _context = context;
        }

      public Home Home { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Home == null)
            {
                return NotFound();
            }

            var home = await _context.Home.FirstOrDefaultAsync(m => m.ID == id);
            if (home == null)
            {
                return NotFound();
            }
            else 
            {
                Home = home;
            }
            return Page();
        }
    }
}
