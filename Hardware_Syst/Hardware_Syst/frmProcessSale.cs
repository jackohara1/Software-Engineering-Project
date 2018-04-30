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
    public partial class frmProcessSale : Form
    {
        frmMainMenu parent;
      
        public frmProcessSale(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            grdCart.AllowUserToAddRows = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtStockID6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProcessSale_Load(object sender, EventArgs e)
        {
            txtSaleID.Text = Sale.getNextSale_id().ToString("0000");
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void cboPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnRegesterSale_Click(object sender, EventArgs e)
        {
            Sale mySale = new Sale();
            mySale.setSale_id(Convert.ToInt32(txtSaleID.Text));
            if (rdoCredit.Checked)
            {
                mySale.setCustomer_id(Convert.ToInt32(grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[0].Value));
                mySale.setStatus("U");
            }
            else
            {
                mySale.setStatus(Convert.ToString('P'));
                mySale.setCustomer_id(0);
            }

            mySale.setSaleDate(String.Format("{0:dd-MMM-yy}", DateTime.Now));
            
            mySale.setSaleValue(Convert.ToDecimal(txtSaleValue.Text));

            mySale.addSale();

           

            int i = 0;
            grdCart.Rows[i].Selected = true;
            while(i< grdCart.RowCount)
            {
                Saleitem newSaleItem = new Saleitem();
                newSaleItem.setSale_id(Convert.ToInt32(txtSaleID.Text));
                newSaleItem.setStock_id( Convert.ToInt32(grdCart.Rows[i].Cells[0].Value));
                newSaleItem.setQtysold(Convert.ToInt32(grdCart.Rows[i].Cells[2].Value));
                newSaleItem.setPrice(Convert.ToDecimal(grdCart.Rows[i].Cells[6].Value));

                newSaleItem.addSaleitem();
             
                Stock.replaceStock(Convert.ToInt32(grdCart.Rows[i].Cells[0].Value), Convert.ToInt32(grdCart.Rows[i].Cells[2].Value));
                i++;
            }
            
        


           
            MessageBox.Show("Sale has been registered");
            this.Close();
            parent.Show();
        }

        private void btnSrh_Click(object sender, EventArgs e)
        {
            Regex alphanumericCheck = new Regex("^[a-zA-Z][a-zA-Z0-9]*$");


            if (txtSrh.Text.Equals(""))
            {
                MessageBox.Show("Stock Name was left blank");
                txtSrh.Focus();
                return;
            }

           else if (!alphanumericCheck.IsMatch(txtSrh.Text))
            {
                MessageBox.Show("Stock Name must use alphanumeric characters");
                txtSrh.Clear();
                txtSrh.Focus();
                return;
            }


            else
            {
                DataSet ds = new DataSet();              
                grdStock.DataSource = Stock.getMatchingSaleStock(ds, txtSrh.Text).Tables["ss"];
                grdStock.AllowUserToAddRows = false;

                if (grdStock.RowCount <= 0)
                {
                    grpStock.Visible = false;
                    MessageBox.Show(Convert.ToString(txtSrh.Text) + " does not exist in the system please try another item of stock");
                    txtSrh.Text = "";
                }
                else
                {
                    grpStock.Visible = true;
                }
            }

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (grdCart.RowCount <= 0)
            {
                MessageBox.Show("Please add an item to the shopping cart if you wish to continue");
            }
            else
            {
                grpPay.Visible = true;
                btnRegesterSale.Visible = true;
            }
        }

        private void rdoCredit_CheckedChanged(object sender, EventArgs e)
        {
            grpCredit.Visible = true;
            
            btnRegesterSale.Visible = false;
        }

        private void grdStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpCart.Visible = true;
            Boolean isAdded = false;
            for(int x= 0; x<grdCart.RowCount; x++)
            {
                if(Convert.ToInt16(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value)== Convert.ToInt16(grdCart.Rows[x].Cells[0].Value))
                {
                    grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value = ((Convert.ToInt16(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) + 1).ToString());
                    txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value) + Convert.ToDecimal(txtSaleValue.Text));
                    isAdded = true;

                }
            }
            if (isAdded == false)
            {
                grdCart.Rows.Add(Convert.ToString(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value), Convert.ToString(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[1].Value), Convert.ToString(1), "+", "-", "remove", Convert.ToString(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[2].Value));
                txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[2].Value) + Convert.ToDecimal(txtSaleValue.Text));
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnRegesterSale.Visible = false;
            Regex alphabetic = new Regex("^[a-zA-Z]+$");

            if (txtCustomer.Text.Equals(""))
            {
                MessageBox.Show("Surname was left blank");
                txtCustomer.Focus();
                return;
            }
            else if (!alphabetic.IsMatch(txtCustomer.Text))
            {
                MessageBox.Show("Surname must contain letters only");
                txtCustomer.Focus();
                txtCustomer.Clear();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                grdCust.DataSource = Customer.getMatchingSurname(ds, txtCustomer.Text.ToUpper()).Tables["ss"];
                grdCust.AllowUserToAddRows = false;
                if (grdCust.RowCount == 0)
                {
                    grpCredit.Visible = false;
                    MessageBox.Show(Convert.ToString(txtCustomer.Text) + " does not exist in the system please try another Surname");
                    txtCustomer.Text = "";
                }
                else
                {
                    grpCredit.Visible = true;
                    grdCart.Visible = true;
                }
            }
        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            btnRegesterSale.Visible = true;
            grpCredit.Visible = false;
        }

      

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            btnRegesterSale.Visible = true;
        }

      

        private void grdCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == grdCart.Columns["Quantityadd"].Index && e.RowIndex >= 0)
            {
             
                grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value = ((Convert.ToInt16(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) + 1).ToString());
                txtSaleValue.Text =Convert.ToString(Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value) + Convert.ToDecimal(txtSaleValue.Text));

            }
            else if (e.ColumnIndex == grdCart.Columns["Quantityminus"].Index && e.RowIndex >= 0)
            {
               if (Convert.ToInt16(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) == 1)
                {
                    txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(txtSaleValue.Text) - (Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value) * Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value)));
                    grdCart.Rows.Remove(grdCart.Rows[grdCart.CurrentCell.RowIndex]);
                    if (grdCart.Rows.Count == 0)
                    {
                        grpCart.Visible = false;
                    }
                }

                else
                {
                    grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value = ((Convert.ToInt16(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) - 1).ToString());
                    txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(txtSaleValue.Text)-  Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value));
                }

            }
            else if (e.ColumnIndex == grdCart.Columns["remove"].Index && e.RowIndex >= 0)
            {
                 txtSaleValue.Text = Convert.ToString(Convert.ToDecimal( txtSaleValue.Text) - (Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value) * Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value)));
                 grdCart.Rows.Remove(grdCart.Rows[grdCart.CurrentCell.RowIndex]);
               if (grdCart.Rows.Count == 0)
                {
                    grpCart.Visible = false;
                }
            }
        }

        private void grdCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    
            btnRegesterSale.Visible = true;
        }
    }
}
