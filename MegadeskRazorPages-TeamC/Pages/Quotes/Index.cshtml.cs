using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegadeskRazorPages.Models;

namespace MegadeskRazorPages.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegadeskRazorPages.Models.MegadeskRazorPagesContext _context;

        public IndexModel(MegadeskRazorPages.Models.MegadeskRazorPagesContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
