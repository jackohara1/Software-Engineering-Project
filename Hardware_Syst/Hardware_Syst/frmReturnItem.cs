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
    public partial class frmReturnItem : Form
    {
        frmMainMenu parent;
        public frmReturnItem(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void lblStockID_Click(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }



        private void lblHowCustomerPayed_Click(object sender, EventArgs e)
        {

        }

        private void frmReturnItem_Load(object sender, EventArgs e)
        {

        }

        private void btnSrh_Click(object sender, EventArgs e)
        {
            if (txtSaleID.Text.Equals(""))
            {
                MessageBox.Show("Sale ID was left blank");
                txtSaleID.Focus();
                return;
            }

            else
            {
                grpStock.Visible = true;
                DataSet ds = new DataSet();
                grdCart.DataSource = Saleitem.getMatchingSaleItem(ds, Convert.ToInt32(txtSaleID.Text)).Tables["ss"];
            }

        }







        private void btnReturnItem_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt16(txtQtySold.Text) > Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[1].Value))
            {
                MessageBox.Show("The quantity you are returning is greater than the quantity you have bought");
            }

            if (rdoTrue.Checked)
            {
                Stock.returnStock(Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[0].Value), Convert.ToInt32(txtQtySold));
            }


            Saleitem.returnStock(Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[0].Value), Convert.ToInt16(txtQtySold.Text));
            Sale.returnSale(Convert.ToInt32(txtSaleID.Text), Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) * Convert.ToInt16(txtQtySold.Text));


            MessageBox.Show("Item has been returned");



            this.Close();
            parent.Show();
        }



        private void grdCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[1].Value) > 1)
            {
                lblAmountOfItems.Visible = true;
                txtQtySold.Visible = true;

            }
            txtQtySold.Text = grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[1].Value.ToString();
            lblItemBack.Visible = true;
            rdoFalse.Visible = true;
            rdoTrue.Visible = true;

            btnReturnItem.Visible = true;




        }

    }
}