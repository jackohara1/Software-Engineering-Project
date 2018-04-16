namespace Hardware_Syst
{
    partial class frmAnalysisSales
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
            this.lblDate = new System.Windows.Forms.Label();
            this.cboStockType = new System.Windows.Forms.ComboBox();
            this.btnSaleAnalsis = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grdSaleAnalysis = new System.Windows.Forms.DataGridView();
            this.grpCredit = new System.Windows.Forms.GroupBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.grdCust = new System.Windows.Forms.DataGridView();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoCust = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleAnalysis)).BeginInit();
            this.grpCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCust)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(69, 61);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
            // 
            // cboStockType
            // 
            this.cboStockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStockType.FormattingEnabled = true;
            this.cboStockType.Items.AddRange(new object[] {
            "18",
            "17",
            "16",
            "15",
            "14"});
            this.cboStockType.Location = new System.Drawing.Point(139, 58);
            this.cboStockType.Name = "cboStockType";
            this.cboStockType.Size = new System.Drawing.Size(121, 21);
            this.cboStockType.TabIndex = 13;
            this.cboStockType.SelectedIndexChanged += new System.EventHandler(this.cboStockType_SelectedIndexChanged);
            // 
            // btnSaleAnalsis
            // 
            this.btnSaleAnalsis.Location = new System.Drawing.Point(286, 284);
            this.btnSaleAnalsis.Name = "btnSaleAnalsis";
            this.btnSaleAnalsis.Size = new System.Drawing.Size(123, 23);
            this.btnSaleAnalsis.TabIndex = 15;
            this.btnSaleAnalsis.Text = "Sale Analysis";
            this.btnSaleAnalsis.UseVisualStyleBackColor = true;
            this.btnSaleAnalsis.Visible = false;
            this.btnSaleAnalsis.Click += new System.EventHandler(this.btnSaleAnalsis_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grdSaleAnalysis
            // 
            this.grdSaleAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaleAnalysis.Location = new System.Drawing.Point(72, 368);
            this.grdSaleAnalysis.Name = "grdSaleAnalysis";
            this.grdSaleAnalysis.Size = new System.Drawing.Size(552, 140);
            this.grdSaleAnalysis.TabIndex = 46;
            this.grdSaleAnalysis.Visible = false;
            this.grdSaleAnalysis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStock_CellContentClick);
            // 
            // grpCredit
            // 
            this.grpCredit.Controls.Add(this.btnCustomer);
            this.grpCredit.Controls.Add(this.lblCustomer);
            this.grpCredit.Controls.Add(this.txtCustomer);
            this.grpCredit.Controls.Add(this.grdCust);
            this.grpCredit.Location = new System.Drawing.Point(286, 108);
            this.grpCredit.Name = "grpCredit";
            this.grpCredit.Size = new System.Drawing.Size(433, 150);
            this.grpCredit.TabIndex = 47;
            this.grpCredit.TabStop = false;
            this.grpCredit.Text = "Customer";
            this.grpCredit.Visible = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(278, 24);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(58, 29);
            this.btnCustomer.TabIndex = 49;
            this.btnCustomer.Text = "Search";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(17, 32);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(88, 13);
            this.lblCustomer.TabIndex = 48;
            this.lblCustomer.Text = "Search Cusotmer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(111, 29);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(142, 20);
            this.txtCustomer.TabIndex = 47;
            // 
            // grdCust
            // 
            this.grdCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCust.Location = new System.Drawing.Point(6, 59);
            this.grdCust.Name = "grdCust";
            this.grdCust.Size = new System.Drawing.Size(348, 87);
            this.grdCust.TabIndex = 46;
            this.grdCust.Visible = false;
            this.grdCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCust_CellClick);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(48, 183);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(65, 17);
            this.rdoAll.TabIndex = 48;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All Sales";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // rdoCust
            // 
            this.rdoCust.AutoSize = true;
            this.rdoCust.Location = new System.Drawing.Point(139, 183);
            this.rdoCust.Name = "rdoCust";
            this.rdoCust.Size = new System.Drawing.Size(119, 17);
            this.rdoCust.TabIndex = 49;
            this.rdoCust.Text = "Search by customer";
            this.rdoCust.UseVisualStyleBackColor = true;
            this.rdoCust.CheckedChanged += new System.EventHandler(this.rdoCust_CheckedChanged);
            // 
            // frmAnalysisSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 533);
            this.Controls.Add(this.rdoCust);
            this.Controls.Add(this.rdoAll);
            this.Controls.Add(this.grpCredit);
            this.Controls.Add(this.grdSaleAnalysis);
            this.Controls.Add(this.btnSaleAnalsis);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cboStockType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnalysisSales";
            this.Text = "frmAnalysisSales";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleAnalysis)).EndInit();
            this.grpCredit.ResumeLayout(false);
            this.grpCredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cboStockType;
        private System.Windows.Forms.Button btnSaleAnalsis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataGridView grdSaleAnalysis;
        private System.Windows.Forms.GroupBox grpCredit;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DataGridView grdCust;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoCust;
    }
}