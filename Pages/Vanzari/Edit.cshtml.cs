﻿using System;
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
    public class EditModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public EditModel(Vrote_Diana.Data.Vrote_DianaContext context)
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

            var vanzare =  await _context.Vanzare.FirstOrDefaultAsync(m => m.ID == id);
            if (vanzare == null)
            {
                return NotFound();
            }
            Vanzare = vanzare;
           ViewData["HomeID"] = new SelectList(_context.Home, "ID", "Name");
           ViewData["BuyerID"] = new SelectList(_context.Buyer, "ID", "FullName");
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

            _context.Attach(Vanzare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VanzareExists(Vanzare.ID))
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

        private bool VanzareExists(int id)
        {
          return (_context.Vanzare?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
