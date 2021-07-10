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
    public partial class fCreateFinancialInvoice : DevExpress.XtraEditors.XtraForm
    {
        public fCreateFinancialInvoice()
        {
            InitializeComponent();
        }

        private void fCreateFinancialInvoice_Load(object sender, EventArgs e)
        {
            cbBillType.Text = "Chọn loại phiếu";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBillType.Text == "Phiếu thu")
            {
                labelControl4.Text = "Người nộp";
            }
            if (cbBillType.Text == "Phiếu chi")
            {
                labelControl4.Text = "Người nhận";
            }
        }
    }
}