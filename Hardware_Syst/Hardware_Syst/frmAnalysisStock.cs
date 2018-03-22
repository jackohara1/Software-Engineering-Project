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
                
                DataSet ds = new DataSet();
                grdStockAnalysis.DataSource = Stock.getStockAnalysis(ds, Convert.ToInt32(cboStockType.SelectedIndex+1)).Tables["ss"];
              
                grdStockAnalysis.Visible = true;

            }
        }
    }
}
