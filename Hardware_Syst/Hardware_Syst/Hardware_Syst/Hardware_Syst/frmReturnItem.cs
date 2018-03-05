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

        private void cboHowCustomerPayed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHowCustomerPayed.Text.Equals("Credit"))
            {
                grpCredit.Visible = true;
                btnReturnItem.Visible = false;
            }
            else
            {
                grpCredit.Visible = false;
            }
            if (cboHowCustomerPayed.Text.Equals("Cash")|| cboHowCustomerPayed.Text.Equals("Replace"))
            {
                btnReturnItem.Visible = true;
            }
        }

        private void lblHowCustomerPayed_Click(object sender, EventArgs e)
        {

        }

        private void frmReturnItem_Load(object sender, EventArgs e)
        {

        }

        private void btnSrh_Click(object sender, EventArgs e)
        {
            if (txtSaleID.Text.Equals(""))
            {
                MessageBox.Show("Sale ID was left blank");
                txtSaleID.Focus();
                return;
            }
            else if (!txtSaleID.Text.Equals("111"))
            {
                MessageBox.Show("This Sale has not taken place on this system");
                txtSaleID.Focus();
                return;
            }
            else
            {
                grpStock.Visible = true;
                grdStock.Rows.Add("088", "Hammer", "20.00", "3");
                grdStock.Rows.Add("076", "Screwdriver", "5.00", "2");
            }
            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text.Equals(""))
            {
                MessageBox.Show("Customer was left blank");
                txtCustomer.Focus();
                return;
            }
            if (!txtCustomer.Text.Equals("O'Hara"))
            {
                MessageBox.Show("Surname entered does no exist in the system");
                txtCustomer.Focus();
                return;
            }
            else
            {
                grdCust.Visible = true;
                grdCust.Rows.Add("055", "OHara", "John");
                btnAddCustomer.Visible = true;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            btnReturnItem.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtQtySold.Text);
            if (txtQtySold.Text.Equals(""))
            {
                MessageBox.Show("Amount of items was left blank");
                txtQtySold.Focus();
                return;
            }
            else if (qty > 3)
            {
                MessageBox.Show("Amount of items entered is greater than the amount of items sold");
                txtQtySold.Focus();
                return;
            }
            else
            {
                lblItemBack.Visible = true;
                lblHowCustomerPayed.Visible = true;
                cboHowCustomerPayed.Visible = true;
                cboWillStockReturn.Visible = true;
                cboWillStockReturn.SelectedIndex = 0;
            }
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Item Has Been Returned");
            this.Close();
            parent.Show();
        }
    }
}
