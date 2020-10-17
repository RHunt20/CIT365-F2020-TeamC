using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskTeamC
{
    public class DeskQuote
    {
        public Desk desk = new Desk();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BaseDeskPrice { get; set; } = 200;
        public string RushDays { get; set; }
        public int TotalPrice { get; set; } 
        public string Date { get; set; }

        public const int BASESURFACE = 1000;
        public const int OVERSURFACE = 1;
        public const int LARGESURFACE = 2000;


        public int PriceRush()
        {
            int result = 0;
	        int[,] rushOrderPrices = new int[3, 3];
	        string[] priceList = new string[9];
	        priceList = ReadRushOrderPrices();
	        int counter = 0;
		        while (counter < 9)
		        {
			        for (int y = 0; y < 3; y++)
			        {
				        for (int x = 0; x < 3; x++)
				        {
					        rushOrderPrices[y, x] = int.Parse(priceList[counter]);
					        counter++;
				        }
			        }
		        }

            if(RushDays == "3")
            { 
                if(DeskSurfaceArea() > 2000)
                {
                    result = rushOrderPrices[0,2];
                }

                else if(DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    result = rushOrderPrices[0,1];
                }

                else
                {
                    result = rushOrderPrices[0,0];
                }

            }

            else if(RushDays == "5")
            { 
                if(DeskSurfaceArea() > 2000)
                {
                    result = rushOrderPrices[1,2];
                }

                else if(DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    result = rushOrderPrices[1,1];
                }

                else
                {
                    result = rushOrderPrices[1,0];
                }

            }

            else if(RushDays == "7" )
            {
                if(DeskSurfaceArea() > 2000)
                {
                    result = rushOrderPrices[2,2];
                }

                else if(DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    result = rushOrderPrices[2,1];
                }

                else
                {
                    result = rushOrderPrices[2,0];
                }
            }


            return result;
        }

        public static string[] ReadRushOrderPrices()
        {
	        string[] priceList = new string[9];
	        try
	        {
		        var filePath = @"../../data/rushOrderPrices.txt";
		        StreamReader reader = new StreamReader(filePath);
		        int i = 0;
		        while (reader.EndOfStream == false)
		        {
			        string line = reader.ReadLine();
			        priceList[i] = line;
			        i++;
		        }

		        reader.Close();
	
	        }
	        catch (Exception e)
	        {
                throw new Exception(e.Message);
	        }
	        return priceList;
        }

        public static int[,] rushOrderPrices = new int[3,3];


        public string getDate()

        {
            return DateTime.Now.ToString("MM.dd.yyy");
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



        /*public int PriceRush()
        {
            int addedPrice = 0;
            if (RushDays == "3")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    addedPrice = 80;
                    return addedPrice;
                }
                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    addedPrice = 70;
                    return addedPrice;
                }
                else
                {
                    addedPrice = 60;
                    return addedPrice;
                }
            }

            else if (RushDays == "5")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    return 60;
                }
                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    return 50;
                }
                else
                {
                    addedPrice = 40;
                    return addedPrice;
                }
            }

            else if (RushDays == "7")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    return 40;
                }
                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    addedPrice = 35;
                    return addedPrice;
                }
                else
                {
                    addedPrice = 30;
                    return addedPrice;
                }
            }
            else 
            {
                return addedPrice;
            }
        }*/

        public int GetTotal()
        {
            return BaseDeskPrice + PriceDeskSurfaceArea() + PriceDrawers() + PriceMaterial() + PriceRush();
        }

        public Desk GetDesk()
        {
            return desk;
        }

    }
}