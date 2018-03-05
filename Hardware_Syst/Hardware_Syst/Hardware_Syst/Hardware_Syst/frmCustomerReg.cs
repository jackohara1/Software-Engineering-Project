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
    public partial class frmCustomerReg : Form
    {
        frmMainMenu parent;
        public frmCustomerReg(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmCustomerReg_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Close();
                parent.Show();
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
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
                MessageBox.Show("Customer added to the system", "Register");
                txtCustomerID.Text = "002";
                txtCustomerName.Text = "";
                txtCustomerSurname.Text = "";
                txtNumber.Text = "";
                txtAddLn1.Text = "";
                txtAddLn2.Text = "";
                txtAddLn3.Text = "";

            }
        }
    }
}
