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
    public partial class frmCustomerQuery : Form
    {
        frmMainMenu parent;
        public frmCustomerQuery(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnQueryCustomer_Click(object sender, EventArgs e)
        {
            grdQuery.Rows.Add("044",  "John", "Hara","087952545","Dirtane","Ballyheigue","Co.Kerry");
            grdQuery.Visible = true;
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

        private void grdCustomerSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdQuery.Rows.Clear();
            Customer disCust = new Customer();

            disCust.getCustomer(Convert.ToInt32(grdCustomerSearch.Rows[grdCustomerSearch.CurrentCell.RowIndex].Cells[0].Value));
            DataSet db = new DataSet();




            grdQuery.Visible = true;
            grdQuery.Rows.Add(Convert.ToInt16(disCust.getCustomer_id()), Convert.ToString(disCust.getForename()), Convert.ToString(disCust.getSurname()),
                Convert.ToString(disCust.getAddln1()), Convert.ToString(disCust.getAddln2()), Convert.ToString(disCust.getAddln3()), Convert.ToDecimal(disCust.getBalance()));


        }
    }
}
