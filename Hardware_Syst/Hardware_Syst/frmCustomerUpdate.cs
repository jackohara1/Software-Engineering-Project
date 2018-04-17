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

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Surname was left blank");
                txtName.Focus();
                return;
            }
           
            else
            {
                DataSet ds = new DataSet();
                grpSearch.Visible = true;
                grdCustomerSearch.DataSource = Customer.getMatchingSurname(ds, txtName.Text.ToUpper()).Tables["ss"];
                grdCustomerSearch.AllowUserToAddRows = false;
            }
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

