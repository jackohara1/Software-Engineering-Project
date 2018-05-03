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

        private void frmProcessSale_Load(object sender, EventArgs e)
        {
            txtSaleID.Text = Sale.getNextSale_id().ToString("0000");
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnRegesterSale_Click(object sender, EventArgs e)
        {
            Sale mySale = new Sale();
            mySale.setSale_id(Convert.ToInt32(txtSaleID.Text));
            //checks to see if the user is paying by credit sets the customer id to the selected customer id and the sale status to U(Unpayed)
            if (rdoCredit.Checked)
            {
                mySale.setCustomer_id(Convert.ToInt32(grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[0].Value));
                mySale.setStatus("U");
            }
            //if the user is paying by cash sets the sales customer id to null and sets the sale status to P(Payed)
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
            //goes through each row of the shopping cart adding each item to the databace 
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
                     
            MessageBox.Show("Sale has been registered. Your Sale ID is "+txtSaleID.Text+". Remember this incase you need to return your items.");
            this.Close();
            parent.Show();
        }

        private void btnSrh_Click(object sender, EventArgs e)
        {
            Regex alphanumericCheck = new Regex("^[a-zA-Z][a-zA-Z0-9 ]*$");


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
        //an array of qty is created so that the system will remember the amount of items that exist in the system and the customer cannot purchase more than the system has in stock
            int[] qty = new int[100];
 
        private void grdStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            grpCart.Visible = true;
            Boolean isAdded = false;


            //this for loop checks to see if the item that the user is trying to enter is already in the shopping cart
            for (int x = 0; x < grdCart.RowCount; x++)
            {
                // if it is it changes the boolean is added to true 
                if (Convert.ToInt16(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value) == Convert.ToInt16(grdCart.Rows[x].Cells[0].Value))
                {
                    //this checks to see if the amount of items that is in the system is less than the amount the user is trying to purchase 
                    if (qty[Convert.ToInt32(grdCart.Rows[x].Cells[0].Value)] <= Convert.ToInt32(grdCart.Rows[x].Cells[2].Value))
                    {
                        MessageBox.Show("We are sorry we are all out of " + Convert.ToString(grdCart.Rows[x].Cells[1].Value));
                        isAdded = true;
                    }
                    //if the amount is less the quantity that the user is trying to purchase gets incromented by one 
                    else
                    {
                        grdCart.Rows[x].Cells[2].Value = ((Convert.ToInt16(grdCart.Rows[x].Cells[2].Value) + 1).ToString());
                        txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(grdCart.Rows[x].Cells[6].Value) + Convert.ToDecimal(txtSaleValue.Text));
                        isAdded = true;
     
                        grpCart.Visible = true;
                    }
                }
            }
               //if the item that the user is entering is not already in the shopping cart then a new row gets added to the shopping cart 
                if (isAdded == false)
                {

                        

                                grdCart.Rows.Add(Convert.ToString(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value), Convert.ToString(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[1].Value), Convert.ToString(1), "+", "-", "remove", Convert.ToString(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[2].Value));
                                txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[2].Value) + Convert.ToDecimal(txtSaleValue.Text));
                                grpCart.Visible = true;
                                qty[Convert.ToInt32(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value)] = Convert.ToInt32(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[3].Value);
                              
                               }
                     }
            
        

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnRegesterSale.Visible = false;
            Regex alphabetic = new Regex("^[a-zA-Z ]+$");

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
                //if there are no rows in the data grid box it means that there are no customers with that surname in the system
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

      
        //when a user selects a customer it will set the register sale button the visible 
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            btnRegesterSale.Visible = true;
        } 

        private void grdCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // this checks if the user clicked the add button in the shopping cart 
            if (e.ColumnIndex == grdCart.Columns["Quantityadd"].Index && e.RowIndex >= 0)
            {
                // the system checks to see if the quantity that the user wishes to puchase is greater than the amount that is on the system 
                if (qty[Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[0].Value)] <= Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value))
                {
                    MessageBox.Show("We are sorry we are all out of " + Convert.ToString(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[1].Value));
              
                }
                // if it is not the quantity inside the shopping cart gets incromented by one 
                else
                {
                    grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value = ((Convert.ToInt16(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) + 1).ToString());
                    txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value) + Convert.ToDecimal(txtSaleValue.Text));
                }

            }

            // this checks to see if the minus button is selected in the shopping cart 
            else if (e.ColumnIndex == grdCart.Columns["Quantityminus"].Index && e.RowIndex >= 0)
            {
                //this checks to see if the number in the shoping cart is one before it is decremented
               if (Convert.ToInt16(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) == 1)
                {
                    //if it is then it updates the sale value and removes the row from the datagrid box 
                    txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(txtSaleValue.Text) - (Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value) * Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value)));
                    grdCart.Rows.Remove(grdCart.Rows[grdCart.CurrentCell.RowIndex]);
                    // if it is the last row it will set the shopping cart to invisible 
                    if (grdCart.Rows.Count == 0)
                    {
                        grpCart.Visible = false;
                    }
                }
               // otherwise it will just decrement the quantity in the shopping cart
                else
                {
                    grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value = ((Convert.ToInt16(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) - 1).ToString());
                    txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(txtSaleValue.Text)-  Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value));
                }

            }
            // this checks to see if the user selects the remove button 
            else if (e.ColumnIndex == grdCart.Columns["remove"].Index && e.RowIndex >= 0)
            {
                //this removes the row from the data grid box
                 txtSaleValue.Text = Convert.ToString(Convert.ToDecimal( txtSaleValue.Text) - (Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value) * Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value)));
                 grdCart.Rows.Remove(grdCart.Rows[grdCart.CurrentCell.RowIndex]);
                //if it is the last row it will set it to invisible
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
