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
            txtCustomerID.Text = Customer.getNextCustomer_id().ToString("0000");
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
                Customer newCustomer = new Customer();
                newCustomer.setCustomer_id(Convert.ToInt32(txtCustomerID.Text));
                newCustomer.setSurname(txtCustomerSurname.Text);
                newCustomer.setForename(txtCustomerName.Text);
                newCustomer.setAddln1(txtAddLn1.Text);
                newCustomer.setAddln2(txtAddLn2.Text);
                newCustomer.setAddln3(txtAddLn3.Text);


                newCustomer.addCustomer();

                MessageBox.Show("Customer added to the system", "Register");
               
                txtCustomerName.Text = "";
                txtCustomerSurname.Text = "";
             
                txtAddLn1.Text = "";
                txtAddLn2.Text = "";
                txtAddLn3.Text = "";

                txtCustomerID.Text = Customer.getNextCustomer_id().ToString("00000");
                txtCustomerName.Focus();
            }
        }
    }
}
