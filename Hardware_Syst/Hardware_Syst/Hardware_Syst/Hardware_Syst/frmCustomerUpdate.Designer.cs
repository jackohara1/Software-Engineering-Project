namespace Hardware_Syst
{
    partial class frmCustomerUpdate
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
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.txtAddLn3 = new System.Windows.Forms.TextBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblAddLn3 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAddLn2 = new System.Windows.Forms.TextBox();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.lblAddLn2 = new System.Windows.Forms.Label();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.lblAddLn1 = new System.Windows.Forms.Label();
            this.txtAddLn1 = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grdStockSearch = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStockName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.txtAddLn3);
            this.grpUpdate.Controls.Add(this.btnUpdateStock);
            this.grpUpdate.Controls.Add(this.txtNumber);
            this.grpUpdate.Controls.Add(this.lblAddLn3);
            this.grpUpdate.Controls.Add(this.lblCustomerName);
            this.grpUpdate.Controls.Add(this.txtCustomerName);
            this.grpUpdate.Controls.Add(this.txtAddLn2);
            this.grpUpdate.Controls.Add(this.lblCustomerSurname);
            this.grpUpdate.Controls.Add(this.txtCustomerSurname);
            this.grpUpdate.Controls.Add(this.lblAddLn2);
            this.grpUpdate.Controls.Add(this.lblCustomerNumber);
            this.grpUpdate.Controls.Add(this.lblAddLn1);
            this.grpUpdate.Controls.Add(this.txtAddLn1);
            this.grpUpdate.Location = new System.Drawing.Point(83, 306);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(490, 250);
            this.grpUpdate.TabIndex = 64;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update Customer";
            this.grpUpdate.Visible = false;
            // 
            // txtAddLn3
            // 
            this.txtAddLn3.Location = new System.Drawing.Point(214, 197);
            this.txtAddLn3.Name = "txtAddLn3";
            this.txtAddLn3.Size = new System.Drawing.Size(100, 20);
            this.txtAddLn3.TabIndex = 67;
            this.txtAddLn3.Text = "Co.Kerry";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(349, 195);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateStock.TabIndex = 21;
            this.btnUpdateStock.Text = "Update Customer";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(214, 102);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 58;
            this.txtNumber.Text = "087915264";
            // 
            // lblAddLn3
            // 
            this.lblAddLn3.AutoSize = true;
            this.lblAddLn3.Location = new System.Drawing.Point(109, 200);
            this.lblAddLn3.Name = "lblAddLn3";
            this.lblAddLn3.Size = new System.Drawing.Size(77, 13);
            this.lblAddLn3.TabIndex = 66;
            this.lblAddLn3.Text = "Address Line 3";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(109, 21);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(101, 13);
            this.lblCustomerName.TabIndex = 59;
            this.lblCustomerName.Text = "Customer Forename";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(214, 18);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 57;
            this.txtCustomerName.Text = "John";
            // 
            // txtAddLn2
            // 
            this.txtAddLn2.Location = new System.Drawing.Point(214, 171);
            this.txtAddLn2.Name = "txtAddLn2";
            this.txtAddLn2.Size = new System.Drawing.Size(100, 20);
            this.txtAddLn2.TabIndex = 65;
            this.txtAddLn2.Text = "Ballyheigue";
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.Location = new System.Drawing.Point(109, 56);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(96, 13);
            this.lblCustomerSurname.TabIndex = 60;
            this.lblCustomerSurname.Text = "Customer Surname";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(214, 53);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerSurname.TabIndex = 56;
            this.txtCustomerSurname.Text = "O\'Hara";
            // 
            // lblAddLn2
            // 
            this.lblAddLn2.AutoSize = true;
            this.lblAddLn2.Location = new System.Drawing.Point(109, 174);
            this.lblAddLn2.Name = "lblAddLn2";
            this.lblAddLn2.Size = new System.Drawing.Size(77, 13);
            this.lblAddLn2.TabIndex = 64;
            this.lblAddLn2.Text = "Address Line 2";
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Location = new System.Drawing.Point(109, 105);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(91, 13);
            this.lblCustomerNumber.TabIndex = 61;
            this.lblCustomerNumber.Text = "Customer Number";
            // 
            // lblAddLn1
            // 
            this.lblAddLn1.AutoSize = true;
            this.lblAddLn1.Location = new System.Drawing.Point(109, 148);
            this.lblAddLn1.Name = "lblAddLn1";
            this.lblAddLn1.Size = new System.Drawing.Size(77, 13);
            this.lblAddLn1.TabIndex = 62;
            this.lblAddLn1.Text = "Address Line 1";
            // 
            // txtAddLn1
            // 
            this.txtAddLn1.Location = new System.Drawing.Point(214, 145);
            this.txtAddLn1.Name = "txtAddLn1";
            this.txtAddLn1.Size = new System.Drawing.Size(100, 20);
            this.txtAddLn1.TabIndex = 63;
            this.txtAddLn1.Text = "Dirtane";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSelect);
            this.grpSearch.Controls.Add(this.grdStockSearch);
            this.grpSearch.Location = new System.Drawing.Point(72, 161);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(492, 139);
            this.grpSearch.TabIndex = 63;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Customer";
            this.grpSearch.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(386, 91);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(77, 23);
            this.btnSelect.TabIndex = 57;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // grdStockSearch
            // 
            this.grdStockSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStockSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.Surname,
            this.Forname});
            this.grdStockSearch.Location = new System.Drawing.Point(28, 27);
            this.grdStockSearch.Name = "grdStockSearch";
            this.grdStockSearch.Size = new System.Drawing.Size(352, 87);
            this.grdStockSearch.TabIndex = 47;
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
            this.btnSearch.Location = new System.Drawing.Point(419, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Location = new System.Drawing.Point(116, 70);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(96, 13);
            this.lblStockName.TabIndex = 61;
            this.lblStockName.Text = "Customer Surname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 60;
            // 
            // frmCustomerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 568);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStockName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCustomerUpdate";
            this.Text = "Update_Customer";
            this.Load += new System.EventHandler(this.frmCustomerUpdate_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStockSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView grdStockSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forname;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddLn3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblAddLn3;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAddLn2;
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label lblAddLn2;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label lblAddLn1;
        private System.Windows.Forms.TextBox txtAddLn1;
    }
}