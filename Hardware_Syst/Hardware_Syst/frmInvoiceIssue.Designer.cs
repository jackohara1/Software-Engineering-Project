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
            this.btnPayInvoice = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
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
            this.grpSearch.Controls.Add(this.btnPayInvoice);
            this.grpSearch.Location = new System.Drawing.Point(34, 165);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(578, 139);
            this.grpSearch.TabIndex = 75;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Customer";
            this.grpSearch.Visible = false;
            // 
            // grdCustomerSearch
            // 
            this.grdCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomerSearch.Location = new System.Drawing.Point(28, 27);
            this.grdCustomerSearch.Name = "grdCustomerSearch";
            this.grdCustomerSearch.Size = new System.Drawing.Size(352, 87);
            this.grdCustomerSearch.TabIndex = 47;
            this.grdCustomerSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomerSearch_CellContentClick);
            // 
            // btnPayInvoice
            // 
            this.btnPayInvoice.Location = new System.Drawing.Point(410, 91);
            this.btnPayInvoice.Name = "btnPayInvoice";
            this.btnPayInvoice.Size = new System.Drawing.Size(123, 23);
            this.btnPayInvoice.TabIndex = 44;
            this.btnPayInvoice.Text = "Select";
            this.btnPayInvoice.UseVisualStyleBackColor = true;
            this.btnPayInvoice.Click += new System.EventHandler(this.btnPayInvoice_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 74;
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
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(179, 20);
            this.txtCustomer.TabIndex = 72;
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
            this.grpIssueInvoice.Location = new System.Drawing.Point(12, 328);
            this.grpIssueInvoice.Name = "grpIssueInvoice";
            this.grpIssueInvoice.Size = new System.Drawing.Size(681, 232);
            this.grpIssueInvoice.TabIndex = 76;
            this.grpIssueInvoice.TabStop = false;
            this.grpIssueInvoice.Text = "Issue Invoice";
            this.grpIssueInvoice.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(59, 135);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 79;
            this.lblAddress.Text = "Address";
            // 
            // txtAddln1
            // 
            this.txtAddln1.Location = new System.Drawing.Point(32, 155);
            this.txtAddln1.Name = "txtAddln1";
            this.txtAddln1.Size = new System.Drawing.Size(100, 20);
            this.txtAddln1.TabIndex = 78;
            // 
            // txtAddln3
            // 
            this.txtAddln3.Location = new System.Drawing.Point(32, 207);
            this.txtAddln3.Name = "txtAddln3";
            this.txtAddln3.Size = new System.Drawing.Size(100, 20);
            this.txtAddln3.TabIndex = 77;
            this.txtAddln3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAddln2
            // 
            this.txtAddln2.Location = new System.Drawing.Point(32, 181);
            this.txtAddln2.Name = "txtAddln2";
            this.txtAddln2.Size = new System.Drawing.Size(100, 20);
            this.txtAddln2.TabIndex = 76;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(560, 181);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(93, 20);
            this.txtTotal.TabIndex = 74;
            this.txtTotal.Text = "70.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(480, 188);
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
            this.grdIssue.Size = new System.Drawing.Size(661, 87);
            this.grdIssue.TabIndex = 72;
            // 
            // frmInvoiceIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 582);
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
        private System.Windows.Forms.Button btnPayInvoice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.GroupBox grpIssueInvoice;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView grdIssue;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddln1;
        private System.Windows.Forms.TextBox txtAddln3;
        private System.Windows.Forms.TextBox txtAddln2;
    }
}