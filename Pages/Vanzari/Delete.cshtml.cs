using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vrote_Diana.Data;
using Vrote_Diana.Models;

namespace Vrote_Diana.Pages.Vanzari
{
    public class DeleteModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public DeleteModel(Vrote_Diana.Data.Vrote_DianaContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Vanzare Vanzare { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Vanzare == null)
            {
                return NotFound();
            }

            var vanzare = await _context.Vanzare.FirstOrDefaultAsync(m => m.ID == id);

            if (vanzare == null)
            {
                return NotFound();
            }
            else 
            {
                Vanzare = vanzare;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Vanzare == null)
            {
                return NotFound();
            }
            var vanzare = await _context.Vanzare.FindAsync(id);

            if (vanzare != null)
            {
                Vanzare = vanzare;
                _context.Vanzare.Remove(Vanzare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
