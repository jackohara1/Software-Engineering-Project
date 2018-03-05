namespace Hardware_Syst
{
    partial class Update_Stock
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStockName = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.grdStockSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.lblStockType = new System.Windows.Forms.Label();
            this.cboStockType = new System.Windows.Forms.ComboBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.stockid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockSearch)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Location = new System.Drawing.Point(58, 80);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(66, 13);
            this.lblStockName.TabIndex = 33;
            this.lblStockName.Text = "Stock Name";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(144, 73);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(179, 20);
            this.txtStockName.TabIndex = 32;
            this.txtStockName.TextChanged += new System.EventHandler(this.txtStockName_TextChanged);
            // 
            // grdStockSearch
            // 
            this.grdStockSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStockSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockid,
            this.stockname});
            this.grdStockSearch.Location = new System.Drawing.Point(28, 27);
            this.grdStockSearch.Name = "grdStockSearch";
            this.grdStockSearch.Size = new System.Drawing.Size(241, 87);
            this.grdStockSearch.TabIndex = 47;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(345, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(308, 91);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(77, 23);
            this.btnSelect.TabIndex = 57;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSelect);
            this.grpSearch.Controls.Add(this.grdStockSearch);
            this.grpSearch.Location = new System.Drawing.Point(33, 120);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(391, 139);
            this.grpSearch.TabIndex = 58;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Stock";
            this.grpSearch.Visible = false;
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.lblStockType);
            this.grpUpdate.Controls.Add(this.cboStockType);
            this.grpUpdate.Controls.Add(this.btnUpdateStock);
            this.grpUpdate.Controls.Add(this.txtSalePrice);
            this.grpUpdate.Controls.Add(this.lblSalePrice);
            this.grpUpdate.Controls.Add(this.lblCostPrice);
            this.grpUpdate.Controls.Add(this.lblQty);
            this.grpUpdate.Controls.Add(this.label1);
            this.grpUpdate.Controls.Add(this.txtCostPrice);
            this.grpUpdate.Controls.Add(this.txtStock);
            this.grpUpdate.Controls.Add(this.txtQty);
            this.grpUpdate.Location = new System.Drawing.Point(33, 275);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(450, 280);
            this.grpUpdate.TabIndex = 59;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Enter Stock Details";
            this.grpUpdate.Visible = false;
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Location = new System.Drawing.Point(97, 35);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(62, 13);
            this.lblStockType.TabIndex = 36;
            this.lblStockType.Text = "Department";
            // 
            // cboStockType
            // 
            this.cboStockType.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboStockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStockType.FormattingEnabled = true;
            this.cboStockType.Items.AddRange(new object[] {
            "EL - Electrical",
            "PL - Plumbing",
            "HW - Hardware ",
            "HO - Household",
            "TL - Tools"});
            this.cboStockType.Location = new System.Drawing.Point(179, 32);
            this.cboStockType.Name = "cboStockType";
            this.cboStockType.Size = new System.Drawing.Size(121, 21);
            this.cboStockType.TabIndex = 35;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(177, 225);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateStock.TabIndex = 34;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click_1);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(179, 188);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(100, 20);
            this.txtSalePrice.TabIndex = 33;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(104, 188);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(55, 13);
            this.lblSalePrice.TabIndex = 32;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(104, 152);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(55, 13);
            this.lblCostPrice.TabIndex = 31;
            this.lblCostPrice.Text = "Cost Price";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(107, 116);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 13);
            this.lblQty.TabIndex = 30;
            this.lblQty.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Stock Name";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(179, 152);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(100, 20);
            this.txtCostPrice.TabIndex = 28;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(179, 74);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(179, 20);
            this.txtStock.TabIndex = 27;
            this.txtStock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(179, 116);
            this.txtQty.MaxLength = 3;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(34, 20);
            this.txtQty.TabIndex = 26;
            // 
            // stockid
            // 
            this.stockid.HeaderText = "stock id";
            this.stockid.Name = "stockid";
            // 
            // stockname
            // 
            this.stockname.HeaderText = "stock name";
            this.stockname.Name = "stockname";
            // 
            // Update_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 553);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStockName);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Update_Stock";
            this.Text = "Update_Stock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.DataGridView grdStockSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.ComboBox cboStockType;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockname;
    }
}