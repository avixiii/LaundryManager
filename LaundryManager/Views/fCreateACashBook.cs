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
    public partial class fCreateACashBook : DevExpress.XtraEditors.XtraForm
    {
        public fCreateACashBook()
        {
            InitializeComponent();
        }

       

        private void fCreateFinancialInvoice_Load(object sender, EventArgs e)
        {
            cbBillType.Text = "Chọn loại phiếu";
            txtID.Text = Models.Connection.ExcuteScalar(String.Format("SELECT dbo.fcgetCashBookID()"));

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string billType = cbBillType.Text;
            string strBillDate = dtBillDate.Text;
            DateTime billDate = DateTime.Parse(strBillDate);
            string payer = txtPayer.Text;

            string strAmount = txtAmount.Text;
            if (strAmount == "")
            {
                strAmount = "0";
            }    
            double amount = double.Parse(strAmount);
            string reason = txtReason.Text;
            string explain = txtExplain.Text;
            int userID = fLogin.userID;

            Controllers.CashBookController.Insert(id, userID, billType, billDate, payer, amount, reason, explain);
            this.Close();
        }
    }
}