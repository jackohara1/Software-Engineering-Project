using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hardware_Syst
{
   
    public partial class frmAnalysisSales : Form
    {

        frmMainMenu parent;
        public frmAnalysisSales(frmMainMenu Parent) 
        {
            InitializeComponent();
            parent = Parent;
            cboYear.SelectedIndex = (0);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void cboStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaleAnalsis.Visible = true;
        }


        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Regex alphabetic = new Regex("^[a-zA-Z ]+$");

            if (txtCustomer.Text.Equals(""))
            {
                MessageBox.Show("Surname was left blank");
                txtCustomer.Focus();
                return;
            }
       
           else if (!alphabetic.IsMatch(txtCustomer.Text))
            {
                MessageBox.Show("Surname must contain letters only");
                txtCustomer.Focus();
                txtCustomer.Clear();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
             
                grdCust.DataSource = Customer.getMatchingSurname(ds, txtCustomer.Text.ToUpper()).Tables["ss"];
                grdCust.AllowUserToAddRows = false;


                if (grdCust.RowCount == 0)
                {
                    btnSaleAnalsis.Visible = false;
                    grdCust.Visible = false;
                    MessageBox.Show(Convert.ToString(txtCustomer.Text) + " does not exist in the system please try another surname");
                    txtCustomer.Text = "";
                }
                else
                {
                    grdCust.Visible = true;
                }
            }
        }

        private void btnSaleAnalsis_Click(object sender, EventArgs e)
        {
            
            chtData.Series.Clear();
            if (cboYear.Text.Equals(""))
            {
                MessageBox.Show("Department was left blank");
                cboYear.Focus();
                chtData.Visible = false;
                return;
            }
            else
            {
            
                DataSet ds = new DataSet();
                if (rdoCust.Checked){
                    grdSaleAnalysis.DataSource = Sale.getSaleAnalysisCust(ds, cboYear.Text, Convert.ToInt32(grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[0].Value)).Tables["ss"];
                }
                else
                {
                    grdSaleAnalysis.DataSource = Sale.getSaleAnalysis(ds, cboYear.Text).Tables["ss"];

                }            grdSaleAnalysis.AllowUserToAddRows = false;
                if (grdSaleAnalysis.RowCount <= 0 )
                    {
                       if (rdoCust.Checked)
                         {
                              MessageBox.Show(Convert.ToString(grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[2].Value) + " " + Convert.ToString(grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[1].Value) + "made no purchases in the year 20" + cboYear.Text);
                             }
                        else
                             {
                               MessageBox.Show("There was no sales made in the year 20" + cboYear.Text);
                              }
                        grdSaleAnalysis.Visible = false;
                        chtData.Visible = false;
            
                          }
      
                else
                {
                grdSaleAnalysis.Visible = true;


                //define chart
                defineChart();

                //Define the chart series
                defineSeries();


                //fill Chart
                fillChart(ds);

                    chtData.Visible = true;

                }
            } 
        }

        private void rdoCust_CheckedChanged(object sender, EventArgs e)
        {
            grpCredit.Visible = true;
            btnSaleAnalsis.Visible = false;
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            grpCredit.Visible = false;
            btnSaleAnalsis.Visible = true;
        }

        private void grdCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaleAnalsis.Visible = true;
        }

        private void defineChart()
        {
            //define chart
            chtData.Size = new Size(750, 300);
            chtData.ChartAreas[0].Name = "mainArea";
            chtData.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtData.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtData.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtData.ChartAreas["mainArea"].AxisY.Interval = 250;
            chtData.ChartAreas["mainArea"].AxisY.Title = "Euros";

            chtData.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtData.ChartAreas["mainArea"].AxisX.Title = "Month";

            chtData.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            //chtData.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;

            chtData.Titles.Clear();
            chtData.Titles.Add("Monthly Revenue 2017");
        }

        private void defineSeries()
        {
            chtData.Series.Clear();
            chtData.Series.Add("Revenue");

            chtData.Series["Revenue"].ChartType = SeriesChartType.Column;
            chtData.Series["Revenue"].XValueType = ChartValueType.String;
        }

        private void fillChart(DataSet ds)
        {

            chtData.Series["Revenue"].Points.Clear();
            int j = 0;
            for (int i = 1; i <= 12; i++)
            {

                if (rdoAll.Checked) {
                    chtData.Series["Revenue"].Points.AddXY(monthName(i), Sale.getSaleAnalysisChart(ds, Convert.ToString(monthName(i) + "-" + cboYear.Text)));
                    j++; }
                else
                {
                    chtData.Series["Revenue"].Points.AddXY(monthName(i), Sale.getSaleCustomerChart(ds, Convert.ToString(monthName(i) + "-" + cboYear.Text),Convert.ToInt32(grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[0].Value)));
                }
            }
        }

        private string monthName(int MonthNo)
        {
            String strMonth = "";

            switch (MonthNo)
            {
                case 1:
                    strMonth = "JAN";
                    break;
                case 2:
                    strMonth = "FEB";
                    break;
                case 3:
                    strMonth = "MAR";
                    break;
                case 4:
                    strMonth = "APR";
                    break;
                case 5:
                    strMonth = "MAY";
                    break;
                case 6:
                    strMonth = "JUN";
                    break;
                case 7:
                    strMonth = "JUL";
                    break;
                case 8:
                    strMonth = "AUG";
                    break;
                case 9:
                    strMonth = "SEP";
                    break;
                case 10:
                    strMonth = "OCT";
                    break;
                case 11:
                    strMonth = "NOV";
                    break;
                case 12:
                    strMonth = "DEC";
                    break;
            }

            return strMonth;
        }

   
    }


}
