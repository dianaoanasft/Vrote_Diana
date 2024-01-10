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
    public class IndexModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public IndexModel(Vrote_Diana.Data.Vrote_DianaContext context)
        {
            _context = context;
        }

        public IList<HomeType> HomeType { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.HomeType != null)
            {
                HomeType = await _context.HomeType.ToListAsync();
            }
        }
    }
}
