using System;

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
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.grdCart = new System.Windows.Forms.DataGridView();
            this.lblAmountOfItems = new System.Windows.Forms.Label();
            this.txtQtySold = new System.Windows.Forms.TextBox();
            this.lblItemBack = new System.Windows.Forms.Label();
            this.btnSrh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnItem
            // 
            this.btnReturnItem.Location = new System.Drawing.Point(518, 481);
            this.btnReturnItem.Name = "btnReturnItem";
            this.btnReturnItem.Size = new System.Drawing.Size(123, 23);
            this.btnReturnItem.TabIndex = 5;
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
            this.txtSaleID.TabIndex = 1;
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
            // grpStock
            // 
            this.grpStock.Controls.Add(this.rdoFalse);
            this.grpStock.Controls.Add(this.rdoTrue);
            this.grpStock.Controls.Add(this.grdCart);
            this.grpStock.Controls.Add(this.lblAmountOfItems);
            this.grpStock.Controls.Add(this.txtQtySold);
            this.grpStock.Controls.Add(this.lblItemBack);
            this.grpStock.Location = new System.Drawing.Point(26, 140);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(488, 315);
            this.grpStock.TabIndex = 47;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Stock";
            this.grpStock.Visible = false;
            // 
            // rdoFalse
            // 
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Checked = true;
            this.rdoFalse.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdoFalse.Location = new System.Drawing.Point(305, 230);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(39, 17);
            this.rdoFalse.TabIndex = 52;
            this.rdoFalse.TabStop = true;
            this.rdoFalse.Text = "No";
            this.rdoFalse.UseVisualStyleBackColor = true;
            this.rdoFalse.Visible = false;
            // 
            // rdoTrue
            // 
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Location = new System.Drawing.Point(231, 230);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(43, 17);
            this.rdoTrue.TabIndex = 51;
            this.rdoTrue.Text = "Yes";
            this.rdoTrue.UseVisualStyleBackColor = true;
            this.rdoTrue.Visible = false;
            // 
            // grdCart
            // 
            this.grdCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCart.Location = new System.Drawing.Point(16, 31);
            this.grdCart.Name = "grdCart";
            this.grdCart.ReadOnly = true;
            this.grdCart.Size = new System.Drawing.Size(444, 149);
            this.grdCart.TabIndex = 3;
            this.grdCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCart_CellClick);
            // 
            // lblAmountOfItems
            // 
            this.lblAmountOfItems.AutoSize = true;
            this.lblAmountOfItems.Location = new System.Drawing.Point(25, 275);
            this.lblAmountOfItems.Name = "lblAmountOfItems";
            this.lblAmountOfItems.Size = new System.Drawing.Size(82, 13);
            this.lblAmountOfItems.TabIndex = 44;
            this.lblAmountOfItems.Text = "Amount of items";
            this.lblAmountOfItems.Visible = false;
            // 
            // txtQtySold
            // 
            this.txtQtySold.Location = new System.Drawing.Point(113, 272);
            this.txtQtySold.MaxLength = 3;
            this.txtQtySold.Name = "txtQtySold";
            this.txtQtySold.Size = new System.Drawing.Size(63, 20);
            this.txtQtySold.TabIndex = 4;
            this.txtQtySold.Visible = false;
            // 
            // lblItemBack
            // 
            this.lblItemBack.AutoSize = true;
            this.lblItemBack.Location = new System.Drawing.Point(24, 230);
            this.lblItemBack.Name = "lblItemBack";
            this.lblItemBack.Size = new System.Drawing.Size(162, 13);
            this.lblItemBack.TabIndex = 42;
            this.lblItemBack.Text = "Will item be added back to stock";
            this.lblItemBack.Visible = false;
            // 
            // btnSrh
            // 
            this.btnSrh.Location = new System.Drawing.Point(242, 81);
            this.btnSrh.Name = "btnSrh";
            this.btnSrh.Size = new System.Drawing.Size(58, 29);
            this.btnSrh.TabIndex = 2;
            this.btnSrh.Text = "Search";
            this.btnSrh.UseVisualStyleBackColor = true;
            this.btnSrh.Click += new System.EventHandler(this.btnSrh_Click);
            // 
            // frmReturnItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 530);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.btnSrh);
            this.Controls.Add(this.btnReturnItem);
            this.Controls.Add(this.txtSaleID);
            this.Controls.Add(this.lblSaleID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReturnItem";
            this.Text = "Return_Item";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.Button btnSrh;
        private System.Windows.Forms.Label lblAmountOfItems;
        private System.Windows.Forms.TextBox txtQtySold;
        private System.Windows.Forms.DataGridView grdCart;
        private System.Windows.Forms.Label lblItemBack;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.RadioButton rdoTrue;
    }
}