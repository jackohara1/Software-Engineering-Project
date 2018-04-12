using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Syst
{
   
    public partial class frmAnalysisSales : Form
    {

        frmMainMenu parent;
        public frmAnalysisSales(frmMainMenu Parent) 
        {
            InitializeComponent();
            parent = Parent;
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

        private void grdStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text.Equals(""))
            {
                MessageBox.Show("Surname was left blank");
                txtCustomer.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                grdCust.Visible = true;
                grdCust.DataSource = Customer.getMatchingSurname(ds, txtCustomer.Text.ToUpper()).Tables["ss"];
            }
        }

        private void btnSaleAnalsis_Click(object sender, EventArgs e)
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
                grdSaleAnalysis.DataSource = Sale.getSaleAnalysis(ds, cboStockType.Text, Convert.ToInt32(grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[0].Value)).Tables["ss"];
                grdSaleAnalysis.Visible = true;
            } 
        }

       
    }
}
