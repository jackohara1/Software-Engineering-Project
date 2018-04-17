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
