﻿using System;
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

            else
            {

                DataSet ds = new DataSet();
                grpSearch.Visible = true;
                grdCustomerSearch.DataSource = Customer.getMatchingSurname(ds, txtCustomer.Text.ToUpper()).Tables["ss"];
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
            grdIssue.DataSource = Saleitem.getMatchingInvoice(ds, Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value)).Tables["ss"];

            Customer Invoice = new Customer();
            Invoice.getCustomer(Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value));

            int i = 0;
            while (i < grdIssue.RowCount - 1)
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(grdIssue.Rows[i].Cells[5].Value));

                i++;
            }

        }
    }
  
}
