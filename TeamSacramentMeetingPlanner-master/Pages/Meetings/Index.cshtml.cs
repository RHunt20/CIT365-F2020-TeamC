using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamSacramentMeetingPlanner.Models;

namespace TeamSacramentMeetingPlanner.Pages.Meetings
{
    public class IndexModel : PageModel
    {
        private readonly TeamSacramentMeetingPlanner.Data.TeamSacramentMeetingPlannerContext _context;

        public IndexModel(TeamSacramentMeetingPlanner.Data.TeamSacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public IList<Meeting> Meeting { get;set; }
        public DateTime Date { get; set; }

        public async Task OnGetAsync(DateTime date)
        {
            if (date != DateTime.MinValue)
            {
                Meeting = await _context.Meeting.Where(x => x.MeetingDate == date).ToListAsync();
            }
            else 
            {
                Meeting = await _context.Meeting.ToListAsync();
            }
            
        }
    }
}
