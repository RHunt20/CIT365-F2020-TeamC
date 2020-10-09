using Newtonsoft.Json;
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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("FirstName", "FirstName");
            dataGridView1.Columns.Add("LastName", "LastName");
            dataGridView1.Columns.Add("Width", "Width");
            dataGridView1.Columns.Add("Depth", "Depth");
            dataGridView1.Columns.Add("Drawers", "Drawers");
            dataGridView1.Columns.Add("Material", "Material");
            dataGridView1.Columns.Add("RushDays", "Rush Days");
            dataGridView1.Columns.Add("Price", "Price");

            string dir = System.IO.Directory.GetCurrentDirectory();
            string path = $@"{dir}\..\..\data\database.json";
            string jsonReturn = System.IO.File.ReadAllText(path);
            dynamic m = JsonConvert.DeserializeObject(jsonReturn);
            foreach (var i in m)
            {
                foreach (var item in i)
                {
                    dataGridView1.Rows.Add(item.Date, item.FirstName, item.LastName, item.desk.Width, item.desk.Depth, item.desk.Drawers, item.desk.Material, item.RushDays, item.TotalPrice);
                }
                
            }
        }
    }
}
