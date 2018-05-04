namespace Hardware_Syst
{
    partial class frmInvoiceIssue
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
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grdCustomerSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStockName = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.grpIssueInvoice = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddln1 = new System.Windows.Forms.TextBox();
            this.txtAddln3 = new System.Windows.Forms.TextBox();
            this.txtAddln2 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grdIssue = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerSearch)).BeginInit();
            this.grpIssueInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 42;
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
            this.grpSearch.Location = new System.Drawing.Point(510, 56);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(394, 139);
            this.grpSearch.TabIndex = 75;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Customer";
            this.grpSearch.Visible = false;
            // 
            // grdCustomerSearch
            // 
            this.grdCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomerSearch.Location = new System.Drawing.Point(19, 31);
            this.grdCustomerSearch.Name = "grdCustomerSearch";
            this.grdCustomerSearch.ReadOnly = true;
            this.grdCustomerSearch.Size = new System.Drawing.Size(352, 87);
            this.grdCustomerSearch.TabIndex = 3;
            this.grdCustomerSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomerSearch_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Location = new System.Drawing.Point(71, 96);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(96, 13);
            this.lblStockName.TabIndex = 73;
            this.lblStockName.Text = "Customer Surname";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(173, 94);
            this.txtCustomer.MaxLength = 30;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(179, 20);
            this.txtCustomer.TabIndex = 1;
            // 
            // grpIssueInvoice
            // 
            this.grpIssueInvoice.Controls.Add(this.lblAddress);
            this.grpIssueInvoice.Controls.Add(this.txtAddln1);
            this.grpIssueInvoice.Controls.Add(this.txtAddln3);
            this.grpIssueInvoice.Controls.Add(this.txtAddln2);
            this.grpIssueInvoice.Controls.Add(this.txtTotal);
            this.grpIssueInvoice.Controls.Add(this.lblTotal);
            this.grpIssueInvoice.Controls.Add(this.grdIssue);
            this.grpIssueInvoice.Location = new System.Drawing.Point(12, 201);
            this.grpIssueInvoice.Name = "grpIssueInvoice";
            this.grpIssueInvoice.Size = new System.Drawing.Size(842, 359);
            this.grpIssueInvoice.TabIndex = 76;
            this.grpIssueInvoice.TabStop = false;
            this.grpIssueInvoice.Text = "Issue Invoice";
            this.grpIssueInvoice.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(50, 238);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 79;
            this.lblAddress.Text = "Address";
            // 
            // txtAddln1
            // 
            this.txtAddln1.Enabled = false;
            this.txtAddln1.Location = new System.Drawing.Point(23, 258);
            this.txtAddln1.Name = "txtAddln1";
            this.txtAddln1.ReadOnly = true;
            this.txtAddln1.Size = new System.Drawing.Size(121, 20);
            this.txtAddln1.TabIndex = 78;
            // 
            // txtAddln3
            // 
            this.txtAddln3.Enabled = false;
            this.txtAddln3.Location = new System.Drawing.Point(23, 310);
            this.txtAddln3.Name = "txtAddln3";
            this.txtAddln3.ReadOnly = true;
            this.txtAddln3.Size = new System.Drawing.Size(121, 20);
            this.txtAddln3.TabIndex = 77;
            // 
            // txtAddln2
            // 
            this.txtAddln2.Enabled = false;
            this.txtAddln2.Location = new System.Drawing.Point(23, 284);
            this.txtAddln2.Name = "txtAddln2";
            this.txtAddln2.ReadOnly = true;
            this.txtAddln2.Size = new System.Drawing.Size(121, 20);
            this.txtAddln2.TabIndex = 76;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(715, 326);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(93, 20);
            this.txtTotal.TabIndex = 74;
            this.txtTotal.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(635, 333);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 73;
            this.lblTotal.Text = "Total";
            // 
            // grdIssue
            // 
            this.grdIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIssue.Location = new System.Drawing.Point(14, 35);
            this.grdIssue.Name = "grdIssue";
            this.grdIssue.ReadOnly = true;
            this.grdIssue.Size = new System.Drawing.Size(797, 200);
            this.grdIssue.TabIndex = 72;
            // 
            // frmInvoiceIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 582);
            this.Controls.Add(this.grpIssueInvoice);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStockName);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInvoiceIssue";
            this.Text = "frmInvoiceIssue";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerSearch)).EndInit();
            this.grpIssueInvoice.ResumeLayout(false);
            this.grpIssueInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridView grdCustomerSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.GroupBox grpIssueInvoice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView grdIssue;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddln1;
        private System.Windows.Forms.TextBox txtAddln3;
        private System.Windows.Forms.TextBox txtAddln2;
        private System.Windows.Forms.TextBox txtTotal;
    }
}