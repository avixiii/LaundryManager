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
    public partial class fBillStatus : DevExpress.XtraEditors.XtraForm
    {
        public fBillStatus()
        {
            InitializeComponent();
        }

        private string billCode;
        private string status;

        public fBillStatus(string billCode, string status): this()
        {
            this.billCode = billCode;
            this.status = status;
        }

        private void fBillStatus_Load(object sender, EventArgs e)
        {
            cbStatus.Text = status; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string textStatus = cbStatus.Text;
            
            if (cbStatus.Text=="Giặt xong")
            {
                Controllers.BillsController.UpdateStatus(billCode, textStatus);
                this.Close();
            }   
            
            if (cbStatus.Text == "Giao khách")
            {
                if (status == "Thanh toán")
                {
                    Controllers.BillsController.UpdateStatus(billCode, textStatus);
                    this.Close();
                }
                else
                {
                    Payment(textStatus);
                }            
                this.Close();
            }

            if (cbStatus.Text == "Thanh toán")
            {
                Payment(textStatus);
            }
        }

        private void Payment(string textStatus)
        {
            fPayment payment = new fPayment();
            this.Hide();
            payment.ShowDialog();
            int i = Controllers.BillsController.UpdateStatus(billCode, textStatus);
            this.Close();
        }
    }
}