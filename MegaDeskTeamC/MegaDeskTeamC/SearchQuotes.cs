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
    public partial class SearchQuotes : Form
    {
        public static void LoadDeskMaterialCombo(ComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(DeskMaterial))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cbo.DisplayMember = "Description";
            cbo.ValueMember = "value";
        }
        public SearchQuotes()
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

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            LoadDeskMaterialCombo(DeskMaterial);
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("FirstName", "FirstName");
            dataGridView1.Columns.Add("LastName", "LastName");
            dataGridView1.Columns.Add("Width", "Width");
            dataGridView1.Columns.Add("Depth", "Depth");
            dataGridView1.Columns.Add("Drawers", "Drawers");
            dataGridView1.Columns.Add("Material", "Material");
            dataGridView1.Columns.Add("RushDays", "Rush Days");
            dataGridView1.Columns.Add("Price", "Price");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            List<DeskQuote> list = new List<DeskQuote>();
            string dir = System.IO.Directory.GetCurrentDirectory();
            string path = $@"{dir}\..\..\data\database.json";
            string jsonReturn = System.IO.File.ReadAllText(path);
            dynamic m = JsonConvert.DeserializeObject(jsonReturn);
            foreach (var i in m)
            {
                foreach (var item in i)
                {
                    if (item.desk.Material == DeskMaterial.Text)
                    {
                        DeskQuote desk = new DeskQuote
                        {
                            Date = item.Date,
                            FirstName = item.FirstName,
                            LastName = item.LastName,
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
                        {
                            dataGridView1.Rows.Add(desk.Date, desk.FirstName, desk.LastName, desk.desk.Width, desk.desk.Depth, desk.desk.Drawers, desk.desk.Material, desk.RushDays, desk.TotalPrice);
                            list.Add(desk);
                        }
                    }
                }
            }
        }
    }
}
