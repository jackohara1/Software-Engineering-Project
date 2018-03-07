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
    public partial class frmProcessSale : Form
    {
        frmMainMenu parent;
      
        public frmProcessSale(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtStockID6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProcessSale_Load(object sender, EventArgs e)
        {
            txtSaleID.Text = Sale.getNextSale_id().ToString("0000");
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void cboPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        
        private void btnRegesterSale_Click(object sender, EventArgs e)
        {
            Sale mySale = new Sale();
            mySale.setSale_id(Convert.ToInt32(txtSaleID.Text));
            mySale.setCustomer_id(1);
            mySale.setSaleDate(Convert.ToString(DateTime.Now));
            mySale.setStatus(Convert.ToString('A'));
            mySale.setSaleValue(Convert.ToDecimal(txtSaleValue.Text));

            mySale.addSale();

            Saleitem[] newSale = new Saleitem[grdCart.RowCount]; 
            for (int x=1; x <= grdCart.RowCount; x++)
            {
                
                newSale[x].setSaleitem_id(Saleitem.getNextSaleitem_id());
                newSale[x].setQtysold(Convert.ToInt32(grdCart.Rows[x].Cells[2].Value));
                newSale[x].setPrice(Convert.ToDecimal(grdCart.Rows[x].Cells[6].Value));
                newSale[x].setSale_id(Convert.ToInt32(txtSaleID.Text));
                newSale[x].setStock_id(Convert.ToInt32(grdCart.Rows[x].Cells[0].Value));
                newSale[x].addSaleitems();

            }


           
            MessageBox.Show("Sale has been registered");
            this.Close();
            parent.Show();
        }

        private void btnSrh_Click(object sender, EventArgs e)
        {
            if (txtSrh.Text.Equals(""))
            {
                MessageBox.Show("Stock Name was left blank");
                txtSrh.Focus();
                return;
            }
       

            else
            {
                DataSet ds = new DataSet();
                grpStock.Visible = true;
                grdStock.DataSource = Stock.getMatchingSaleStock(ds, txtSrh.Text).Tables["ss"];
                
            }

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            grpPay.Visible = true;
        }

        private void rdoCredit_CheckedChanged(object sender, EventArgs e)
        {
            grpCredit.Visible = true;
            
            btnRegesterSale.Visible = false;
        }

        private void grdStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpCart.Visible = true;
            grdCart.Rows.Add(Convert.ToString(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value),  Convert.ToString(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[1].Value), Convert.ToString(1),"+","-","remove", Convert.ToString(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[2].Value));
            txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[2].Value) + Convert.ToDecimal(txtSaleValue.Text));
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text.Equals(""))
            {
                MessageBox.Show("Surname was left blank");
                txtCustomer.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                grdCust.Visible = true;
                grdCust.DataSource = Customer.getMatchingSurname(ds, txtCustomer.Text.ToUpper()).Tables["ss"];
            }
        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            btnRegesterSale.Visible = true;
            grpCredit.Visible = false;
        }

      

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            btnRegesterSale.Visible = true;
        }

      

        private void grdCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdCart.Columns["Quantityadd"].Index && e.RowIndex >= 0)
            {
              
                grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value = ((Convert.ToInt16(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) + 1).ToString());
                txtSaleValue.Text =Convert.ToString(Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value) + Convert.ToDecimal(txtSaleValue.Text));

            }
            else if (e.ColumnIndex == grdCart.Columns["Quantityminus"].Index && e.RowIndex >= 0)
            {
              
                grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value = ((Convert.ToInt16(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value) - 1).ToString());
                txtSaleValue.Text = Convert.ToString(Convert.ToDecimal(txtSaleValue.Text)-  Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value));
            }
            else if (e.ColumnIndex == grdCart.Columns["remove"].Index && e.RowIndex >= 0)
            {
                 txtSaleValue.Text = Convert.ToString(Convert.ToDecimal( txtSaleValue.Text) - (Convert.ToDecimal(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[6].Value) * Convert.ToInt32(grdCart.Rows[grdCart.CurrentCell.RowIndex].Cells[2].Value)));
                 grdCart.Rows.Remove(grdCart.Rows[grdCart.CurrentCell.RowIndex]);
               
            }
        }

        private void grdCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sale mySale = new Sale();
            mySale.setSale_id(Convert.ToInt32(txtSaleID.Text));
            mySale.setCustomer_id(Convert.ToInt16(grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[0].Value));
            mySale.setSaleDate(Convert.ToString(DateTime.Now));
            mySale.setStatus(Convert.ToString('A'));
            mySale.setSaleValue(Convert.ToDecimal(txtSaleValue.Text));

            mySale.addSale();

            Saleitem[] newSale = new Saleitem[100];
            for (int x = 1; x < grdCart.RowCount; x++)
            {
                int y = Saleitem.getNextSaleitem_id();
                newSale[x].setSaleitem_id(y);
                newSale[x].setQtysold(Convert.ToInt32(grdCart.Rows[x].Cells[2].Value));
                newSale[x].setPrice(Convert.ToDecimal(grdCart.Rows[x].Cells[6].Value));
                newSale[x].setSale_id(Convert.ToInt32(txtSaleID.Text));
                newSale[x].setStock_id(Convert.ToInt32(grdCart.Rows[x].Cells[0].Value));
                newSale[x].addSaleitems();

            }



            MessageBox.Show("Sale has been registered");
            this.Close();
            parent.Show();
        }
    }
}
