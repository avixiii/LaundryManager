using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManager.Views
{
    public partial class UCCashBook : DevExpress.XtraEditors.XtraUserControl
    {
        public UCCashBook()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            fCreateACashBook fCreateCB = new fCreateACashBook();
            fCreateCB.ShowDialog();
            ShowCashBook();
        }

        public void ShowCashBook()
        {
            gcCashBook.DataSource = Models.CashBookModel.FillDataSetCashBook();
            gcCashBook.DataMember = "CashBook";

            
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            lblSpendingMoney.Text = double.Parse(CalculatorCashBook("Phiếu chi").ToString()).ToString("#,###", cul.NumberFormat) + " VNĐ";

            lblTienThu.Text = double.Parse(CalculatorCashBook("Phiếu thu").ToString()).ToString("#,###", cul.NumberFormat) + " VNĐ";

        }

        // Tính tiền  thu chi
        public double CalculatorCashBook(string billType)
        {
            double total = 0 ;
            int count = gvCashBook.DataRowCount;
            for (int idx = 0; idx < count; idx++)
            {
                string type = (string)gvCashBook.GetRowCellValue(idx, "BillType");
                if (type == billType)
                {
                    // Lay gia tri 
                    string strAmount = gvCashBook.GetRowCellValue(idx, "Amount").ToString();
                    double amount = double.Parse(strAmount);
                    total += amount;
                }
            }
            return total;
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
                ckbEmployee.Enabled = false;
            }    
        }

        private void ckbBillType_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBillType.Checked)
            {
                cbBillType.Enabled = true;
            }    
            else
            {
                cbBillType.Enabled = false;
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

        private void ckbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDate.Checked)
            {
                dt1.Enabled = true;
                dt2.Enabled = true;
            }    
            else
            {
                dt1.Enabled = false;
                dt2.Enabled = false;
            }    
        }

        private void UCCashBook_Load(object sender, EventArgs e)
        {
            ShowCashBook();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = gvCashBook.FocusedRowHandle;
            object value;
            // Lấy id
            string colFieldID = "ID";
            value = gvCashBook.GetRowCellValue(rowIndex, colFieldID);

            if (value == null)
            {
                MessageBox.Show("Vui lòng chọn vào hoá đơn muốn xoá");
            }
            else
            {
                string id = value.ToString();
                Controllers.CashBookController.Delete(id);
                ShowCashBook();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvCashBook.IsFocusedView)
            {
            }

            // Lấy các giá trị
            int rowIndex = gvCashBook.FocusedRowHandle;
            object value;

            // Lấy ID
            string colFieldID = "ID";
            value = gvCashBook.GetRowCellValue(rowIndex, colFieldID);
            string id = (string)value;


            // Loại phiếu
            string colFieldBillType = "BillType";
            value = gvCashBook.GetRowCellValue(rowIndex, colFieldBillType);
            string billType = (string)value;

            // Ngày tạo hoá đơn
            string colFieldDate = "BillDate";
            value = gvCashBook.GetRowCellValue(rowIndex, colFieldDate);
            DateTime billDate = DateTime.Parse(value.ToString());


            // Người nhận
            string colFieldPayer = "Payer";
            value = gvCashBook.GetRowCellValue(rowIndex, colFieldPayer);
            string payer = (string)value;

            // Số tiền
            string colFieldAmount = "Amount";
            value = gvCashBook.GetRowCellValue(rowIndex, colFieldAmount);
            double amount = double.Parse(value.ToString());


            // Lý do
            string colFieldReason = "Reason";
            value = gvCashBook.GetRowCellValue(rowIndex, colFieldReason);
            string reason = (string)value;


            // Diễn giải 
            string colFieldExplain = "Explain";
            value = gvCashBook.GetRowCellValue(rowIndex, colFieldExplain);
            string explain = (string)value;


            fEditACashBook edit = new fEditACashBook(id, billType, billDate, payer, amount, reason, explain);

            edit.ShowDialog();
            ShowCashBook();
        }
    }
}
