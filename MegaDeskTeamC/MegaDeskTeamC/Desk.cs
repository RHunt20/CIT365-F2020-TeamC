using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Sawyer
{
    public class Desk
    {
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;

        public string Material;

        public int GetMinWidth()
        {
            return MINWIDTH;
        }

        public int GetMaxWidth()
        {
            return MAXWIDTH;
        }

        public int GetMinDepth()
        {
            return MINDEPTH;
        }

        public int GetMaxDepth()
        {
            return MAXDEPTH;
        }

        public int GetMinDrawers()
        {
            return MINDRAWERS;
        }

        public int GetMaxDrawers()
        {
            return MAXDRAWERS;
        }

        public int Width { get; set; }
        public int Depth { get; set; }

        public int Drawers { get; set; }
    }
}