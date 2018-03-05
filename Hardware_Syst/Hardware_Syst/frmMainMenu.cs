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
    public partial class frmMainMenu : Form
    {
       
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuStockNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStockAdd frmNextForm = new frmStockAdd(this);
            frmNextForm.Show();
        }

        private void mnuStockUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Stock frmNextForm = new Update_Stock(this);
            frmNextForm.Show();

        }

        private void mnuStockDiscontinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStockDiscontinue frmNextForm = new frmStockDiscontinue(this);
            frmNextForm.Show();
        }

        private void mnuStockEnquiry_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStockEnquiry frmNextForm = new frmStockEnquiry(this);
            frmNextForm.Show();
        }

        private void mnuCustomerReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerReg frmNextForm = new frmCustomerReg(this);
            frmNextForm.Show();
        }

        private void mnuCustomerUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerUpdate frmNextForm = new frmCustomerUpdate(this);
            frmNextForm.Show();
        }

        private void mnuCustomerQuery_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerQuery frmNextForm = new frmCustomerQuery(this);
            frmNextForm.Show();
        }

        private void mnuProcessSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProcessSale frmNextForm = new frmProcessSale(this);
            frmNextForm.Show();
        }

        private void mnuInvoiceIssue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceIssue frmNextForm = new frmInvoiceIssue(this);
            frmNextForm.Show();
        }

        private void mnuReturnItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnItem frmNextForm = new frmReturnItem(this);
            frmNextForm.Show();
        }

        private void mnuInvoicePay_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoicePay frmNextForm = new frmInvoicePay(this);
            frmNextForm.Show();
        }

        private void mnuAnalysisSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnalysisSales frmNextForm = new frmAnalysisSales(this);
            frmNextForm.Show();
        }

        private void mnuAnalysisStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnalysisStock frmNextForm = new frmAnalysisStock(this);
            frmNextForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
