﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public IndexModel(Vrote_Diana.Data.Vrote_DianaContext context)
        {
            _context = context;
        }

        public IList<Buyer> Buyer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Buyer != null)
            {
                Buyer = await _context.Buyer.ToListAsync();
            }
            var memberList = _context.Member.Select(x => new
            {
                x.ID,
                FullName = x.LastName + " " + x.FirstName
            });
        }
    }
}
