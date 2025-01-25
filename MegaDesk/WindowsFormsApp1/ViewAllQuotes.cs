using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Grow
{
    public partial class ViewAllQuotes : Form
    {
        private List<DeskQuote> allQuotes;
        public ViewAllQuotes(List<DeskQuote> quotes)
        {
            InitializeComponent();

            allQuotes = quotes ?? new List<DeskQuote>();

            LoadQuotes();
        }

        private void LoadQuotes()
        {
            if (allQuotes == null || allQuotes.Count == 0)
            {
                MessageBox.Show("No quotes available to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var quoteData = allQuotes
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

            dgvQuotes.DataSource = quoteData;
            dgvQuotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }


    }
}
