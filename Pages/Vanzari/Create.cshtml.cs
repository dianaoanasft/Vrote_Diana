using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
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


namespace Vrote_Diana.Pages.Vanzari
{
    public class CreateModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public CreateModel(Vrote_Diana.Data.Vrote_DianaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
          
            ViewData["HomeID"] = new SelectList(_context.Home, "ID", "ID");
            ViewData["BuyerID"] = new SelectList(_context.Buyer, "ID", "FullName");
            return Page();
        }

        [BindProperty]
        public Vanzare Vanzare { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Vanzare == null || Vanzare == null)
            {
                return Page();
            }

            _context.Vanzare.Add(Vanzare);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
