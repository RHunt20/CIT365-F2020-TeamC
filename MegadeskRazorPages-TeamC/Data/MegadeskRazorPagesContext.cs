using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MegadeskRazorPages.Models
{
    public class MegadeskRazorPagesContext : DbContext
    {
        public MegadeskRazorPagesContext (DbContextOptions<MegadeskRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<MegadeskRazorPages.Models.DeskQuote> DeskQuote { get; set; }
    }
}
