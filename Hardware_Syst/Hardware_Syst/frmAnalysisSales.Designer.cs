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
            this.SaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(31, 101);
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
            "2018",
            "2017",
            "2016",
            "2015",
            "2014"});
            this.cboStockType.Location = new System.Drawing.Point(101, 98);
            this.cboStockType.Name = "cboStockType";
            this.cboStockType.Size = new System.Drawing.Size(121, 21);
            this.cboStockType.TabIndex = 13;
            this.cboStockType.SelectedIndexChanged += new System.EventHandler(this.cboStockType_SelectedIndexChanged);
            // 
            // btnSaleAnalsis
            // 
            this.btnSaleAnalsis.Location = new System.Drawing.Point(101, 174);
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
            this.grdSaleAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleID,
            this.FinalSalePrice,
            this.Customer_ID,
            this.Surname,
            this.SaleDate});
            this.grdSaleAnalysis.Location = new System.Drawing.Point(34, 229);
            this.grdSaleAnalysis.Name = "grdSaleAnalysis";
            this.grdSaleAnalysis.Size = new System.Drawing.Size(552, 140);
            this.grdSaleAnalysis.TabIndex = 46;
            this.grdSaleAnalysis.Visible = false;
            this.grdSaleAnalysis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStock_CellContentClick);
            // 
            // SaleID
            // 
            this.SaleID.HeaderText = "Sale ID";
            this.SaleID.Name = "SaleID";
            // 
            // FinalSalePrice
            // 
            this.FinalSalePrice.HeaderText = "Price";
            this.FinalSalePrice.Name = "FinalSalePrice";
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
            // SaleDate
            // 
            this.SaleDate.HeaderText = "Date";
            this.SaleDate.Name = "SaleDate";
            // 
            // frmAnalysisSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 396);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
    }
}