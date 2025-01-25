using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaDesk_Grow;

namespace MegaDesk_Grow
{
    public partial class SearchQuotes : Form
    {
        private List<DeskQuote> allQuotes; 

        public SearchQuotes(List<DeskQuote> quotes)
        {
            InitializeComponent();

            allQuotes = quotes ?? new List<DeskQuote>();

            cbMaterialFilter.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            cbMaterialFilter.SelectedIndex = -1; 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }



        private void dvgQuotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (cbMaterialFilter.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a material to filter quotes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DesktopMaterial selectedMaterial = (DesktopMaterial)cbMaterialFilter.SelectedItem;

            var filteredQuotes = allQuotes
                .Where(quote => quote.Desk.Material == selectedMaterial)
                .Select(quote => new
                {
                    Date = quote.QuoteDate.ToShortDateString(),
                    Customer = quote.CustomerName,
                    Width = quote.Desk.Width,
                    Depth = quote.Desk.Depth,
                    Drawers = quote.Desk.NumberOfDrawers,
                    Material = quote.Desk.Material.ToString(),
                    RushOrderDays = quote.RushDays,
                    Total = quote.QuoteTotal.ToString("C")
                })
                .ToList();

            if (filteredQuotes.Count == 0)
            {
                MessageBox.Show("No quotes found for the selected material.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvQuotes.DataSource = null;
                return;
            }

            dgvQuotes.DataSource = filteredQuotes;
            dgvQuotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}