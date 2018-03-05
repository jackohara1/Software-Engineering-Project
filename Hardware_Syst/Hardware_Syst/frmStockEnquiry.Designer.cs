namespace Hardware_Syst
{
    partial class frmStockEnquiry
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grdStockSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStockName = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.grdEnquiry = new System.Windows.Forms.DataGridView();
            this.Stock_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Cost_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEnquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.grdStockSearch);
            this.grpSearch.Location = new System.Drawing.Point(82, 128);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(440, 158);
            this.grpSearch.TabIndex = 62;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Stock";
            this.grpSearch.Visible = false;
            // 
            // grdStockSearch
            // 
            this.grdStockSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStockSearch.Location = new System.Drawing.Point(39, 27);
            this.grdStockSearch.Name = "grdStockSearch";
            this.grdStockSearch.Size = new System.Drawing.Size(325, 106);
            this.grdStockSearch.TabIndex = 47;
            this.grdStockSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStockSearch_CellClick);

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(366, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Location = new System.Drawing.Point(79, 60);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(66, 13);
            this.lblStockName.TabIndex = 60;
            this.lblStockName.Text = "Stock Name";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(165, 53);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(179, 20);
            this.txtStockName.TabIndex = 59;
            // 
            // grdEnquiry
            // 
            this.grdEnquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEnquiry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stock_id,
            this.Stock_Name,
            this.Stock_Cost_p,
            this.Stock_p,
            this.Qty,
            this.Department,
            this.Status});
            this.grdEnquiry.Location = new System.Drawing.Point(82, 337);
            this.grdEnquiry.Name = "grdEnquiry";
            this.grdEnquiry.Size = new System.Drawing.Size(745, 62);
            this.grdEnquiry.TabIndex = 63;
            this.grdEnquiry.Visible = false;
            // 
            // Stock_id
            // 
            this.Stock_id.HeaderText = "Stock ID";
            this.Stock_id.Name = "Stock_id";
            // 
            // Stock_Name
            // 
            this.Stock_Name.HeaderText = "Name";
            this.Stock_Name.Name = "Stock_Name";
            // 
            // Stock_Cost_p
            // 
            this.Stock_Cost_p.HeaderText = "Cost Price";
            this.Stock_Cost_p.Name = "Stock_Cost_p";
            // 
            // Stock_p
            // 
            this.Stock_p.HeaderText = "Sale Price";
            this.Stock_p.Name = "Stock_p";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // frmStockEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 519);
            this.Controls.Add(this.grdEnquiry);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStockName);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStockEnquiry";
            this.Text = "Stock_Enquirery";
            this.Load += new System.EventHandler(this.frmStockEnquiry_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStockSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEnquiry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridView grdStockSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.DataGridView grdEnquiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Cost_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}