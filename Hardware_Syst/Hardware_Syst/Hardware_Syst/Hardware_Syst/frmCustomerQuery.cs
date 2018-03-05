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
            else if (!txtName.Text.Equals("Hara"))
            {
                MessageBox.Show("That name does not exist in the system");
                txtName.Focus();
                return;
            }
            else
            {
                grpSearch.Visible = true;
                grdCustomerSearch.Rows.Add("057", "Hara", "John");
            }
        }
    }
}
