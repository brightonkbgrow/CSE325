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
using WindowsFormsApp1;

namespace MegaDesk_Grow
{
    public partial class MainMenu : Form
    {
        private List<DeskQuote> allQuotes = new List<DeskQuote>();
        public MainMenu()
        {
            InitializeComponent();

            // Replace later. filler for now
            allQuotes.Add(new DeskQuote(new Desk(50, 30, 2, DesktopMaterial.Oak), "John Doe", 3, DateTime.Now));
            allQuotes.Add(new DeskQuote(new Desk(60, 40, 3, DesktopMaterial.Pine), "Jane Smith", 5, DateTime.Now.AddDays(-1)));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show(); 
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes(allQuotes); 
            viewAllQuotes.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes(allQuotes);
            searchQuotesForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
