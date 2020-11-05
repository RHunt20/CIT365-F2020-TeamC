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
    public class DetailsModel : PageModel
    {
        private readonly MegadeskRazorPages.Models.MegadeskRazorPagesContext _context;

        public DetailsModel(MegadeskRazorPages.Models.MegadeskRazorPagesContext context)
        {
            _context = context;
        }

        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.Where(m => m.ID == id).Select(x => new
            {
               x.ID,
               x.Date,
               x.desk,
               x.FirstName,
               x.LastName,
               x.RushDays,
               x.TotalPrice
            }).Select(x => new DeskQuote
            {
                ID = x.ID,
                desk = x.desk,
                Date = x.Date,
                FirstName = x.FirstName,
                LastName = x.LastName,
                RushDays = x.RushDays,
                TotalPrice = x.TotalPrice
            }).FirstOrDefaultAsync();

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
