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
    public partial class frmAnalysisStock : Form
    {
        frmMainMenu parent;
        public frmAnalysisStock(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
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
                grdStockAnalysis.Visible = true;
                grdStockAnalysis.Rows.Add("0088", "Hammer", "30", "5.00", "10.00", "20", "200.00");
                grdStockAnalysis.Rows.Add("0089", "screwdriver", "20", "4.00", "12.00", "2", "24.00");
                grdStockAnalysis.Rows.Add("0090", "half inch 310", "100", "2.00", "4.00", "15", "60.00");
                grdStockAnalysis.Rows.Add("0091", "half inch 311", "100", "3.00", "6.00", "25", "150.00");
                grdStockAnalysis.Rows.Add("0092", "three quater inch 312", "100", "5.00", "15.00", "6", "90.00");
                btnStockAnalsis.Visible = false;
            }
        }
    }
}
