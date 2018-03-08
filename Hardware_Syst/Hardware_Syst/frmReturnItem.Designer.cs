namespace Hardware_Syst
{
    partial class frmReturnItem
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
            this.btnReturnItem = new System.Windows.Forms.Button();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.lblSaleID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCredit = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.grdCust = new System.Windows.Forms.DataGridView();
            this.lblCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblforename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.grdCart = new System.Windows.Forms.DataGridView();
            this.lblAmountOfItems = new System.Windows.Forms.Label();
            this.txtQtySold = new System.Windows.Forms.TextBox();
            this.cboWillStockReturn = new System.Windows.Forms.ComboBox();
            this.lblItemBack = new System.Windows.Forms.Label();
            this.cboHowCustomerPayed = new System.Windows.Forms.ComboBox();
            this.lblHowCustomerPayed = new System.Windows.Forms.Label();
            this.btnSrh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCust)).BeginInit();
            this.grpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnItem
            // 
            this.btnReturnItem.Location = new System.Drawing.Point(518, 481);
            this.btnReturnItem.Name = "btnReturnItem";
            this.btnReturnItem.Size = new System.Drawing.Size(123, 23);
            this.btnReturnItem.TabIndex = 30;
            this.btnReturnItem.Text = "Return Item";
            this.btnReturnItem.UseVisualStyleBackColor = true;
            this.btnReturnItem.Visible = false;
            this.btnReturnItem.Click += new System.EventHandler(this.btnReturnItem_Click);
            // 
            // txtSaleID
            // 
            this.txtSaleID.Location = new System.Drawing.Point(124, 86);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(100, 20);
            this.txtSaleID.TabIndex = 29;
            // 
            // lblSaleID
            // 
            this.lblSaleID.AutoSize = true;
            this.lblSaleID.Location = new System.Drawing.Point(23, 89);
            this.lblSaleID.Name = "lblSaleID";
            this.lblSaleID.Size = new System.Drawing.Size(42, 13);
            this.lblSaleID.TabIndex = 28;
            this.lblSaleID.Text = "Sale ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpCredit
            // 
            this.grpCredit.Controls.Add(this.btnAddCustomer);
            this.grpCredit.Controls.Add(this.btnCustomer);
            this.grpCredit.Controls.Add(this.lblCustomer);
            this.grpCredit.Controls.Add(this.txtCustomer);
            this.grpCredit.Controls.Add(this.grdCust);
            this.grpCredit.Location = new System.Drawing.Point(12, 518);
            this.grpCredit.Name = "grpCredit";
            this.grpCredit.Size = new System.Drawing.Size(468, 166);
            this.grpCredit.TabIndex = 43;
            this.grpCredit.TabStop = false;
            this.grpCredit.Text = "Credit";
            this.grpCredit.Visible = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(401, 96);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(58, 29);
            this.btnAddCustomer.TabIndex = 55;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Visible = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(304, 17);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(58, 29);
            this.btnCustomer.TabIndex = 54;
            this.btnCustomer.Text = "Search";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(43, 25);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(88, 13);
            this.lblCustomer.TabIndex = 53;
            this.lblCustomer.Text = "Search Cusotmer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(137, 22);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(142, 20);
            this.txtCustomer.TabIndex = 52;
            // 
            // grdCust
            // 
            this.grdCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lblCustID,
            this.Surname,
            this.lblforename});
            this.grdCust.Location = new System.Drawing.Point(33, 69);
            this.grdCust.Name = "grdCust";
            this.grdCust.Size = new System.Drawing.Size(348, 87);
            this.grdCust.TabIndex = 51;
            this.grdCust.Visible = false;
            // 
            // lblCustID
            // 
            this.lblCustID.HeaderText = "Customer ID";
            this.lblCustID.Name = "lblCustID";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // lblforename
            // 
            this.lblforename.HeaderText = "Forename";
            this.lblforename.Name = "lblforename";
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.grdCart);
            this.grpStock.Controls.Add(this.lblAmountOfItems);
            this.grpStock.Controls.Add(this.txtQtySold);
            this.grpStock.Controls.Add(this.cboWillStockReturn);
            this.grpStock.Controls.Add(this.lblItemBack);
            this.grpStock.Controls.Add(this.cboHowCustomerPayed);
            this.grpStock.Controls.Add(this.lblHowCustomerPayed);
            this.grpStock.Location = new System.Drawing.Point(26, 140);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(488, 315);
            this.grpStock.TabIndex = 47;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Stock";
            this.grpStock.Visible = false;
            // 
            // grdCart
            // 
            this.grdCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCart.Location = new System.Drawing.Point(10, 143);
            this.grdCart.Name = "grdCart";
            this.grdCart.Size = new System.Drawing.Size(444, 149);
            this.grdCart.TabIndex = 50;
            this.grdCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCart_CellContentClick);
            // 
            // lblAmountOfItems
            // 
            this.lblAmountOfItems.AutoSize = true;
            this.lblAmountOfItems.Location = new System.Drawing.Point(12, 42);
            this.lblAmountOfItems.Name = "lblAmountOfItems";
            this.lblAmountOfItems.Size = new System.Drawing.Size(82, 13);
            this.lblAmountOfItems.TabIndex = 44;
            this.lblAmountOfItems.Text = "Amount of items";
            // 
            // txtQtySold
            // 
            this.txtQtySold.Location = new System.Drawing.Point(100, 35);
            this.txtQtySold.MaxLength = 3;
            this.txtQtySold.Name = "txtQtySold";
            this.txtQtySold.Size = new System.Drawing.Size(63, 20);
            this.txtQtySold.TabIndex = 43;
            this.txtQtySold.TextChanged += new System.EventHandler(this.txtQtySold_TextChanged);
            // 
            // cboWillStockReturn
            // 
            this.cboWillStockReturn.FormattingEnabled = true;
            this.cboWillStockReturn.Items.AddRange(new object[] {
            "N - No",
            "Y - Yes"});
            this.cboWillStockReturn.Location = new System.Drawing.Point(270, 116);
            this.cboWillStockReturn.Name = "cboWillStockReturn";
            this.cboWillStockReturn.Size = new System.Drawing.Size(67, 21);
            this.cboWillStockReturn.TabIndex = 35;
            // 
            // lblItemBack
            // 
            this.lblItemBack.AutoSize = true;
            this.lblItemBack.Location = new System.Drawing.Point(9, 116);
            this.lblItemBack.Name = "lblItemBack";
            this.lblItemBack.Size = new System.Drawing.Size(162, 13);
            this.lblItemBack.TabIndex = 42;
            this.lblItemBack.Text = "Will item be added back to stock";
            // 
            // cboHowCustomerPayed
            // 
            this.cboHowCustomerPayed.FormattingEnabled = true;
            this.cboHowCustomerPayed.Items.AddRange(new object[] {
            "Credit",
            "Cash",
            "Replace"});
            this.cboHowCustomerPayed.Location = new System.Drawing.Point(216, 75);
            this.cboHowCustomerPayed.Name = "cboHowCustomerPayed";
            this.cboHowCustomerPayed.Size = new System.Drawing.Size(121, 21);
            this.cboHowCustomerPayed.TabIndex = 33;
            this.cboHowCustomerPayed.SelectedIndexChanged += new System.EventHandler(this.cboHowCustomerPayed_SelectedIndexChanged);
            // 
            // lblHowCustomerPayed
            // 
            this.lblHowCustomerPayed.AutoSize = true;
            this.lblHowCustomerPayed.Location = new System.Drawing.Point(12, 78);
            this.lblHowCustomerPayed.Name = "lblHowCustomerPayed";
            this.lblHowCustomerPayed.Size = new System.Drawing.Size(159, 13);
            this.lblHowCustomerPayed.TabIndex = 34;
            this.lblHowCustomerPayed.Text = "How will the Customer be Payed";
            this.lblHowCustomerPayed.Click += new System.EventHandler(this.lblHowCustomerPayed_Click);
            // 
            // btnSrh
            // 
            this.btnSrh.Location = new System.Drawing.Point(242, 81);
            this.btnSrh.Name = "btnSrh";
            this.btnSrh.Size = new System.Drawing.Size(58, 29);
            this.btnSrh.TabIndex = 46;
            this.btnSrh.Text = "Search";
            this.btnSrh.UseVisualStyleBackColor = true;
            this.btnSrh.Click += new System.EventHandler(this.btnSrh_Click);
            // 
            // frmReturnItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 705);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.btnSrh);
            this.Controls.Add(this.grpCredit);
            this.Controls.Add(this.btnReturnItem);
            this.Controls.Add(this.txtSaleID);
            this.Controls.Add(this.lblSaleID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReturnItem";
            this.Text = "Return_Item";
            this.Load += new System.EventHandler(this.frmReturnItem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCredit.ResumeLayout(false);
            this.grpCredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCust)).EndInit();
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturnItem;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Label lblSaleID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpCredit;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.Button btnSrh;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DataGridView grdCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblforename;
        private System.Windows.Forms.Label lblAmountOfItems;
        private System.Windows.Forms.TextBox txtQtySold;
        private System.Windows.Forms.DataGridView grdCart;
        private System.Windows.Forms.ComboBox cboWillStockReturn;
        private System.Windows.Forms.Label lblItemBack;
        private System.Windows.Forms.ComboBox cboHowCustomerPayed;
        private System.Windows.Forms.Label lblHowCustomerPayed;
    }
}