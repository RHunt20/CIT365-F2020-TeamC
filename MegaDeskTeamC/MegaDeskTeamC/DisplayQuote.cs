using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskTeamC
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote deskQuote;
        private MainMenu mainMenu;
        public DisplayQuote()
        {
            InitializeComponent();
        }

        public DisplayQuote(DeskQuote deskQuote, MainMenu mainMenu)
        {
            InitializeComponent();
            this.deskQuote = deskQuote;
            this.mainMenu = mainMenu;
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            //textBoxFirstName.Text = this.deskQuote.FirstName;
            labelCustomerValue.Text = $"{deskQuote.FirstName} {deskQuote.LastName}";
            labelDateValue.Text = $"{deskQuote.getDate()}";
            labelBasePriceValue.Text = $"${deskQuote.BaseDeskPrice}";
            labelAreaPriceValue.Text = $"${deskQuote.PriceDeskSurfaceArea()}";
            labelDrawersValue.Text = $"${deskQuote.PriceDrawers()}";
            labelMaterialValue.Text = $"${deskQuote.PriceMaterial()}";
            labelRushValue.Text = $"${deskQuote.PriceRush()}";
            labelTotalValue.Text = $"${deskQuote.GetTotal()}";
        }       

        private void MainMenu_Click(object sender, EventArgs e)
        {
            //MainMenu mainMenu = (MainMenu)Tag;
            this.mainMenu.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
    }
}
