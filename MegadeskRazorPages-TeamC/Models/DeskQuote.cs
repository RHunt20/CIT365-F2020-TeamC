using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegadeskRazorPages.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }
        public Desk desk { get; set; }
        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Base price")]
        public int BaseDeskPrice { get; set; }
        [Display(Name = "Rush days")]
        public string RushDays { get; set; }
        [Display(Name = "Total price")]
        public int TotalPrice { get; set; }
        [Display(Name = "Quote Date")]
        [DataType(DataType.Date)]
        public string Date { get; set; }

    }
}
