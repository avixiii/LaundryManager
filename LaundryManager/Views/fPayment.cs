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
            double totalBill = double.Parse(strTotalBill);
            string strPaid = txtPaid.Text;
            double paid = double.Parse(strPaid);

            double mustBePaid = paid - totalBill;
            txtMustBePaid.Text = mustBePaid.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}