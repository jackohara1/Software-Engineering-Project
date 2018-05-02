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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grdCustomerSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStockName = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.grdIssue = new System.Windows.Forms.DataGridView();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
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
            this.grpSearch.Location = new System.Drawing.Point(520, 40);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(409, 139);
            this.grpSearch.TabIndex = 71;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Customer";
            this.grpSearch.Visible = false;
            // 
            // grdCustomerSearch
            // 
            this.grdCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomerSearch.Location = new System.Drawing.Point(28, 27);
            this.grdCustomerSearch.Name = "grdCustomerSearch";
            this.grdCustomerSearch.ReadOnly = true;
            this.grdCustomerSearch.Size = new System.Drawing.Size(352, 87);
            this.grdCustomerSearch.TabIndex = 47;
            this.grdCustomerSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomerSearch_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(368, 62);
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
            this.lblStockName.Location = new System.Drawing.Point(65, 67);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(96, 13);
            this.lblStockName.TabIndex = 69;
            this.lblStockName.Text = "Customer Surname";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(167, 65);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(179, 20);
            this.txtCustomer.TabIndex = 68;
            // 
            // grdIssue
            // 
            this.grdIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIssue.Location = new System.Drawing.Point(12, 29);
            this.grdIssue.Name = "grdIssue";
            this.grdIssue.ReadOnly = true;
            this.grdIssue.Size = new System.Drawing.Size(844, 211);
            this.grdIssue.TabIndex = 72;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(691, 268);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 73;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(763, 265);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(93, 20);
            this.txtTotal.TabIndex = 74;
            this.txtTotal.Text = "0.00";
            // 
            // grpPayInvoice
            // 
            this.grpPayInvoice.Controls.Add(this.btnPayInvoice);
            this.grpPayInvoice.Controls.Add(this.txtTotal);
            this.grpPayInvoice.Controls.Add(this.lblTotal);
            this.grpPayInvoice.Controls.Add(this.grdIssue);
            this.grpPayInvoice.Location = new System.Drawing.Point(12, 196);
            this.grpPayInvoice.Name = "grpPayInvoice";
            this.grpPayInvoice.Size = new System.Drawing.Size(888, 339);
            this.grpPayInvoice.TabIndex = 75;
            this.grpPayInvoice.TabStop = false;
            this.grpPayInvoice.Text = "Pay Invoice";
            this.grpPayInvoice.Visible = false;
            // 
            // btnPayInvoice
            // 
            this.btnPayInvoice.Location = new System.Drawing.Point(733, 307);
            this.btnPayInvoice.Name = "btnPayInvoice";
            this.btnPayInvoice.Size = new System.Drawing.Size(123, 23);
            this.btnPayInvoice.TabIndex = 75;
            this.btnPayInvoice.Text = "Pay Invoice";
            this.btnPayInvoice.UseVisualStyleBackColor = true;
            this.btnPayInvoice.Click += new System.EventHandler(this.btnPayInvoice_Click);
            // 
            // frmInvoicePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 559);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridView grdCustomerSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DataGridView grdIssue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox grpPayInvoice;
        private System.Windows.Forms.Button btnPayInvoice;
    }
}