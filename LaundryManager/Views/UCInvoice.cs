using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManager.Views
{
    public partial class UCInvoice : System.Windows.Forms.UserControl
    {
        public UCInvoice()
        {
            InitializeComponent();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            fCreateBill fCreateBill = new fCreateBill();
            fCreateBill.ShowDialog();
            ShowInvoice();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void UCInvoice_Load(object sender, EventArgs e)
        {
            ShowInvoice();
        }

       
        public void ShowInvoice()
        {
            cbStatus.Text = "-- Lựa chọn --";
            gcInvoice.DataSource = Models.InvoiceModel.FillDataSetInvoice() ;
            gcInvoice.DataMember = "Bills";

        }

        public static string totalBill;
        public static string billCode;
        private void riBtnStatus_Click(object sender, EventArgs e)
        {
            // Lấy billcode
            object value;
            int rowIndex = gvBills.FocusedRowHandle;
            string colFieldBillCode = "BillCode";
            value = gvBills.GetRowCellValue(rowIndex, colFieldBillCode);
            billCode = (string)value;

            // Lấy trạng thái
            string colFieldStatus = "Status";
            value = gvBills.GetRowCellValue(rowIndex, colFieldStatus);
            string status = (string)value;

            // Lấy tổng tiền của bill

            string colFieldTotal = "Total";
            value = gvBills.GetRowCellValue(rowIndex, colFieldTotal);

            totalBill = value.ToString();

            if (status == "Giao khách")
            {
                MessageBox.Show("Đơn đã giao khách ko thể chỉnh sửa.");
            }
            else
            {
                // Mở form mới
                fBillStatus fstatus = new fBillStatus(billCode, status);
                fstatus.ShowDialog();
                ShowInvoice();
            }    

           
        }

        private void ckbID_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbID.Checked)
            {
                txtID.Enabled = true;
                btnSearchByID.Enabled = true;
            }
            else
            {
                txtID.Enabled = false;
                btnSearchByID.Enabled = false;
            }
        }

        private void ckbEmployee_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbEmployee.Checked)
            {
                txtEmployee.Enabled = true;
            }
            else
            {
                txtEmployee.Enabled = false;
            }
        }

        private void ckbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCustomer.Checked)
            {
                txtCustomer.Enabled = true;
            }
            else
            {
                txtCustomer.Enabled = false;
            }
        }


        private void ckbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTime.Checked)
            {
                dtTime.Enabled = true;
            }
            else
            {
                dtTime.Enabled = false;
            }
        }

        private void ckbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbStatus.Checked)
            {
                cbStatus.Enabled = true;
            }
            else
            {
                cbStatus.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = gvBills.FocusedRowHandle;
            object value;
            // Lấy id
            string colFieldID = "BillCode";
            value = gvBills.GetRowCellValue(rowIndex, colFieldID);
            if (value == null)
            {
                MessageBox.Show("Vui lòng chọn vào hoá đơn muốn xoá");
            }    
            else
            {
                string billCode = value.ToString();
                Controllers.BillsController.Delete(billCode);
                ShowInvoice();
            }    
            
        }
    }
}
