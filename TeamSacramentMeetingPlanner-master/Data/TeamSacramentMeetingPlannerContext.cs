using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeamSacramentMeetingPlanner.Models;

namespace TeamSacramentMeetingPlanner.Data
{
    public class TeamSacramentMeetingPlannerContext : DbContext
    {
        public TeamSacramentMeetingPlannerContext (DbContextOptions<TeamSacramentMeetingPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<TeamSacramentMeetingPlanner.Models.Meeting> Meeting { get; set; }
    }
}
