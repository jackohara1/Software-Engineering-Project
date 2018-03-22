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
    public partial class frmStockEnquiry : Form
    {
        frmMainMenu parent;
        public frmStockEnquiry(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

      

        private void frmStockEnquiry_Load(object sender, EventArgs e)
        {

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
                grdStockSearch.DataSource = Stock.getMatchingStock(ds, txtStockName.Text).Tables["ss"];
            }
           
        }

       

        private void grdStockSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grdEnquiry.Refresh();
          
 
            
      


            grdEnquiry.Visible = true;
            DataSet ds = new DataSet();
            grdEnquiry.DataSource = Stock.getEnquiry(ds, Convert.ToInt16(grdStockSearch.Rows[grdStockSearch.CurrentCell.RowIndex].Cells[0].Value)).Tables["ss"];

        }

     
    }
}
