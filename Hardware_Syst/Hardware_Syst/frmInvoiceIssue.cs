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
                    grpSearch.Visible = false;
                    grpIssueInvoice.Visible = false;
                    MessageBox.Show(Convert.ToString(txtCustomer.Text) + " does not exist in the system please try another surname");
                    txtCustomer.Text = "";
                }
                else
                {
                    grpSearch.Visible = true;
                }
            }
        }
        private void grdCustomerSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            DataSet ds = new DataSet();
            grdIssue.DataSource = Saleitem.getMatchingInvoice(ds, Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value)).Tables["ss"];
            grdIssue.AllowUserToAddRows = false;

            Customer Invoice = new Customer();
            Invoice.getCustomer(Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value));
            txtTotal.Text = "0.00";
            txtAddln1.Text = Convert.ToString(Invoice.getAddln1());
            txtAddln2.Text = Convert.ToString(Invoice.getAddln2());
            txtAddln3.Text = Convert.ToString(Invoice.getAddln3());
            int i = 0;
            while (i < grdIssue.RowCount)
            {
          
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text)+Convert.ToDecimal(grdIssue.Rows[i].Cells[5].Value));
                
                i++;
            }

            if (grdIssue.RowCount == 0)
            {
                grpIssueInvoice.Visible = false;
                MessageBox.Show(Convert.ToString(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[2].Value) + " " + Convert.ToString(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[1].Value) + " does not owe the company any money");
            }

            else
            {
                grpIssueInvoice.Visible = true;
            }
        }
    }
}
