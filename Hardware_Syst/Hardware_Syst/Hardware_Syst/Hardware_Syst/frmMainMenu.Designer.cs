namespace Hardware_Syst
{
    partial class frmMainMenu
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
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockDiscontinue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockEnquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcessSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvoiceIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvoicePay = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalysisSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalysisStock = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.administratorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStockNew,
            this.mnuStockUpdate,
            this.mnuStockDiscontinue,
            this.mnuStockEnquiry});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // mnuStockNew
            // 
            this.mnuStockNew.Name = "mnuStockNew";
            this.mnuStockNew.Size = new System.Drawing.Size(169, 22);
            this.mnuStockNew.Text = "New Stock";
            this.mnuStockNew.Click += new System.EventHandler(this.mnuStockNew_Click);
            // 
            // mnuStockUpdate
            // 
            this.mnuStockUpdate.Name = "mnuStockUpdate";
            this.mnuStockUpdate.Size = new System.Drawing.Size(169, 22);
            this.mnuStockUpdate.Text = "Update Stock";
            this.mnuStockUpdate.Click += new System.EventHandler(this.mnuStockUpdate_Click);
            // 
            // mnuStockDiscontinue
            // 
            this.mnuStockDiscontinue.Name = "mnuStockDiscontinue";
            this.mnuStockDiscontinue.Size = new System.Drawing.Size(169, 22);
            this.mnuStockDiscontinue.Text = "Discontinue Stock";
            this.mnuStockDiscontinue.Click += new System.EventHandler(this.mnuStockDiscontinue_Click);
            // 
            // mnuStockEnquiry
            // 
            this.mnuStockEnquiry.Name = "mnuStockEnquiry";
            this.mnuStockEnquiry.Size = new System.Drawing.Size(169, 22);
            this.mnuStockEnquiry.Text = "Stock Enquiry";
            this.mnuStockEnquiry.Click += new System.EventHandler(this.mnuStockEnquiry_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomerReg,
            this.mnuCustomerUpdate,
            this.mnuCustomerQuery});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // mnuCustomerReg
            // 
            this.mnuCustomerReg.Name = "mnuCustomerReg";
            this.mnuCustomerReg.Size = new System.Drawing.Size(171, 22);
            this.mnuCustomerReg.Text = "Register Customer";
            this.mnuCustomerReg.Click += new System.EventHandler(this.mnuCustomerReg_Click);
            // 
            // mnuCustomerUpdate
            // 
            this.mnuCustomerUpdate.Name = "mnuCustomerUpdate";
            this.mnuCustomerUpdate.Size = new System.Drawing.Size(171, 22);
            this.mnuCustomerUpdate.Text = "Update Customer";
            this.mnuCustomerUpdate.Click += new System.EventHandler(this.mnuCustomerUpdate_Click);
            // 
            // mnuCustomerQuery
            // 
            this.mnuCustomerQuery.Name = "mnuCustomerQuery";
            this.mnuCustomerQuery.Size = new System.Drawing.Size(171, 22);
            this.mnuCustomerQuery.Text = "Query Customer";
            this.mnuCustomerQuery.Click += new System.EventHandler(this.mnuCustomerQuery_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcessSale,
            this.mnuReturnItem,
            this.mnuInvoiceIssue,
            this.mnuInvoicePay});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.saleToolStripMenuItem.Text = "Sale";
            // 
            // mnuProcessSale
            // 
            this.mnuProcessSale.Name = "mnuProcessSale";
            this.mnuProcessSale.Size = new System.Drawing.Size(141, 22);
            this.mnuProcessSale.Text = "Register Sale";
            this.mnuProcessSale.Click += new System.EventHandler(this.mnuProcessSale_Click);
            // 
            // mnuReturnItem
            // 
            this.mnuReturnItem.Name = "mnuReturnItem";
            this.mnuReturnItem.Size = new System.Drawing.Size(141, 22);
            this.mnuReturnItem.Text = "Return Item";
            this.mnuReturnItem.Click += new System.EventHandler(this.mnuReturnItem_Click);
            // 
            // mnuInvoiceIssue
            // 
            this.mnuInvoiceIssue.Name = "mnuInvoiceIssue";
            this.mnuInvoiceIssue.Size = new System.Drawing.Size(141, 22);
            this.mnuInvoiceIssue.Text = "Issue Invoice";
            this.mnuInvoiceIssue.Click += new System.EventHandler(this.mnuInvoiceIssue_Click);
            // 
            // mnuInvoicePay
            // 
            this.mnuInvoicePay.Name = "mnuInvoicePay";
            this.mnuInvoicePay.Size = new System.Drawing.Size(141, 22);
            this.mnuInvoicePay.Text = "Pay Invoice";
            this.mnuInvoicePay.Click += new System.EventHandler(this.mnuInvoicePay_Click);
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnalysisSale,
            this.mnuAnalysisStock});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // mnuAnalysisSale
            // 
            this.mnuAnalysisSale.Name = "mnuAnalysisSale";
            this.mnuAnalysisSale.Size = new System.Drawing.Size(149, 22);
            this.mnuAnalysisSale.Text = "Sales Analysis";
            this.mnuAnalysisSale.Click += new System.EventHandler(this.mnuAnalysisSale_Click);
            // 
            // mnuAnalysisStock
            // 
            this.mnuAnalysisStock.Name = "mnuAnalysisStock";
            this.mnuAnalysisStock.Size = new System.Drawing.Size(149, 22);
            this.mnuAnalysisStock.Text = "Stock Analysis";
            this.mnuAnalysisStock.Click += new System.EventHandler(this.mnuAnalysisStock_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 313);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStockNew;
        private System.Windows.Forms.ToolStripMenuItem mnuStockUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuStockDiscontinue;
        private System.Windows.Forms.ToolStripMenuItem mnuStockEnquiry;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerReg;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerQuery;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessSale;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnItem;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoiceIssue;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoicePay;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalysisSale;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalysisStock;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}