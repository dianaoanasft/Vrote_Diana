﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vrote_Diana.Data;
using Vrote_Diana.Models;

namespace Vrote_Diana.Pages.PossibleBuyers
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
            return Page();
        }

        [BindProperty]
        public PossibleBuyer PossibleBuyer { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.PossibleBuyer == null || PossibleBuyer == null)
            {
                return Page();
            }

            _context.PossibleBuyer.Add(PossibleBuyer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
