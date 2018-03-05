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
    public partial class frmStockEnquiry : Form
    {
        frmMainMenu parent;
        public frmStockEnquiry(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

      

        private void frmStockEnquiry_Load(object sender, EventArgs e)
        {

        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtStockName.Text.Equals(""))
            {
                MessageBox.Show("Stock Name was left blank");
                txtStockName.Focus();
                return;
            }
            else if (!txtStockName.Text.Equals("Hammer"))
            {
                MessageBox.Show("This Stock name does not exist in the system");
                txtStockName.Focus();
                return;
            }
            else
            {
             grdCustomerSearch.Rows.Add("088", "Hammer");
             grpSearch.Visible = true;
              }
           
        }

        private void btnStockEnquirery_Click(object sender, EventArgs e)
        {
            grdEnquiry.Visible = true;
            grdEnquiry.Rows.Add("088", "Hammer","Tools","10.00","20.00","A");
        }
    }
}
