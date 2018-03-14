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
            }
        }

        private void btnPayInvoice_Click(object sender, EventArgs e)
        {
           
            grdIssue.Rows.Add("111", "088", "Hammer", "20.00", "3","60.00");
            grdIssue.Rows.Add("111", "076", "Screwdriver", "5.00", "2","10.00");
            txtAddln1.Text = "Dirtane";
            txtAddln2.Text = "Ballyheigue";
            txtAddln3.Text = "Co.Kerry";
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdCustomerSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grpIssueInvoice.Visible = true;
            DataSet ds = new DataSet();
            grdIssue.DataSource = Saleitem.getMatchingInvoice(ds, Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value)).Tables["ss"];

            Customer Invoice = new Customer();
            Invoice.getCustomer(Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value));

            txtAddln1.Text = Convert.ToString(Invoice.getAddln1());
            txtAddln2.Text = Convert.ToString(Invoice.getAddln2());
            txtAddln3.Text = Convert.ToString(Invoice.getAddln3());
        }
    }
}
