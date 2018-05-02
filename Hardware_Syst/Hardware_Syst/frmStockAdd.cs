using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            txtStockName.Focus();
            DataSet ds = new DataSet();
            ds = Department.getDepartment(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++) { 
                cboStockType.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
        }
        }
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnNewStock_Click(object sender, EventArgs e)
        {
            Regex numeric = new Regex("^[0-9]*$");
            Regex decimalCheck = new Regex("^[0-9]([.,][0-9]{1,3})?$");
            Regex alphanumericCheck = new Regex("^[a-zA-Z][a-zA-Z0-9 ]*$");

            if (cboStockType.Text.Equals(""))
            {
                MessageBox.Show("Department was left blank");
                cboStockType.Focus();
                return;
            }
            
           else if (txtStockName.Text.Equals(""))
            {
                MessageBox.Show("Stock Name was left blank");
                txtStockName.Focus();
                return;
            }

           else if (!alphanumericCheck.IsMatch(txtStockName.Text))
            {
                MessageBox.Show("Stock Name must use alphanumeric characters");
                txtStockName.Clear();
                txtStockName.Focus();
                return;
            }

            if (txtQty.Text.Equals(""))
            {
                MessageBox.Show("Quantity was left blank");
                txtQty.Focus();
                return;
            }
           else if (!numeric.IsMatch(txtQty.Text))
            {
                MessageBox.Show("Quantity must be a numeric value");
                txtQty.Clear();
                txtQty.Focus();
                return;
            }
           else if (txtCostPrice.Text.Equals(""))
            {
                MessageBox.Show("Cost Price was left blank");
                txtCostPrice.Focus();
                return;
            }
           else if (!decimalCheck.IsMatch(txtCostPrice.Text)&& !numeric.IsMatch(txtCostPrice.Text))
            {
                MessageBox.Show("Cost Price must be numeric");
                txtCostPrice.Clear();
                txtCostPrice.Focus();
                return;
            }

           else if (txtSalePrice.Text.Equals(""))
            {
                MessageBox.Show("Sale Price was left blank");
                txtSalePrice.Focus();
                return;
            }
           else if (!decimalCheck.IsMatch(txtSalePrice.Text) && !numeric.IsMatch(txtSalePrice.Text))
            {
                MessageBox.Show("Sale Price must be numeric");
                txtSalePrice.Clear();
                txtSalePrice.Focus();
                return;
            }
            else if (Convert.ToDecimal(txtSalePrice.Text) < Convert.ToDecimal(txtCostPrice.Text))
            {
                MessageBox.Show("Sale Price must be greater than Cost Price");
                txtSalePrice.Clear();
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
                myStock.setDepartment_id(cboStockType.SelectedIndex+1);
                myStock.setStatus("A");


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
