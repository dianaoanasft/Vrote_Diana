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
    public class IndexModel : PageModel
    {
        private readonly Vrote_Diana.Data.Vrote_DianaContext _context;

        public IndexModel(Vrote_Diana.Data.Vrote_DianaContext context)
        {
            _context = context;
        }

        public IList<Vanzare> Vanzare { get;set; } = default!;
        
        public int BuyerID { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Vanzare != null)
            {
                Vanzare = await _context.Vanzare
                .Include(v => v.Home)
                .ThenInclude(v => v.Member)
                .Include(v => v.Buyer).ToListAsync();
                
            }
            var buyerList = _context.Buyer.Select(x => new
            {
                x.ID,
                FullName = x.LastName + " " + x.FirstName
            });

            var memberList = _context.Member.Select(x => new
            {
                x.ID,
                FullName = x.LastName + " " + x.FirstName
            });

        }
    }
}
