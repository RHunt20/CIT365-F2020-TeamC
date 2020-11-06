using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MegadeskRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MegadeskRazorPages.Pages.Quotes
{
    public class SearchModel : PageModel
    {
        private readonly MegadeskRazorPages.Models.MegadeskRazorPagesContext _context;

        public SearchModel(MegadeskRazorPages.Models.MegadeskRazorPagesContext context)
        {
            _context = context;
        }

        public string FirstNameSort { get; set; }
        public string DateSort { get; set; }


        public IList<DeskQuote> DeskQuote { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Date { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchDate { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {

            // using System;
            FirstNameSort = sortOrder == "FirstName_Asc_Sort" ? "FirstName_Desc_Sort" : "FirstName_Asc_Sort";
            DateSort = sortOrder == "Date_Asc_Sort" ? "Date_Desc_Sort" : "Date_Asc_Sort";

            // Use LINQ to get list of genres.
            IQueryable<string> DateQuery = from t in _context.DeskQuote
                                           orderby t.Date
                                           select t.Date;
            var Quotes = from s in _context.DeskQuote
                         select s;
            if ((!string.IsNullOrEmpty(SearchString)) && (!string.IsNullOrEmpty(SearchDate)))
            {
                Quotes = Quotes.Where(s => s.FirstName.Contains(SearchString) && s.Date == SearchDate).Select(x => new
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
                });
            }

            else if ((!string.IsNullOrEmpty(SearchString)))
            {
                Quotes = Quotes.Where(s => s.FirstName.Contains(SearchString)).Select(x => new
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
                });
            }

            else if ((!string.IsNullOrEmpty(SearchDate)))
            {
                Quotes = Quotes.Where(x => x.Date == SearchDate).Select(x => new
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
                });
            }

            else 
            {
                Quotes = Quotes.Skip(Quotes.Count());
            }

            //if (!string.IsNullOrEmpty(SearchString))
            //{
            //    Quotes = Quotes.Where(s => s.FirstName.Contains(SearchString));
            //}
            //else 
            //{
            //    Quotes = Quotes.Skip(Quotes.Count());
            //}

            //if (!string.IsNullOrEmpty(SearchDate))
            //{
            //    Quotes = from s in _context.DeskQuote
            //             select s;
            //    Quotes = Quotes.Where(x => x.Date == SearchDate);
            //}
            //else
            //{
            //    Quotes = Quotes.Skip(Quotes.Count());
            //}
            //Date = new SelectList(await DateQuery.Distinct().ToListAsync());


            switch (sortOrder)
            {
                case "FirstName_Asc_Sort":
                    Quotes = Quotes.OrderBy(s => s.FirstName);
                    break;
                case "FirstName_Desc_Sort":
                    Quotes = Quotes.OrderByDescending(s => s.FirstName);
                    break;
                case "Date_Asc_Sort":
                    Quotes = Quotes.OrderBy(s => s.Date);
                    break;
                case "Date_Desc_Sort":
                    Quotes = Quotes.OrderByDescending(s => s.Date);
                    break;
            }

            DeskQuote = await Quotes.ToListAsync();
        }
    }
}