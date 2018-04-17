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
    public partial class Update_Stock : Form
    {
        frmMainMenu parent;
        public Update_Stock(frmMainMenu Parent)
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
                MessageBox.Show("Stock was left blank");
                txtStockName.Focus();
                return;
            }
    
            DataSet ds = new DataSet();
            grpSearch.Visible = true;
            grdStockSearch.DataSource = Stock.getMatchingStock(ds,txtStockName.Text).Tables["ss"];
            grdStockSearch.AllowUserToAddRows = false;
        }

   

       

        private void btnUpdateStock_Click_1(object sender, EventArgs e)
        {
            if (cboStockType.Text.Equals(""))
            {
                MessageBox.Show("Stock Type was left blank");
                txtStockName.Focus();
                return;
            }

            if (txtStockName.Text.Equals(""))
            {
                MessageBox.Show("Stock Name was left blank");
                txtStockName.Focus();
                return;
            }


            if (txtQty.Text.Equals(""))
            {
                MessageBox.Show("Quantity was left blank");
                txtQty.Focus();
                return;
            }
            if (txtCostPrice.Text.Equals(""))
            {
                MessageBox.Show("Cost Price was left blank");
                txtCostPrice.Focus();
                return;
            }

            if (txtSalePrice.Text.Equals(""))
            {
                MessageBox.Show("Sale Price was left blank");
                txtSalePrice.Focus();
                return;
            }
            else
            {
                Stock myStock = new Stock();
                myStock.setStock_id(Convert.ToInt32(txtStockID.Text));
                myStock.setStock_name(txtStock.Text);
                myStock.setCost_p(Convert.ToDecimal(txtCostPrice.Text));
                myStock.setSale_p(Convert.ToDecimal(txtSalePrice.Text));
                myStock.setQty(Convert.ToInt32(txtQty.Text));
                myStock.setDepartment_id(cboStockType.SelectedIndex+1);
                if (rdoAvalable.Checked)
                {
                    myStock.setStatus("A");
                }
                else
                {
                    myStock.setStatus("U");
                }

                myStock.updateStock();
                MessageBox.Show("Stock got updated");
                this.Close();
                parent.Show();
            }
        }

        private void txtStockName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void lblCostPrice_Click(object sender, EventArgs e)
        {

        }

        private void grdStockSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            
            

            Stock updStock = new Stock();
            updStock.getStock(Convert.ToInt32(grdStockSearch.Rows[grdStockSearch.CurrentCell.RowIndex].Cells[0].Value));

      
            txtStockID.Text = updStock.getStock_id().ToString();
            txtStock.Text = updStock.getStock_name();
            txtCostPrice.Text = updStock.getCost_p().ToString();
            txtSalePrice.Text = updStock.getSale_p().ToString();
            txtQty.Text = updStock.getQty().ToString();
            
            cboStockType.SelectedIndex = updStock.getDepartment_id()-1;
            if (updStock.getStatus().Equals("U") )
            {
                rdoUnavalable.Checked = true;
            }
            else
            {
                rdoAvalable.Checked = true;
            }
            grpUpdate.Visible = true;

           
           
            
        }

        private void Update_Stock_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Department.getDepartment(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
            {
                cboStockType.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
            }
        }

        private void txtStockID_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
