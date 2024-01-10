using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vrote_Diana.Data;
using Vrote_Diana.Models;

namespace Vrote_Diana.Pages.PossibleBuyers
{
    public class DeleteModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public DeleteModel(Vrote_Diana.Data.Vrote_DianaContext context)
        {
            _context = context;
        }

        [BindProperty]
      public PossibleBuyer PossibleBuyer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PossibleBuyer == null)
            {
                return NotFound();
            }

            var possiblebuyer = await _context.PossibleBuyer.FirstOrDefaultAsync(m => m.ID == id);

            if (possiblebuyer == null)
            {
                return NotFound();
            }
            else 
            {
                PossibleBuyer = possiblebuyer;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.PossibleBuyer == null)
            {
                return NotFound();
            }
            var possiblebuyer = await _context.PossibleBuyer.FindAsync(id);

            if (possiblebuyer != null)
            {
                PossibleBuyer = possiblebuyer;
                _context.PossibleBuyer.Remove(PossibleBuyer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
