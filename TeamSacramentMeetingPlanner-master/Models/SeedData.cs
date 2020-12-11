using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TeamSacramentMeetingPlanner.Data;
using System;
using System.Linq;

namespace TeamSacramentMeetingPlanner.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TeamSacramentMeetingPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TeamSacramentMeetingPlannerContext>>()))
            {

                if (context.Meeting.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meeting.AddRange(
                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("2019-12-08"),
                        Conductor = "Jeff Hansen",
                        OpeningHymnNumber = "201",
                        SacramentHymnNumber = "100",
                        RestHymnNumber ="20",
                        ClosingHymn = "300",
                        OpeningPrayer = "Frank Heart",
                        ClosingPrayer = "Katie Larsen",
                        SpeakerOne = "Mike Jones",
                        SpeakerTwo = "Ryan Sawyer",
                        SpeakerThree = "John Armstrong"
                    },

                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("2019-11-03"),
                        Conductor = "Mike Barns",
                        OpeningHymnNumber = "89",
                        SacramentHymnNumber = "82",
                        RestHymnNumber = "102",
                        ClosingHymn = "92",
                        OpeningPrayer = "Fred Hinzer",
                        ClosingPrayer = "Zack Manchester"
                    },

                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("2019-11-10"),
                        Conductor = "Jeff Hansen",
                        OpeningHymnNumber = "203",
                        SacramentHymnNumber = "93",
                        RestHymnNumber = "83",
                        ClosingHymn = "73",
                        OpeningPrayer = "Kevin Heart",
                        ClosingPrayer = "Bryce Willson",
                        SpeakerOne = "Magnum Jenkins",
                        SpeakerTwo = "Anthony Stark",
                        SpeakerThree = "Bruce Wayne"
                    },

                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("2019-11-17"),
                        Conductor = "Mike Barns",
                        OpeningHymnNumber = "304",
                        SacramentHymnNumber = "204",
                        RestHymnNumber = "104",
                        ClosingHymn = "94",
                        OpeningPrayer = "Steve Rogers",
                        ClosingPrayer = "Katie Larsen",
                        SpeakerOne = "Diana Prince ",
                        SpeakerTwo = "Natasha Romanoff",
                        SpeakerThree = "Bill Jensen"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
