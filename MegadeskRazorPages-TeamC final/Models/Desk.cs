using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegadeskRazorPages.Models
{
    public class Desk
    {      
        public int ID { get; set; }
        [Range(24, 96)]
        public int Width { get; set; }
        [Range(12, 48)]
        public int Depth { get; set; }
        [Range(0, 7)]
        public int Drawers { get; set; }
        public string Material { get; set; }
    }
}
