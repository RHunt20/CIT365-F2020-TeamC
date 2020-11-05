using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegadeskRazorPages.Models;

namespace MegadeskRazorPages.Pages.Quotes
{
    public class CreateModel : PageModel
    {
        private readonly MegadeskRazorPages.Models.MegadeskRazorPagesContext _context;

        public CreateModel(MegadeskRazorPages.Models.MegadeskRazorPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            DeskQuote.TotalPrice = DeskQuote.GetTotal();
            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}