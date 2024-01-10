using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vrote_Diana.Data;
using Vrote_Diana.Models;

namespace Vrote_Diana.Pages.Buyers
{
    public class DetailsModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public DetailsModel(Vrote_Diana.Data.Vrote_DianaContext context)
        {
            _context = context;
        }

      public Buyer Buyer { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Buyer == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyer.FirstOrDefaultAsync(m => m.ID == id);
            if (buyer == null)
            {
                return NotFound();
            }
            else 
            {
                Buyer = buyer;
            }
            return Page();
        }
    }
}
