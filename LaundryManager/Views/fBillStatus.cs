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

        private void fBillStatus_Load(object sender, EventArgs e)
        {
            cbStatus.Text = "--- Lựa chọn ---";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbStatus.Text == "--- Lựa chọn ---")
            {
                MessageBox.Show("Vui lòng chọn trạng thái bill");
            }
            if (cbStatus.Text == "Chưa thanh toán")
            {
                MessageBox.Show("Chưa thanh toán");
            }   
            if (cbStatus.Text=="Đã thanh toán")
            {
                fPayment payment = new fPayment();
                this.Hide();
                payment.ShowDialog();
                this.Close();
            }   
            
            if (cbStatus.Text == "Đã giao hàng")
            {
                fPayment payment = new fPayment();
                this.Hide();
                payment.ShowDialog();
                this.Close();
            }    
        }
    }
}