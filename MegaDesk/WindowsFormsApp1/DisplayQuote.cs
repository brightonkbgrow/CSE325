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
    public partial class DisplayQuote : Form
    {
        private DeskQuote deskQuote;

        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            deskQuote = quote;
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = deskQuote.CustomerName;
            lblDeskWidth.Text = deskQuote.Desk.Width.ToString();
            lblDeskDepth.Text = deskQuote.Desk.Depth.ToString();
            lblDeskMaterial.Text = deskQuote.Desk.Material.ToString();
            lblNumDrawers.Text = deskQuote.Desk.NumberOfDrawers.ToString();
            lblRushOrderDays.Text = deskQuote.RushDays.ToString();
            lblQuoteDate.Text = deskQuote.QuoteDate.ToShortDateString();
            lblQuoteTotal.Text = "$" + deskQuote.QuoteTotal.ToString("F2");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Close(); 
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name label clicked!");
        }

        private void lblDeskWidth_Click(object sender, EventArgs e)
        {

        }

        private void lblDeskMaterial_Click(object sender, EventArgs e)
        {

        }
    }
}