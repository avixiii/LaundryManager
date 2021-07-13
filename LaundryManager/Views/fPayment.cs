using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManager.Views
{
    public partial class fPayment : DevExpress.XtraEditors.XtraForm
    {
        public fPayment()
        {
            InitializeComponent();
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            string strTotalBill = txtTotalBill.Text;
            double totalBill;
            if (strTotalBill == "")
            {
                totalBill = 0;
            }    
            else
            {
                totalBill = double.Parse(strTotalBill);
            }    
            string strPaid = txtPaid.Text;
            double paid;
            if (strPaid == "")
            {
                paid = 0;
            }
            else
            {
                paid = double.Parse(strPaid);
            }    

            double mustBePaid = paid - totalBill;
            txtMustBePaid.Text = mustBePaid.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double paid = double.Parse(txtPaid.Text);
            double mustBePaid = double.Parse(txtMustBePaid.Text);

            int i = Controllers.BillsController.Payment(UCInvoice.billCode, paid, mustBePaid);

            if (i == 0)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                MessageBox.Show("Thành công");
                this.Close();
            }    

        }

        private void fPayment_Load(object sender, EventArgs e)
        {
            txtTotalBill.Text = UCInvoice.totalBill;
        }
    }
}