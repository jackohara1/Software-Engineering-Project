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
            grdEnquiry.Rows.Clear();
            Stock disStock = new Stock();
         
            disStock.getStock(Convert.ToInt32(grdStockSearch.Rows[grdStockSearch.CurrentCell.RowIndex].Cells[0].Value));
            DataSet db = new DataSet();
            
      


            grdEnquiry.Visible = true;
            grdEnquiry.Rows.Add(Convert.ToInt16(disStock.getStock_id()), Convert.ToString(disStock.getStock_name()), Convert.ToDecimal(disStock.getCost_p()), 
                Convert.ToDecimal(disStock.getSale_p()), Convert.ToInt16(disStock.getQty()), Convert.ToString(Stock.getSelectedDepartment(db,(Convert.ToInt16(disStock.getDepartment_id())))), Convert.ToString(disStock.getStatus()));


        }

     
    }
}
