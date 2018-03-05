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
          
            else
            {
                DataSet ds = new DataSet();
                grpSearch.Visible = true;
                grdStockSearch.DataSource= Stock.getSelectedStock(ds,txtStockName.Text).Tables["ss"];


            } 
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            grpUpdate.Visible = true;
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
            { MessageBox.Show("Stock got updated");
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
    }
}
