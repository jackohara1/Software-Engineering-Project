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
    public partial class frmStockAdd : Form
    {
        frmMainMenu parent;
        public frmStockAdd(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void frmStockAdd_Load(object sender, EventArgs e)
        {
            txtStockID.Text = Stock.getNextStock_id().ToString("0000");
        }
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnNewStock_Click(object sender, EventArgs e)
        {

            if (cboStockType.Text.Equals(""))
            {
                MessageBox.Show("Department was left blank");
                cboStockType.Focus();
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
                myStock.setStock_name(txtStockName.Text);
                myStock.setCost_p(Convert.ToDecimal(txtCostPrice.Text));
                myStock.setSale_p(Convert.ToDecimal(txtSalePrice.Text));
                myStock.setQty(Convert.ToInt32(txtQty.Text));
                myStock.setDepartment_id(cboStockType.SelectedIndex);


                myStock.addStock();

                MessageBox.Show("Stock added to the system", "Add");

                txtCostPrice.Text = "";
                txtStockName.Text = "";
                txtSalePrice.Text = "";
                cboStockType.SelectedIndex = -1;
                txtQty.Text = "";

                txtStockID.Text = Stock.getNextStock_id().ToString("00000");
                txtStockName.Focus();
            }
        }
    }
}
