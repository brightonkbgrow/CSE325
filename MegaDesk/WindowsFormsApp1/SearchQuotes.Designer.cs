namespace MegaDesk_Grow
{
    partial class SearchQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvQuotes = new System.Windows.Forms.DataGridView();
            this.txtSearchCustomerName = new System.Windows.Forms.TextBox();
            this.lblSearchCustomerName = new System.Windows.Forms.Label();
            this.cbMaterialFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuotes
            // 
            this.dgvQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuotes.Location = new System.Drawing.Point(221, 9);
            this.dgvQuotes.Name = "dgvQuotes";
            this.dgvQuotes.Size = new System.Drawing.Size(567, 429);
            this.dgvQuotes.TabIndex = 0;
            this.dgvQuotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgQuotes_CellContentClick);
            // 
            // txtSearchCustomerName
            // 
            this.txtSearchCustomerName.Location = new System.Drawing.Point(53, 6);
            this.txtSearchCustomerName.Name = "txtSearchCustomerName";
            this.txtSearchCustomerName.Size = new System.Drawing.Size(162, 20);
            this.txtSearchCustomerName.TabIndex = 1;
            // 
            // lblSearchCustomerName
            // 
            this.lblSearchCustomerName.AutoSize = true;
            this.lblSearchCustomerName.Location = new System.Drawing.Point(12, 9);
            this.lblSearchCustomerName.Name = "lblSearchCustomerName";
            this.lblSearchCustomerName.Size = new System.Drawing.Size(35, 13);
            this.lblSearchCustomerName.TabIndex = 4;
            this.lblSearchCustomerName.Text = "Name";
            // 
            // cbMaterialFilter
            // 
            this.cbMaterialFilter.FormattingEnabled = true;
            this.cbMaterialFilter.Location = new System.Drawing.Point(15, 32);
            this.cbMaterialFilter.Name = "cbMaterialFilter";
            this.cbMaterialFilter.Size = new System.Drawing.Size(200, 21);
            this.cbMaterialFilter.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(15, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 46);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(122, 59);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 46);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // SearchQuotes
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchCustomerName);
            this.Controls.Add(this.txtSearchCustomerName);
            this.Controls.Add(this.dgvQuotes);
            this.Controls.Add(this.cbMaterialFilter);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaterialFilter;
        private System.Windows.Forms.DataGridView dgvQuotes;
        private System.Windows.Forms.TextBox txtSearchCustomerName;
        private System.Windows.Forms.Label lblSearchCustomerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
    }
}