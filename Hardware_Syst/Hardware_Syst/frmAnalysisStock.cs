using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hardware_Syst
{
    public partial class frmAnalysisStock : Form
    {
        frmMainMenu parent;
        public frmAnalysisStock(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            cboYear.SelectedIndex = (0);
            cboStockType.SelectedIndex = (0);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void cboStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStockAnalsis.Visible = true;
        }

        private void btnStockAnalsis_Click(object sender, EventArgs e)
        {
            if (cboStockType.Text.Equals(""))
            {
                MessageBox.Show("Department was left blank");
                cboStockType.Focus();
                return;
            }
            else
            {

                DataSet ds = new DataSet();
                grdStockAnalysis.DataSource = Stock.getStockAnalysis(ds, Convert.ToInt32(cboStockType.SelectedIndex + 1)).Tables["ss"];
                grdStockAnalysis.AllowUserToAddRows = false;
                grdStockAnalysis.Visible = true;

                var MaxSold = Convert.ToInt32(grdStockAnalysis.Rows[0].Cells[4].Value);



              
                defineChart(grdStockAnalysis.Rows.Count, MaxSold);


                defineSeries();

                fillChart(ds);
                chtStock.Visible = true;
                chtStock.Show();
            }

        }


        private void defineChart(int x, int y)
        {
            //define chart



            chtStock.Size = new Size(500, 500);
            chtStock.ChartAreas[0].Name = "mainArea";
            chtStock.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtStock.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtStock.ChartAreas["mainArea"].AxisY.Minimum =0;
            chtStock.ChartAreas["mainArea"].AxisY.Interval = y;
            chtStock.ChartAreas["mainArea"].AxisY.Title = "Amount Sold";

            chtStock.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtStock.ChartAreas["mainArea"].AxisX.Title = "Stock";

            chtStock.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            chtStock.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;

            //chart title   
            chtStock.Titles.Add("Amount of Sales in 20"+Convert.ToString(cboStockType.ValueMember));
        }

        private void defineSeries()
        {
            chtStock.Series.Clear();
            chtStock.Series.Add("Revenue");

            chtStock.Series["Revenue"].ChartType = SeriesChartType.Column;
            chtStock.Series["Revenue"].XValueType = ChartValueType.String;
        }

        private void fillChart(DataSet ds)
        {

          //  chtStock.Series["Revenue"].Points.Clear();



          
            int j = 0;

            //For each summary row in ds
            while (j <= ds.Tables["ss"].Rows.Count-1)
            {
       
                if (ds.Tables[0].Rows[j][4] == null)
                {
                    chtStock.Series["Revenue"].Points.AddXY(ds.Tables[0].Rows[j][1], 0);
                }
                else 
                {
                    chtStock.Series["Revenue"].Points.AddXY(ds.Tables[0].Rows[j][1], ds.Tables[0].Rows[j][4]);
                   
                }
             
                j++;

            }
        }
    }
}
 
