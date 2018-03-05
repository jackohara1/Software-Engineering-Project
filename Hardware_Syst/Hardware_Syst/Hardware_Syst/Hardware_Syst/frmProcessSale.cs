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
    public partial class frmProcessSale : Form
    {
        frmMainMenu parent;
      
        public frmProcessSale(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtStockID6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProcessSale_Load(object sender, EventArgs e)
        {

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
            MessageBox.Show("Sale has been registered");
            this.Close();
            parent.Show();
        }

        private void btnSrh_Click(object sender, EventArgs e)
        {
            if (txtSrh.Text.Equals(""))
            {
                MessageBox.Show("Stock Name was left blank");
                txtSrh.Focus();
                return;
            }
            else if (!txtSrh.Text.Equals("Hammer"))
            {
                MessageBox.Show("This Stock name does not exist in the system");
                txtSrh.Focus();
                return;
            }
            else
            {
                grdStock.Rows.Add("0088", "Hammer", "10.00", "025");
                grpStock.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQtySold.Text.Equals(""))
            {
                MessageBox.Show("Amount of Items was left blank");
                txtQtySold.Focus();
                return;
            }
            else
            {
                grpCart.Visible = true;
                lstCart.Items.Add("Hammer   10.00");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            grpPay.Visible = true;
        }

        private void rdoCredit_CheckedChanged(object sender, EventArgs e)
        {
            grpCredit.Visible = true;
            
            btnRegesterSale.Visible = false;
        }

        private void grdStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                grdCust.Rows.Add("015", "O'Hara", "John");
                btnAddCustomer.Visible = true;
            }
        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            btnRegesterSale.Visible = true;
            grpCredit.Visible = false;
        }

        private void grdCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            btnRegesterSale.Visible = true;
        }
    }
}
