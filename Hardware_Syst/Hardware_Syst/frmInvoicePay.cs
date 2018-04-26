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
    public partial class frmInvoicePay : Form
    {
        frmMainMenu parent;
        public frmInvoicePay(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

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
                
                grdCustomerSearch.DataSource = Customer.getMatchingSurname(ds, txtCustomer.Text.ToUpper()).Tables["ss"];
                grdCustomerSearch.AllowUserToAddRows = false;


                if (grdCustomerSearch.RowCount == 0)
                {
                    grpPayInvoice.Visible = false;
                    MessageBox.Show(Convert.ToString(txtCustomer.Text) + " does not exist in the system please try another surname");
                    txtCustomer.Text = "";
                }
                else
                {
                    grpPayInvoice.Visible = true;
                }
            }
        }

    
     
        
           
private void btnPayInvoice_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < grdIssue.RowCount - 1)
            {
                Sale.invoicePayed(Convert.ToInt32(grdIssue.Rows[i].Cells[0].Value));

                i++;
            }

            MessageBox.Show("You have payed your invoice");
            this.Close();
            parent.Show();
        }

        private void grdCustomerSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpPayInvoice.Visible = true;
            DataSet ds = new DataSet();
            txtTotal.Text = "0.00";
            grdIssue.DataSource = Saleitem.getMatchingInvoice(ds, Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value)).Tables["ss"];
            grdIssue.AllowUserToAddRows = false;

            Customer Invoice = new Customer();
            Invoice.getCustomer(Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value));

            int i = 0;
            while (i < grdIssue.RowCount)
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(grdIssue.Rows[i].Cells[5].Value));

                i++;
            }

        }
    }
  
}
