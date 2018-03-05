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
    public partial class frmStockDiscontinue : Form
    {
        frmMainMenu parent;
        public frmStockDiscontinue(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtStockName.Text.Equals(""))
            {
                MessageBox.Show("Stock Name was left blank");
                txtStockName.Focus();
                return;
            }
          
            else
            {
                DataSet ds = new DataSet();
                grpSearch.Visible = true;
                grdStockSearch.DataSource = Stock.getAvalableStock(ds, txtStockName.Text).Tables["ss"];
            }
        }

        

        private void frmStockDiscontinue_Load(object sender, EventArgs e)
        {

        }

        private void grdStockSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get stock ID from col 0 of grid            
            Stock.discontinueStock(Convert.ToInt32(grdStockSearch.Rows[grdStockSearch.CurrentCell.RowIndex].Cells[0].Value));
            MessageBox.Show("This Stock has been discontinued");
            this.Close();
            parent.Show();
        }
        


            private void grdStockSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
