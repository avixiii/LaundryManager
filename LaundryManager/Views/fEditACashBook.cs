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
    public partial class fEditACashBook : DevExpress.XtraEditors.XtraForm
    {
        public fEditACashBook()
        {
            InitializeComponent();
        }

        private string id;
        private string billType;
        private DateTime billDate;
        private string payer;
        private double amount;
        private string reason;
        private string explain;

        public fEditACashBook(string id, string billType, DateTime billDate, string payer, double amount, string reason, string explain) : this()
        {
            this.id = id;
            this.billType = billType;
            this.billDate = billDate;
            this.payer = payer;
            this.amount = amount;
            this.reason = reason;
            this.explain = explain;
        }

        private void fEditACashBook_Load(object sender, EventArgs e)
        {
            txtID.Text = id;
            cbBillType.Text = billType;
            dtBillDate.DateTime = billDate;
            txtPayer.Text = payer;
            txtAmount.Text = amount.ToString();
            txtReason.Text = reason;
            txtExplain.Text = explain;
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

            Controllers.CashBookController.Update(id ,fLogin.userID, billType, billDate, payer, amount, reason, explain);
            this.Close();
        }
    }
}