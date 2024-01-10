using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vrote_Diana.Data;
using Vrote_Diana.Models;

namespace Vrote_Diana.Pages.Buyers
{
    public class EditModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public EditModel(Vrote_Diana.Data.Vrote_DianaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Buyer Buyer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Buyer == null)
            {
                return NotFound();
            }

            var buyer =  await _context.Buyer.FirstOrDefaultAsync(m => m.ID == id);
            if (buyer == null)
            {
                return NotFound();
            }
            Buyer = buyer;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Buyer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuyerExists(Buyer.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BuyerExists(int id)
        {
          return (_context.Buyer?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
