using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TeamSacramentMeetingPlanner.Models;

namespace TeamSacramentMeetingPlanner.Pages.Meetings
{
    public class DeleteModel : PageModel
    {
        private readonly TeamSacramentMeetingPlanner.Data.TeamSacramentMeetingPlannerContext _context;

        public DeleteModel(TeamSacramentMeetingPlanner.Data.TeamSacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meeting = await _context.Meeting.FirstOrDefaultAsync(m => m.Id == id);

            if (Meeting == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meeting = await _context.Meeting.FindAsync(id);

            if (Meeting != null)
            {
                _context.Meeting.Remove(Meeting);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
