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
            if (!txtCustomer.Text.Equals("O'Hara"))
            {
                MessageBox.Show("Surname entered does no exist in the system");
                txtCustomer.Focus();
                return;
            }
            
            else{
                grpSearch.Visible = true;
                grdCustomerSearch.Rows.Add("055", "O'Hara", "John");
                 }
        }

        private void btnPayInvoice_Click(object sender, EventArgs e)
        {
            grpIssueInvoice.Visible = true;
            grdIssue.Rows.Add("111", "088", "Hammer", "20.00", "3","60.00");
            grdIssue.Rows.Add("111", "076", "Screwdriver", "5.00", "2","10.00");
            txtAddln1.Text = "Dirtane";
            txtAddln2.Text = "Ballyheigue";
            txtAddln3.Text = "Co.Kerry";
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
