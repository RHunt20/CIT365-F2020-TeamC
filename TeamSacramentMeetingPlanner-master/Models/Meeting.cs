using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamSacramentMeetingPlanner.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime MeetingDate { get; set; }
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Conductor { get; set; }
        [Display(Name = "Opening Hymn")]
        //[StringLength(100, MinimumLength = 3)]
        [Required]
        public string OpeningHymnNumber { get; set; }
        [Display(Name = "Sacrament Hymn")]
        //[StringLength(100, MinimumLength = 3)]
        [Required]
        public string SacramentHymnNumber { get; set; }
        [Display(Name = "Rest Hymn")]
        //[StringLength(100, MinimumLength = 3)]
        public string RestHymnNumber { get; set; }
        [Display(Name = "Closing Hymn")]
        [Required]
        public string ClosingHymn { get; set; }
        //[StringLength(100, MinimumLength = 3)]
        [Required]
        public string OpeningPrayer { get; set; }
        [Display(Name = "Closing Prayer")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string ClosingPrayer { get; set; }
        [Display(Name = "Speaker 1")]
        [StringLength(100, MinimumLength = 3)]
        public string SpeakerOne { get; set; }
        [Display(Name = "Topic")]
        [StringLength(100, MinimumLength = 3)]
        public string TopicSpeakerOne { get; set; }
        [Display(Name = "Speaker 2")]
        [StringLength(100, MinimumLength = 3)]
        public string SpeakerTwo { get; set; }
        [Display(Name = "Topic")]
        [StringLength(100, MinimumLength = 3)]
        public string TopicSpeakerTwo { get; set; }
        [Display(Name = "Speaker 3")]
        [StringLength(100, MinimumLength = 3)]
        public string SpeakerThree { get; set; }
        [Display(Name = "Topic")]
        [StringLength(100, MinimumLength = 3)]
        public string TopicSpeakerThree { get; set; }

    }
}
