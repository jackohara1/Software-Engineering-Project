namespace Hardware_Syst
{
    partial class frmAnalysisStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStockAnalsis = new System.Windows.Forms.Button();
            this.lblStockType = new System.Windows.Forms.Label();
            this.cboStockType = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdStockAnalysis = new System.Windows.Forms.DataGridView();
            this.chtStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStockAnalsis
            // 
            this.btnStockAnalsis.Location = new System.Drawing.Point(323, 158);
            this.btnStockAnalsis.Name = "btnStockAnalsis";
            this.btnStockAnalsis.Size = new System.Drawing.Size(123, 23);
            this.btnStockAnalsis.TabIndex = 18;
            this.btnStockAnalsis.Text = "Stock Analysis";
            this.btnStockAnalsis.UseVisualStyleBackColor = true;
            this.btnStockAnalsis.Visible = false;
            this.btnStockAnalsis.Click += new System.EventHandler(this.btnStockAnalsis_Click);
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Location = new System.Drawing.Point(241, 30);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(62, 13);
            this.lblStockType.TabIndex = 17;
            this.lblStockType.Text = "Department";
            // 
            // cboStockType
            // 
            this.cboStockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStockType.FormattingEnabled = true;
            this.cboStockType.Items.AddRange(new object[] {
            "EL - Electrical",
            "PL - Plumbing",
            "HW - Hardware ",
            "HO - Household",
            "TL - Tools"});
            this.cboStockType.Location = new System.Drawing.Point(323, 27);
            this.cboStockType.Name = "cboStockType";
            this.cboStockType.Size = new System.Drawing.Size(121, 21);
            this.cboStockType.TabIndex = 16;
            this.cboStockType.SelectedIndexChanged += new System.EventHandler(this.cboStockType_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grdStockAnalysis
            // 
            this.grdStockAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStockAnalysis.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdStockAnalysis.Location = new System.Drawing.Point(12, 187);
            this.grdStockAnalysis.Name = "grdStockAnalysis";
            this.grdStockAnalysis.Size = new System.Drawing.Size(564, 240);
            this.grdStockAnalysis.TabIndex = 47;
            this.grdStockAnalysis.Visible = false;
            // 
            // chtStock
            // 
            chartArea1.Name = "ChartArea1";
            this.chtStock.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtStock.Legends.Add(legend1);
            this.chtStock.Location = new System.Drawing.Point(582, 187);
            this.chtStock.Name = "chtStock";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtStock.Series.Add(series1);
            this.chtStock.Size = new System.Drawing.Size(622, 366);
            this.chtStock.TabIndex = 48;
            this.chtStock.Text = "StockAnalysis";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(241, 69);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 50;
            this.lblYear.Text = "Year";
            // 
            // cboYear
            // 
            this.cboYear.DisplayMember = "1";
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "18",
            "17",
            "16",
            "15",
            "14"});
            this.cboYear.Location = new System.Drawing.Point(323, 66);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 49;
            // 
            // frmAnalysisStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 759);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.chtStock);
            this.Controls.Add(this.grdStockAnalysis);
            this.Controls.Add(this.btnStockAnalsis);
            this.Controls.Add(this.lblStockType);
            this.Controls.Add(this.cboStockType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnalysisStock";
            this.Text = "Analyse Stock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStockAnalsis;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.ComboBox cboStockType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdStockAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtStock;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
    }
}