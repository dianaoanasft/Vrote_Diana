using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vrote_Diana.Data;
using Vrote_Diana.Models;

namespace Vrote_Diana.Pages.HomeTypes
{
    public class DetailsModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public DetailsModel(Vrote_Diana.Data.Vrote_DianaContext context)
        {
            _context = context;
        }

      public HomeType HomeType { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.HomeType == null)
            {
                return NotFound();
            }

            var hometype = await _context.HomeType.FirstOrDefaultAsync(m => m.Id == id);
            if (hometype == null)
            {
                return NotFound();
            }
            else 
            {
                HomeType = hometype;
            }
            return Page();
        }
    }
}
