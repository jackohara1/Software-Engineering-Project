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
   
    public partial class frmCustomerUpdate : Form
    {
        frmMainMenu parent;
        public frmCustomerUpdate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void Customer_ID_lab_Click(object sender, EventArgs e)
        {

        }

        private void text_Customer_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmCustomerUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            grpUpdate.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Surname was left blank");
                txtName.Focus();
                return;
            }
            else if (!txtName.Text.Equals("Hara"))
            {
                MessageBox.Show("That name does not exist in the system");
                txtName.Focus();
                return;
            }
            else
            {
                grpSearch.Visible = true;
                grdStockSearch.Rows.Add("057", "Hara", "John"); }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {

            if (txtCustomerName.Text.Equals(""))
            {
                MessageBox.Show("Forname was left blank");
                txtCustomerName.Focus();
                return;
            }

            if (txtCustomerSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname was left blank");
                txtCustomerSurname.Focus();
                return;
            }
            if (txtNumber.Text.Equals(""))
            {
                MessageBox.Show("Number was left blank");
                txtNumber.Focus();
                return;
            }
            if (txtAddLn1.Text.Equals(""))
            {
                MessageBox.Show("Address Line 1 was left blank");
                txtAddLn1.Focus();
                return;
            }
            if (txtAddLn2.Text.Equals(""))
            {
                MessageBox.Show("Address Line 2 was left blank");
                txtAddLn2.Focus();
                return;
            }
            if (txtAddLn3.Text.Equals(""))
            {
                MessageBox.Show("Address Line 3 was left blank");
                txtAddLn3.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Stock has been updated");
                this.Close();
                parent.Show();
            }
        }
    }
}
