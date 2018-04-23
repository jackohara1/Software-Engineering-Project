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

              //  fillChart(ds);
                chtStock.Visible = true;

            }

        }

    
    private void defineChart(int x, int y)
    {
        //define chart

        

        chtStock.Size = new Size(x, y);
        chtStock.ChartAreas[0].Name = "mainArea";
        chtStock.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
        chtStock.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

        chtStock.ChartAreas["mainArea"].AxisY.Minimum = 0;
        chtStock.ChartAreas["mainArea"].AxisY.Interval = 500;
        chtStock.ChartAreas["mainArea"].AxisY.Title = "Amount Sold";

        chtStock.ChartAreas["mainArea"].AxisX.Interval = 1;
        chtStock.ChartAreas["mainArea"].AxisX.Title = "Stock";

        chtStock.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
        //chtData.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;

        //chart title   
        chtStock.Titles.Add("Amount of Sales in 20"/*+cboStockType.ValueMember*/);
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
        //fill chart
        chtStock.Series["Revenue"].Points.Clear();

        //load values returned from query into 12 element array
        //decimal[] monthlyRev = { 0, 1200, 800, 1000, 1500, 1700, 2500, 2200, 1500, 1000, 500, 0 };

        //add values in array to chart series
        //for (int i = 0; i < 12; i++)
        //chtData.Series["Revenue"].Points.AddXY(monthName(i + 1), monthlyRev[i]);

        //get data from database
        

        //add values in array to chart series
        int j = 0;
        for (int i = 1; i <= 12; i++)
        {
            if (i < Convert.ToDecimal(ds.Tables[0].Rows[j][0]))
                chtStock.Series["Revenue"].Points.AddXY(Convert.ToString(grdStockAnalysis.Rows[i].Cells[1].Value), 0);
            else
            {

                chtStock.Series["Revenue"].Points.AddXY(Convert.ToString(grdStockAnalysis.Rows[i].Cells[1].Value), Convert.ToDecimal(grdStockAnalysis.Rows[i].Cells[4].Value));
                j++;
            }
        }


    }
    

        
    } }
 
