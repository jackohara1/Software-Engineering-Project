namespace Hardware_Syst
{
    partial class New_Stock
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
            this.textStock_ID = new System.Windows.Forms.TextBox();
            this.textQty = new System.Windows.Forms.TextBox();
            this.textStock_Name = new System.Windows.Forms.TextBox();
            this.textCost_Price = new System.Windows.Forms.TextBox();
            this.Stock_ID = new System.Windows.Forms.Label();
            this.Stock_Name = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.Cost_Price = new System.Windows.Forms.Label();
            this.Sale_Price = new System.Windows.Forms.Label();
            this.textSale_Price = new System.Windows.Forms.TextBox();
            this.New_Stock_btn = new System.Windows.Forms.Button();
            this.Stock_TypeBox = new System.Windows.Forms.ComboBox();
            this.Stock_Type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textStock_ID
            // 
            this.textStock_ID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textStock_ID.Location = new System.Drawing.Point(364, 31);
            this.textStock_ID.Name = "textStock_ID";
            this.textStock_ID.ReadOnly = true;
            this.textStock_ID.Size = new System.Drawing.Size(50, 20);
            this.textStock_ID.TabIndex = 0;
            this.textStock_ID.Text = "001";
            // 
            // textQty
            // 
            this.textQty.Location = new System.Drawing.Point(122, 164);
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(100, 20);
            this.textQty.TabIndex = 1;
            // 
            // textStock_Name
            // 
            this.textStock_Name.Location = new System.Drawing.Point(122, 112);
            this.textStock_Name.Name = "textStock_Name";
            this.textStock_Name.Size = new System.Drawing.Size(100, 20);
            this.textStock_Name.TabIndex = 2;
            // 
            // textCost_Price
            // 
            this.textCost_Price.Location = new System.Drawing.Point(122, 209);
            this.textCost_Price.Name = "textCost_Price";
            this.textCost_Price.Size = new System.Drawing.Size(100, 20);
            this.textCost_Price.TabIndex = 3;
            // 
            // Stock_ID
            // 
            this.Stock_ID.AutoSize = true;
            this.Stock_ID.Location = new System.Drawing.Point(306, 34);
            this.Stock_ID.Name = "Stock_ID";
            this.Stock_ID.Size = new System.Drawing.Size(52, 13);
            this.Stock_ID.TabIndex = 4;
            this.Stock_ID.Text = "Stock_ID";
            this.Stock_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // Stock_Name
            // 
            this.Stock_Name.AutoSize = true;
            this.Stock_Name.Location = new System.Drawing.Point(24, 119);
            this.Stock_Name.Name = "Stock_Name";
            this.Stock_Name.Size = new System.Drawing.Size(66, 13);
            this.Stock_Name.TabIndex = 5;
            this.Stock_Name.Text = "Stock Name";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(24, 167);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(46, 13);
            this.Qty.TabIndex = 6;
            this.Qty.Text = "Quantity";
            // 
            // Cost_Price
            // 
            this.Cost_Price.AutoSize = true;
            this.Cost_Price.Location = new System.Drawing.Point(24, 216);
            this.Cost_Price.Name = "Cost_Price";
            this.Cost_Price.Size = new System.Drawing.Size(55, 13);
            this.Cost_Price.TabIndex = 7;
            this.Cost_Price.Text = "Cost Price";
            // 
            // Sale_Price
            // 
            this.Sale_Price.AutoSize = true;
            this.Sale_Price.Location = new System.Drawing.Point(24, 259);
            this.Sale_Price.Name = "Sale_Price";
            this.Sale_Price.Size = new System.Drawing.Size(55, 13);
            this.Sale_Price.TabIndex = 8;
            this.Sale_Price.Text = "Sale Price";
            // 
            // textSale_Price
            // 
            this.textSale_Price.Location = new System.Drawing.Point(122, 256);
            this.textSale_Price.Name = "textSale_Price";
            this.textSale_Price.Size = new System.Drawing.Size(100, 20);
            this.textSale_Price.TabIndex = 9;
            // 
            // New_Stock_btn
            // 
            this.New_Stock_btn.Location = new System.Drawing.Point(291, 313);
            this.New_Stock_btn.Name = "New_Stock_btn";
            this.New_Stock_btn.Size = new System.Drawing.Size(123, 23);
            this.New_Stock_btn.TabIndex = 10;
            this.New_Stock_btn.Text = "Register Stock";
            this.New_Stock_btn.UseVisualStyleBackColor = true;
            // 
            // Stock_TypeBox
            // 
            this.Stock_TypeBox.FormattingEnabled = true;
            this.Stock_TypeBox.Items.AddRange(new object[] {
            "Electrical",
            "Plumbing",
            "Hardware ",
            "Household",
            "Tools"});
            this.Stock_TypeBox.Location = new System.Drawing.Point(129, 310);
            this.Stock_TypeBox.Name = "Stock_TypeBox";
            this.Stock_TypeBox.Size = new System.Drawing.Size(121, 21);
            this.Stock_TypeBox.TabIndex = 11;
            // 
            // Stock_Type
            // 
            this.Stock_Type.AutoSize = true;
            this.Stock_Type.Location = new System.Drawing.Point(12, 313);
            this.Stock_Type.Name = "Stock_Type";
            this.Stock_Type.Size = new System.Drawing.Size(97, 13);
            this.Stock_Type.TabIndex = 12;
            this.Stock_Type.Text = "What type of stock";
            // 
            // New_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 348);
            this.Controls.Add(this.Stock_Type);
            this.Controls.Add(this.Stock_TypeBox);
            this.Controls.Add(this.New_Stock_btn);
            this.Controls.Add(this.textSale_Price);
            this.Controls.Add(this.Sale_Price);
            this.Controls.Add(this.Cost_Price);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.Stock_Name);
            this.Controls.Add(this.Stock_ID);
            this.Controls.Add(this.textCost_Price);
            this.Controls.Add(this.textStock_Name);
            this.Controls.Add(this.textQty);
            this.Controls.Add(this.textStock_ID);
            this.Name = "New_Stock";
            this.Tag = "";
            this.Text = "New_Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textStock_ID;
        private System.Windows.Forms.TextBox textQty;
        private System.Windows.Forms.TextBox textStock_Name;
        private System.Windows.Forms.TextBox textCost_Price;
        private System.Windows.Forms.Label Stock_ID;
        private System.Windows.Forms.Label Stock_Name;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label Cost_Price;
        private System.Windows.Forms.Label Sale_Price;
        private System.Windows.Forms.TextBox textSale_Price;
        private System.Windows.Forms.Button New_Stock_btn;
        private System.Windows.Forms.ComboBox Stock_TypeBox;
        private System.Windows.Forms.Label Stock_Type;
    }
}

