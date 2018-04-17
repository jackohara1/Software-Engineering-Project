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
    public partial class frmInvoiceIssue : Form
    {
        frmMainMenu parent;
        public frmInvoiceIssue(frmMainMenu Parent)
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
            if (txtCustomer.Text.Equals(""))
            {
                MessageBox.Show("Customer was left blank");
                txtCustomer.Focus();
                return;
            }
            
            else{

                DataSet ds = new DataSet();
                grpSearch.Visible = true;
                grdCustomerSearch.DataSource = Customer.getMatchingSurname(ds, txtCustomer.Text.ToUpper()).Tables["ss"];
                grdCustomerSearch.AllowUserToAddRows = false;
            }
        }

      

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdCustomerSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpIssueInvoice.Visible = true;
            DataSet ds = new DataSet();
            grdIssue.DataSource = Saleitem.getMatchingInvoice(ds, Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value)).Tables["ss"];
            grdIssue.AllowUserToAddRows = false;

            Customer Invoice = new Customer();
            Invoice.getCustomer(Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value));

            txtAddln1.Text = Convert.ToString(Invoice.getAddln1());
            txtAddln2.Text = Convert.ToString(Invoice.getAddln2());
            txtAddln3.Text = Convert.ToString(Invoice.getAddln3());
            int i = 0;
            while (i < grdIssue.RowCount - 1)
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text)+Convert.ToDecimal(grdIssue.Rows[i].Cells[5].Value));
                
                i++;
            }
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtAddln1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddln2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
