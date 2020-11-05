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


        public int PriceRush()
        {
            int result = 0;
            if (RushDays == "3")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    result = 80;
                }

                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    result = 70;
                }

                else
                {
                    result = 60;
                }

            }

            else if (RushDays == "5")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    result = 60;
                }

                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    result = 50;
                }

                else
                {
                    result = 40;
                }

            }

            else if (RushDays == "7")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    result = 40;
                }

                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    result = 35;
                }

                else
                {
                    result = 30;
                }
            }

            return result;
        }
        public int DeskSurfaceArea()
        {
            return desk.Width * desk.Depth;
        }

        public int PriceDeskSurfaceArea()
        {
            int deskSurfaceArea = DeskSurfaceArea();

            if (deskSurfaceArea > 1000)
            {
                return deskSurfaceArea * 1;
            }

            return deskSurfaceArea;
        }

        public int PriceDrawers()
        {
            return desk.Drawers * 50;
        }

        public int PriceMaterial()
        {
            switch (desk.Material)
            {
                case "Oak":
                    return 200;
                case "Laminate":
                    return 100;
                case "Pine":
                    return 50;
                case "Rosewood":
                    return 300;
                default:
                    return 125;

            }
        }
        public int GetTotal()
        {
            BaseDeskPrice = 200;
            return BaseDeskPrice + PriceDeskSurfaceArea() + PriceDrawers() + PriceMaterial() + PriceRush();
        }
    }
}
