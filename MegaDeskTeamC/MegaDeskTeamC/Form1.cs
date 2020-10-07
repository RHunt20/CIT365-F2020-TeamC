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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuoteForm = new AddQuote();
            viewAddQuoteForm.Tag = this;
            viewAddQuoteForm.Show(this);
            this.Hide();
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {

        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
