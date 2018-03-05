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
                grdSaleAnalysis.Visible = true;
                grdSaleAnalysis.Rows.Add("0045", "01/12/17", "10.00");
                grdSaleAnalysis.Rows.Add("0046", "01/12/17", "96.00");
                grdSaleAnalysis.Rows.Add("0047", "02/12/17", "70.00");
                grdSaleAnalysis.Rows.Add("0048", "04/12/17", "120.00");
                grdSaleAnalysis.Rows.Add("0049", "05/12/17", "1.00");
                btnSaleAnalsis.Visible = false;
            }
        }
    }
}
