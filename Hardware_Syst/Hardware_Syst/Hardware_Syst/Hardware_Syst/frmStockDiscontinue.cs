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
    public partial class frmStockDiscontinue : Form
    {
        frmMainMenu parent;
        public frmStockDiscontinue(frmMainMenu Parent)
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
                grpSearch.Visible = true;
                grdStockSearch.Rows.Add("088", "Hammer");
            }
        }

        private void btnDiscontiueStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Stock has been discontinued");
            this.Close();
            parent.Show();
        }
    }
}
