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
   
    public partial class frmCustomerUpdate : Form
    {
        frmMainMenu parent;
        public frmCustomerUpdate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Regex alphabetic = new Regex("^[a-zA-Z]+$");

            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Surname was left blank");
                txtName.Focus();
                return;
            }
           else if (!alphabetic.IsMatch(txtName.Text))
            {
                MessageBox.Show("Surname must contain letters only");
                txtName.Focus();
                txtName.Clear();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
               
                grdCustomerSearch.DataSource = Customer.getMatchingSurname(ds, txtName.Text.ToUpper()).Tables["ss"];
                grdCustomerSearch.AllowUserToAddRows = false;


                if (grdCustomerSearch.RowCount == 0)
                {
                    grpSearch.Visible = false;
                    MessageBox.Show(Convert.ToString(txtName.Text) + " does not exist in the system please try another Surname");
                    txtName.Text = "";
                }
                else
                {
                    grpSearch.Visible = true;
                }
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {

            Regex alphanumericCheck = new Regex("^[a-zA-Z][a-zA-Z0-9]*$");
            Regex alphabetic = new Regex("^[a-zA-Z]+$");

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
            if (!alphabetic.IsMatch(txtCustomerSurname.Text))
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
                Customer updCust = new Customer();
                updCust.setCustomer_id(Convert.ToInt32(txtCustomerID.Text));
                updCust.setForename(txtCustomerName.Text);
                updCust.setSurname(txtCustomerSurname.Text);
                updCust.setAddln1(txtAddLn1.Text);
                updCust.setAddln2(txtAddLn2.Text);
                updCust.setAddln3(txtAddLn3.Text);


                updCust.updateCustomer();
                MessageBox.Show("customer got updated");
                this.Close();
                parent.Show();
            }
        }

        private void grdCustomerSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Customer updCus = new Customer();
            updCus.getCustomer(Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value));
            txtCustomerID.Text = updCus.getCustomer_id().ToString();
            txtCustomerName.Text = updCus.getForename();
            txtCustomerSurname.Text = updCus.getSurname();
            txtAddLn1.Text = updCus.getAddln1();
            txtAddLn2.Text = updCus.getAddln2();
            txtAddLn3.Text = updCus.getAddln3();


            grpUpdate.Visible = true;

        }
    }   
    }

