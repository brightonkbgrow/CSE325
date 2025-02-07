namespace MegaDesk_Grow
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumDrawer = new System.Windows.Forms.TextBox();
            this.textofname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbMaterials = new System.Windows.Forms.ComboBox();
            this.cmbRushOrder = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtWidth
            // 
            this.txtWidth.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtWidth.Location = new System.Drawing.Point(137, 34);
            this.txtWidth.MaxLength = 2;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(160, 20);
            this.txtWidth.TabIndex = 2;
            this.txtWidth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width: (24 to 96)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDepth
            // 
            this.txtDepth.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDepth.Location = new System.Drawing.Point(137, 60);
            this.txtDepth.MaxLength = 2;
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(160, 20);
            this.txtDepth.TabIndex = 4;
            this.txtDepth.TextChanged += new System.EventHandler(this.txtDepth_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Depth: (12 to 48)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(63, 375);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 46);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Drawers: (0 to 7)";
            // 
            // txtnumDrawer
            // 
            this.txtnumDrawer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnumDrawer.Location = new System.Drawing.Point(137, 86);
            this.txtnumDrawer.MaxLength = 2;
            this.txtnumDrawer.Name = "txtnumDrawer";
            this.txtnumDrawer.Size = new System.Drawing.Size(160, 20);
            this.txtnumDrawer.TabIndex = 8;
            this.txtnumDrawer.TextChanged += new System.EventHandler(this.numDrawer_TextChanged);
            // 
            // textofname
            // 
            this.textofname.AutoSize = true;
            this.textofname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textofname.Location = new System.Drawing.Point(73, 9);
            this.textofname.Name = "textofname";
            this.textofname.Size = new System.Drawing.Size(49, 17);
            this.textofname.TabIndex = 10;
            this.textofname.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rush Order:";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Location = new System.Drawing.Point(137, 9);
            this.txtName.MaxLength = 24;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 15;
            this.txtName.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // cmbMaterials
            // 
            this.cmbMaterials.FormattingEnabled = true;
            this.cmbMaterials.Location = new System.Drawing.Point(137, 112);
            this.cmbMaterials.Name = "cmbMaterials";
            this.cmbMaterials.Size = new System.Drawing.Size(160, 21);
            this.cmbMaterials.TabIndex = 16;
            // 
            // cmbRushOrder
            // 
            this.cmbRushOrder.FormattingEnabled = true;
            this.cmbRushOrder.Location = new System.Drawing.Point(137, 137);
            this.cmbRushOrder.Name = "cmbRushOrder";
            this.cmbRushOrder.Size = new System.Drawing.Size(160, 21);
            this.cmbRushOrder.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(171, 375);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 46);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbRushOrder);
            this.Controls.Add(this.cmbMaterials);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textofname);
            this.Controls.Add(this.txtnumDrawer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWidth);
            this.Name = "AddQuote";
            this.Text = "MegaDesk_Grow";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumDrawer;
        private System.Windows.Forms.Label textofname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbMaterials;
        private System.Windows.Forms.ComboBox cmbRushOrder;
        private System.Windows.Forms.Button btnBack;
    }
}