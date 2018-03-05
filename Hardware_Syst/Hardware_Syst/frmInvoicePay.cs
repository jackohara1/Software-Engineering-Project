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
                grpSearch.Visible = true;
                grdCustomerSearch.Rows.Add("055", "O'Hara", "John");
            }
        }

        private void btnPayInvoice_Click(object sender, EventArgs e)
        {
            btnIssueInvoice.Visible = false;
            grpPayInvoice.Visible = true;
            grdIssue.Rows.Add("011","088","Hammer","10.00","3","30.00");
            grdIssue.Rows.Add("011", "064", "Screw driver", "5.00", "2", "10.00");
        }

        private void btnPayInvoice_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You have payed your invoice");
            this.Close();
            parent.Show();
        }
    }
}
