using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Grow
{

    public partial class AddQuote : Form
    {
        private const int MinWidth = 24;
        private const int MaxWidth = 96;
        private const int MinDepth = 12;
        private const int MaxDepth = 48;
        private readonly string[] Materials = { "Laminate", "Oak", "Rosewood", "Veneer", "Pine" };
        private readonly int[] ValidRushOrder = { 3, 5, 7, 14};

        public AddQuote()
        {
            InitializeComponent();
            cmbMaterials.Items.AddRange(Enum.GetNames(typeof(DesktopMaterial)));
            cmbRushOrder.Items.AddRange(new object[] { 3, 5, 7, 14});

        }
        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                txtName.BackColor = Color.LightPink;
            }
            else
            {
                e.Cancel = false;
                txtName.BackColor = Color.White;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName_Validating(sender, new CancelEventArgs());
        }
        private void txtWidth_Validating(object sender, CancelEventArgs e)
        {
            int width;

            if (string.IsNullOrWhiteSpace(txtWidth.Text))
            {
                MessageBox.Show("Width cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                txtWidth.BackColor = Color.LightPink; 
                return;
            }


            if (!int.TryParse(txtWidth.Text, out width))
            {
                MessageBox.Show("Please enter a valid integer for the width.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; 
                txtWidth.BackColor = Color.LightPink; 
                return;
            }

            if (width < MinWidth || width > MaxWidth)
            {
                MessageBox.Show($"Width must be between {MinWidth} and {MaxWidth} inches.", "Invalid Width", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; 
                txtWidth.BackColor = Color.LightPink; 
                return;
            }

            e.Cancel = false;
            txtWidth.BackColor = Color.White; 
        }
        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            txtWidth_Validating(sender, new CancelEventArgs());
        }

        private void txtDepth_Validating(object sender, CancelEventArgs e)
        {
            int depth;

            if (string.IsNullOrWhiteSpace(txtDepth.Text))
            {
                MessageBox.Show("Depth cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                txtDepth.BackColor = Color.LightPink; 
                return;
            }

            if (!int.TryParse(txtDepth.Text, out depth))
            {
                MessageBox.Show("Please enter a valid integer for the depth.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; 
                txtDepth.BackColor = Color.LightPink; 
                return;
            }

            if (depth < MinDepth || depth > MaxDepth)
            {
                MessageBox.Show($"Depth must be between {MinDepth} and {MaxDepth} inches.", "Invalid Depth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; 
                txtDepth.BackColor = Color.LightPink; 
                return;
            }

            e.Cancel = false;
            txtDepth.BackColor = Color.White; 

        }
        private void txtDepth_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNumDrawer_Validating(object sender, CancelEventArgs e)
        {
            int numDrawers;

            if (string.IsNullOrWhiteSpace(txtnumDrawer.Text))
            {
                MessageBox.Show("Number of drawers cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                txtnumDrawer.BackColor = Color.LightPink;
                return;
            }

            if (!int.TryParse(txtnumDrawer.Text, out numDrawers))
            {
                MessageBox.Show("Please enter a valid integer for the number of drawers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                txtnumDrawer.BackColor = Color.LightPink;
                return;
            }

            if (numDrawers < 0 || numDrawers > 7)
            {
                MessageBox.Show("Number of drawers must be between 0 and 7.", "Invalid Number of Drawers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                txtnumDrawer.BackColor = Color.LightPink;
                return;
            }

            e.Cancel = false;
            txtnumDrawer.BackColor = Color.White;

        }
        private void txtNumDrawer_TextChanged(object sender, EventArgs e)
        {
            txtNumDrawer_Validating(sender, new CancelEventArgs());
        }
        private void numDrawer_TextChanged(object sender, EventArgs e)
        {

        }


        private void cmbMaterials_Validating(object sender, CancelEventArgs e)
        {
            if (cmbMaterials.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a material.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                cmbMaterials.BackColor = Color.LightPink;
            }
            else
            {
                e.Cancel = false;
                cmbMaterials.BackColor = Color.White;
            }
        }

        private void cmbRushOrder_Validating(object sender, CancelEventArgs e)
        {
            if (cmbRushOrder.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid rush order (3, 5, or 7).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                cmbRushOrder.BackColor = Color.LightPink;
            }
            else
            {
                e.Cancel = false;
                cmbRushOrder.BackColor = Color.White;
            }
        }

        private void cmbRushOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRushOrder_Validating(sender, new CancelEventArgs());
        }



        private void Submit_Click(object sender, EventArgs e)
        {
            int width = 0, depth = 0, numDrawers = 0, rushOrder = 0;
            bool isValid = true;
            decimal totalPrice = 0;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a valid name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.BackColor = Color.LightPink;
                isValid = false;
            }
            else
            {
                txtName.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtWidth.Text) || !int.TryParse(txtWidth.Text, out width) || width < MinWidth || width > MaxWidth)
            {
                MessageBox.Show("Please enter a valid width between 24 and 96 inches.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWidth.BackColor = Color.LightPink;
                isValid = false;
            }
            else
            {
                txtWidth.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtDepth.Text) || !int.TryParse(txtDepth.Text, out depth) || depth < MinDepth || depth > MaxDepth)
            {
                MessageBox.Show("Please enter a valid depth between 12 and 48 inches.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepth.BackColor = Color.LightPink;
                isValid = false;
            }
            else
            {
                txtDepth.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtnumDrawer.Text) || !int.TryParse(txtnumDrawer.Text, out numDrawers) || numDrawers < 0 || numDrawers > 7)
            {
                MessageBox.Show("Please enter a valid number of drawers between 0 and 7.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnumDrawer.BackColor = Color.LightPink;
                isValid = false;
            }
            else
            {
                txtnumDrawer.BackColor = Color.White;
            }

            DesktopMaterial selectedMaterial = DesktopMaterial.Laminate; 
            if (cmbMaterials.SelectedIndex != -1)
            {
                selectedMaterial = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), cmbMaterials.SelectedItem.ToString());
            }

            if (cmbRushOrder.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid rush order (3, 5, or 7).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRushOrder.BackColor = Color.LightPink;
                isValid = false;
            }
            else
            {
                rushOrder = (int)cmbRushOrder.SelectedItem;
                cmbRushOrder.BackColor = Color.White;
            }

            if (isValid)
            {
                totalPrice = 200;

                int surfaceArea = width * depth;
                if (surfaceArea > 1000)
                {
                    totalPrice += (surfaceArea - 1000); 
                }

                totalPrice += numDrawers * 50;

                switch (selectedMaterial)
                {
                    case DesktopMaterial.Oak:
                        totalPrice += 200;
                        break;
                    case DesktopMaterial.Laminate:
                        totalPrice += 100;
                        break;
                    case DesktopMaterial.Pine:
                        totalPrice += 50;
                        break;
                    case DesktopMaterial.Rosewood:
                        totalPrice += 300;
                        break;
                    case DesktopMaterial.Veneer:
                        totalPrice += 125;
                        break;
                }

                decimal rushOrderPrice = 0;
                if (surfaceArea < 1000)
                {
                    if (rushOrder == 3) rushOrderPrice = 60;
                    else if (rushOrder == 5) rushOrderPrice = 40;
                    else if (rushOrder == 7) rushOrderPrice = 30;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    if (rushOrder == 3) rushOrderPrice = 70;
                    else if (rushOrder == 5) rushOrderPrice = 50;
                    else if (rushOrder == 7) rushOrderPrice = 35;
                }
                else if (surfaceArea > 2000)
                {
                    if (rushOrder == 3) rushOrderPrice = 80;
                    else if (rushOrder == 5) rushOrderPrice = 60;
                    else if (rushOrder == 7) rushOrderPrice = 40;
                }

                totalPrice += rushOrderPrice;

                Desk desk = new Desk(width, depth, numDrawers, (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), selectedMaterial.ToString()));
                DeskQuote newQuote = new DeskQuote(desk, txtName.Text, rushOrder, DateTime.Now);
                DeskQuote.AddQuote(newQuote);
                newQuote.DisplayQuoteDetails();

                MessageBox.Show($"Name: {txtName.Text}\nWidth: {width}\"\nDepth: {depth}\"\nDrawers: {numDrawers}\nMaterial: {selectedMaterial}\nRush Order: {rushOrder}\nTotal Price: ${totalPrice}", "Quote Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void material_TextChanged(object sender, EventArgs e)
        {

        }

        private void rushOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
