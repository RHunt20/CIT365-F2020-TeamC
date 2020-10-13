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

            //string dir = System.IO.Directory.GetCurrentDirectory();
            //string path = $@"{dir}\..\..\data\database.json";
            //string jsonReturn = System.IO.File.ReadAllText(path);
            //dynamic m = JsonConvert.DeserializeObject(jsonReturn);
            //foreach (var i in m)
            //{
            //    foreach (var item in i)
            //    {
            //        dataGridView1.Rows.Add(item.Date, item.FirstName, item.LastName, item.desk.Width, item.desk.Depth, item.desk.Drawers, item.desk.Material, item.RushDays, item.TotalPrice);
            //    }

            //}

            List<DeskQuote> list = new List<DeskQuote>();
            string dir = System.IO.Directory.GetCurrentDirectory();
            string path = $@"{dir}\..\..\data\database.json";
            string jsonReturn = System.IO.File.ReadAllText(path);
            dynamic m = JsonConvert.DeserializeObject(jsonReturn);
            foreach (var i in m)
            {
                foreach (var item in i)
                {
                    DeskQuote desk = new DeskQuote { 
                        Date =  item.Date, 
                        FirstName =  item.FirstName, 
                        LastName =  item.LastName, 
                        desk = new Desk 
                        { 
                            Depth = item.desk.Depth,
                            Width = item.desk.Width,
                            Drawers = item.desk.Drawers,
                            Material = item.desk.Material
                        }, 
                        RushDays = item.RushDays,
                        TotalPrice = item.TotalPrice                      
                    };
                    dataGridView1.Rows.Add(desk.Date, desk.FirstName, desk.LastName, desk.desk.Width, desk.desk.Depth, desk.desk.Drawers, desk.desk.Material, desk.RushDays, desk.TotalPrice);
                    list.Add(desk);
                }
            }
            var cry = 0;
        }
    }
}
