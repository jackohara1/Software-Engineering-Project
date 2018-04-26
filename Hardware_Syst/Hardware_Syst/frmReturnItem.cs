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
    public partial class frmReturnItem : Form
    {
        frmMainMenu parent;
        public frmReturnItem(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void lblStockID_Click(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }



        private void lblHowCustomerPayed_Click(object sender, EventArgs e)
        {

        }

        private void frmReturnItem_Load(object sender, EventArgs e)
        {

        }

        private void btnSrh_Click(object sender, EventArgs e)
        {
            Regex numeric = new Regex("^[0-9]*$");


            if (txtSaleID.Text.Equals(""))
            {
                MessageBox.Show("Sale ID was left blank");
                txtSaleID.Focus();
                return;
            }

           else if (!numeric.IsMatch(txtSaleID.Text))
            {
                MessageBox.Show("Sale ID must use numeric characters");
                txtSaleID.Clear();
                txtSaleID.Focus();
                return;
            }

            else
            {
               
                DataSet ds = new DataSet();
                grdCart.DataSource = Saleitem.getMatchingSaleItem(ds, Convert.ToInt32(txtSaleID.Text)).Tables["ss"];
                grdCart.AllowUserToAddRows = false;
                if (grdCart.RowCount == 0)
                {
                    grpStock.Visible = false;
                    MessageBox.Show(Convert.ToString(txtSaleID.Text) + " : This Sale id did not take place on this system");
                    txtSaleID.Text = "";
                }
                
                else
                {
                    int sum = 0;

                   for(int i=0; i < grdCart.RowCount; i++)
                    {
                        sum += Convert.ToInt32(grdCart.Rows[i].Cells[2].Value);
                    }

                   if (sum <= 0)
                    {
                        grpStock.Visible = false;
                        MessageBox.Show(Convert.ToString(txtSaleID.Text) + " : This Sale id already has all items returned");
                        txtSaleID.Text = "";
                    }
                    else
                    {
                        grpStock.Visible = true;
                        txtSaleID.ReadOnly = true;
                    }

                   
                }
            }

        }







        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            Regex numeric = new Regex("^[0-9]*$");


            if (txtQtySold.Text.Equals(""))
            {
                MessageBox.Show("Quantity Sold was left blank");
                txtQtySold.Focus();
                return;
            }

           else if (!numeric.IsMatch(txtQtySold.Text))
            {
                MessageBox.Show("Quantity Sold must use numeric characters");
                txtQtySold.Clear();
                txtQtySold.Focus();
                return;
            }

            else if (Convert.ToInt16(txtQtySold.Text) > Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value))
            {
                MessageBox.Show("The quantity you are returning is greater than the quantity you have bought");
            }

          

            else
            {
                grdCart.Rows[0].Selected = true;
                Saleitem.returnStock(Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[0].Value), Convert.ToInt16(txtQtySold.Text),Convert.ToInt16(txtSaleID.Text));
                Sale.returnSale(Convert.ToInt32(txtSaleID.Text), Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) * Convert.ToInt16(txtQtySold.Text));

                 if (rdoTrue.Checked)
                 {
                  
                    Stock.returnStock(Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[0].Value), Convert.ToInt32(txtQtySold.Text));
                   }

                MessageBox.Show("Item has been returned");



                this.Close();
                parent.Show();
            }
        }



        private void grdCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
   
            
                lblAmountOfItems.Visible = true;


            txtQtySold.Text = Convert.ToString(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value);
            txtQtySold.Visible = true; 
            lblItemBack.Visible = true;
            rdoFalse.Visible = true;
            rdoTrue.Visible = true;

            btnReturnItem.Visible = true;




        }

       
    }
}