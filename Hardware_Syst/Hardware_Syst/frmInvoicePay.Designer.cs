namespace Hardware_Syst
{
    partial class frmInvoicePay
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
            this.btnIssueInvoice = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grdCustomerSearch = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStockName = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.grdIssue = new System.Windows.Forms.DataGridView();
            this.Sale_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final_Sale_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpPayInvoice = new System.Windows.Forms.GroupBox();
            this.btnPayInvoice = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIssue)).BeginInit();
            this.grpPayInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIssueInvoice
            // 
            this.btnIssueInvoice.Location = new System.Drawing.Point(410, 91);
            this.btnIssueInvoice.Name = "btnIssueInvoice";
            this.btnIssueInvoice.Size = new System.Drawing.Size(123, 23);
            this.btnIssueInvoice.TabIndex = 44;
            this.btnIssueInvoice.Text = "Select";
            this.btnIssueInvoice.UseVisualStyleBackColor = true;
            this.btnIssueInvoice.Click += new System.EventHandler(this.btnPayInvoice_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.grdCustomerSearch);
            this.grpSearch.Controls.Add(this.btnIssueInvoice);
            this.grpSearch.Location = new System.Drawing.Point(39, 129);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(578, 139);
            this.grpSearch.TabIndex = 71;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Customer";
            this.grpSearch.Visible = false;
            // 
            // grdCustomerSearch
            // 
            this.grdCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomerSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.Surname,
            this.Forname});
            this.grdCustomerSearch.Location = new System.Drawing.Point(28, 27);
            this.grdCustomerSearch.Name = "grdCustomerSearch";
            this.grdCustomerSearch.Size = new System.Drawing.Size(352, 87);
            this.grdCustomerSearch.TabIndex = 47;
            // 
            // Customer_ID
            // 
            this.Customer_ID.HeaderText = "Customer ID";
            this.Customer_ID.Name = "Customer_ID";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // Forname
            // 
            this.Forname.HeaderText = "Forname";
            this.Forname.Name = "Forname";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(368, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Location = new System.Drawing.Point(65, 60);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(96, 13);
            this.lblStockName.TabIndex = 69;
            this.lblStockName.Text = "Customer Surname";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(167, 58);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(179, 20);
            this.txtCustomer.TabIndex = 68;
            // 
            // grdIssue
            // 
            this.grdIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIssue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sale_ID,
            this.Stock_ID,
            this.Stock_Name,
            this.Sale_Price,
            this.Qty,
            this.Final_Sale_Price});
            this.grdIssue.Location = new System.Drawing.Point(12, 16);
            this.grdIssue.Name = "grdIssue";
            this.grdIssue.Size = new System.Drawing.Size(661, 87);
            this.grdIssue.TabIndex = 72;
            // 
            // Sale_ID
            // 
            this.Sale_ID.HeaderText = "Sale ID";
            this.Sale_ID.Name = "Sale_ID";
            // 
            // Stock_ID
            // 
            this.Stock_ID.HeaderText = "Stock ID";
            this.Stock_ID.Name = "Stock_ID";
            // 
            // Stock_Name
            // 
            this.Stock_Name.HeaderText = "Stock Name";
            this.Stock_Name.Name = "Stock_Name";
            // 
            // Sale_Price
            // 
            this.Sale_Price.HeaderText = "Price";
            this.Sale_Price.Name = "Sale_Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            // 
            // Final_Sale_Price
            // 
            this.Final_Sale_Price.HeaderText = "Final Price";
            this.Final_Sale_Price.Name = "Final_Sale_Price";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(466, 131);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 73;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(560, 128);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(93, 20);
            this.txtTotal.TabIndex = 74;
            this.txtTotal.Text = "50.00";
            // 
            // grpPayInvoice
            // 
            this.grpPayInvoice.Controls.Add(this.btnPayInvoice);
            this.grpPayInvoice.Controls.Add(this.txtTotal);
            this.grpPayInvoice.Controls.Add(this.lblTotal);
            this.grpPayInvoice.Controls.Add(this.grdIssue);
            this.grpPayInvoice.Location = new System.Drawing.Point(12, 306);
            this.grpPayInvoice.Name = "grpPayInvoice";
            this.grpPayInvoice.Size = new System.Drawing.Size(681, 205);
            this.grpPayInvoice.TabIndex = 75;
            this.grpPayInvoice.TabStop = false;
            this.grpPayInvoice.Text = "Pay Invoice";
            this.grpPayInvoice.Visible = false;
            // 
            // btnPayInvoice
            // 
            this.btnPayInvoice.Location = new System.Drawing.Point(530, 170);
            this.btnPayInvoice.Name = "btnPayInvoice";
            this.btnPayInvoice.Size = new System.Drawing.Size(123, 23);
            this.btnPayInvoice.TabIndex = 75;
            this.btnPayInvoice.Text = "Pay Invoice";
            this.btnPayInvoice.UseVisualStyleBackColor = true;
            this.btnPayInvoice.Click += new System.EventHandler(this.btnPayInvoice_Click_1);
            // 
            // frmInvoicePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 559);
            this.Controls.Add(this.grpPayInvoice);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStockName);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInvoicePay";
            this.Text = "frmInvoicePay";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIssue)).EndInit();
            this.grpPayInvoice.ResumeLayout(false);
            this.grpPayInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIssueInvoice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridView grdCustomerSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forname;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DataGridView grdIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final_Sale_Price;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox grpPayInvoice;
        private System.Windows.Forms.Button btnPayInvoice;
    }
}