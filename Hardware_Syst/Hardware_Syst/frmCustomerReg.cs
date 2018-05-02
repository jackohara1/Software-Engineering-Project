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
            Regex alphanumericCheck = new Regex("^[a-zA-Z][a-zA-Z0-9 ]*$");
            Regex alphabetic = new Regex("^[a-zA-Z ]+$");

            if (txtCustomerName.Text.Equals(""))
            {
                MessageBox.Show("Forname was left blank");
                txtCustomerName.Focus();
                return;
            }
           else if (!alphabetic.IsMatch(txtCustomerName.Text))
            {
                MessageBox.Show("Forname must contain letters only");
                txtCustomerName.Focus();
                txtCustomerName.Clear();
                return;
            }

           else if (txtCustomerSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname was left blank");
                txtCustomerSurname.Focus();
                return;
            }
           else if (!alphabetic.IsMatch(txtCustomerSurname.Text))
            {
                MessageBox.Show("Surname must contain letters only");
                txtCustomerSurname.Focus();
                txtCustomerSurname.Clear();
                return;
            }

           else if (txtAddLn1.Text.Equals(""))
            {
                MessageBox.Show("Address Line 1 was left blank");
                txtAddLn1.Focus();
                return;
            }
           else if (!alphanumericCheck.IsMatch(txtAddLn1.Text))
            {
                MessageBox.Show("Address line 1 must contain alphanumeric characters only");
                txtAddLn1.Focus();
                txtAddLn1.Clear();
                return;
            }
           else if (txtAddLn2.Text.Equals(""))
            {
                MessageBox.Show("Address Line 2 was left blank");
                txtAddLn2.Focus();
                return;
            }
           else if (!alphanumericCheck.IsMatch(txtAddLn2.Text))
            {
                MessageBox.Show("Address line 2 must contain alphanumeric characters only");
                txtAddLn2.Focus();
                txtAddLn2.Clear();
                return;
            }
           else if (txtAddLn3.Text.Equals(""))
            {
                MessageBox.Show("Address Line 3 was left blank");
                txtAddLn3.Focus();
                return;
            }
           else if (!alphanumericCheck.IsMatch(txtAddLn3.Text))
            {
                MessageBox.Show("Address line 3 must contain alphanumeric characters only");
                txtAddLn3.Focus();
                txtAddLn3.Clear();
                return;
            }
            else
            {
                Customer newCustomer = new Customer();
                newCustomer.setCustomer_id(Convert.ToInt32(txtCustomerID.Text));
                newCustomer.setSurname(txtCustomerSurname.Text.ToUpper());
                newCustomer.setForename(txtCustomerName.Text.ToUpper());
                newCustomer.setAddln1(txtAddLn1.Text.ToUpper());
                newCustomer.setAddln2(txtAddLn2.Text.ToUpper());
                newCustomer.setAddln3(txtAddLn3.Text.ToUpper());


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
